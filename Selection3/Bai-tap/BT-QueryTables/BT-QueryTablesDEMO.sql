-- 1. Liệt kê thông tin ID, Họ tên, Tuổi của nhân viên.
SELECT	EmployeeID,
		CONCAT(FirstName,'',LastName) AS 'Full Name',
		(YEAR(GETDATE())-YEAR(BirthDate)) AS 'Year Old'
FROM Employees
GO

-- 2. Bổ sung thêm thông tin về quốc gia. Lọc lấy các khách hàng thuộc nước Pháp và Tây Ban Nha cùng mã số hóa đơn khách đã mua trong quý 3 và 4 của năm 1997.
SELECT O.OrderID, O.OrderDate, C.* 
FROM Customers AS C LEFT JOIN Orders AS O ON C.CustomerID = O.CustomerID
WHERE	(C.Country = 'France' OR C.Country = 'Spain') AND
		YEAR(O.OrderDate) = 1997 AND
		(DATEPART(QUARTER,OrderDate) = 3 OR DATEPART(QUARTER,OrderDate) = 4)
GO

-- 3. Giới hạn lại trong các hóa đơn khách đã mua trong quý 3 và 4 của năm 1997.
SELECT O.OrderID, O.OrderDate, C.* 
FROM Customers AS C LEFT JOIN Orders AS O ON C.CustomerID = O.CustomerID
WHERE	YEAR(O.OrderDate) = 1997 AND
		(DATEPART(QUARTER,OrderDate) = 3 OR DATEPART(QUARTER,OrderDate) = 4)
GO

-- 4. Tính tổng cước phí mỗi khách hàng đã trả cho mỗi nhà chuyên chở. Cước phí: Freight, Nhà chuyên chở: ShipVia/Shipper.
SELECT	S.CompanyName,
		ROUND(SUM(O.Freight),2) AS 'Total Freight'
FROM Orders AS O	LEFT JOIN Shippers AS S ON O.ShipVia = S.ShipperID
GROUP BY S.CompanyName
GO

-- 5. Tính tổng số tiền mỗi khách đã mua trong năm 1997.
SELECT	O.CustomerID,
		C.CompanyName,
		C.ContactName,
		ROUND(SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)),2) AS 'Total Money Buy'
FROM Orders AS O	LEFT JOIN [Order Details] AS OD ON O.OrderID=OD.OrderID
					LEFT JOIN Customers AS C ON O.CustomerID = C.CustomerID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY O.CustomerID,C.CompanyName,C.ContactName
GO

-- 6. Tính tổng doanh số mỗi nhân viên đã bán được trong năm 1997
SELECT	E.EmployeeID,
		CONCAT(E.FirstName,'',E.LastName) AS 'Full Name',
		ROUND(SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)),2) AS 'Total Money Sell'
FROM Orders AS O	LEFT JOIN [Order Details] AS OD ON O.OrderID=OD.OrderID
					LEFT JOIN Employees AS E ON  O.EmployeeID = E.EmployeeID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY E.EmployeeID, CONCAT(E.FirstName,'',E.LastName)
ORDER BY E.EmployeeID ASC
GO

-- 7. Tính tổng tiền bán được của mỗi loại sản phẩm trong năm 1997? 
SELECT	P.ProductID,
		P.ProductName,
		ROUND(SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)),2) AS 'Total Money Sell'
FROM [Order Details] AS OD	LEFT JOIN Products AS P ON OD.ProductID = P.ProductID
							LEFT JOIN Orders AS O ON OD.OrderID=O.OrderID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY P.ProductID, P.ProductName
ORDER BY P.ProductID ASC
GO

-- Từng quý năm 1997?
SELECT	P.ProductID,
		P.ProductName,
		(DATEPART(QUARTER,O.OrderDate)) AS 'Quater',
		ROUND(SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)),2) AS 'Total Money Sell'
FROM [Order Details] AS OD	LEFT JOIN Products AS P ON OD.ProductID = P.ProductID
							LEFT JOIN Orders AS O ON OD.OrderID=O.OrderID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY P.ProductID, P.ProductName,(DATEPART(QUARTER,O.OrderDate))
ORDER BY P.ProductID ASC
GO

-- 8. Liệt kê các quốc gia có trên 3 khách hàng
SELECT	C.Country,
		COUNT(C.Country) AS 'Count'
FROM Customers AS C
GROUP BY C.Country
HAVING COUNT(C.Country) > 3

-- 9. Liệt kê loại sản phẩm có số lượng sản phẩm nhiều nhất
SELECT	P.ProductID,
		P.ProductName,
		SUM(OD.Quantity) AS 'Amount'
FROM [Order Details] AS OD LEFT JOIN Products AS P ON OD.ProductID = P.ProductID
GROUP BY P.ProductID, P.ProductName
ORDER BY SUM(OD.Quantity) DESC
GO

-- 10. Liệt kê tên khách hàng mua hàng nhiều nhất trong năm 1997? 
SELECT TOP(10) 
		C.CustomerID,
		C.CompanyName,
		C.ContactName,
		ROUND(SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)),2) AS 'Total Money Buy'
FROM Orders AS O	LEFT JOIN Customers AS C ON O.CustomerID = C.CustomerID
					LEFT JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY C.CustomerID, C.CompanyName, C.ContactName
ORDER BY ROUND(SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)),2) DESC
GO
-- Trong mỗi năm?
-- Cách 1
CREATE FUNCTION BestSales()
RETURNS @BestSalesOfYear TABLE (
				[year] INT,
				Customer VARCHAR(50),
				Amount FLOAT
				)
AS
BEGIN
DECLARE @tbYear TABLE([year] INT)
DECLARE @year INT
INSERT INTO @tbYear SELECT DISTINCT YEAR(OrderDate) [Year] FROM Orders
WHILE (EXISTS (SELECT * FROM @tbYear))
	BEGIN
	
		SET @year = (SELECT TOP(1) [Year] FROM @tbYear)
		INSERT INTO @BestSalesOfYear
		SELECT TOP(1) YEAR(O.OrderDate)as 'YEAR',o.CustomerID as 'CUSTOMER', ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3)
		FROM [dbo].[Customers] C
		INNER JOIN [dbo].[Orders] O ON O.CustomerID = C.CustomerID
		INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
		GROUP BY YEAR(O.OrderDate),o.CustomerID
		having YEAR(O.OrderDate) = @year
		ORDER BY YEAR(O.OrderDate),ROUND(SUM((1 - OD.Discount) * OD.UnitPrice * OD.Quantity),3) DESC
		DELETE FROM @tbYear WHERE [Year] = @year		
	END
RETURN
END
 SELECT * FROM BestSales() ORDER BY [YEAR] DESC

 -- Cách 2
 SELECT * FROM (
SELECT	H.*,
		RANK() OVER (PARTITION BY Years ORDER BY [Total Money Buy] DESC) AS BXH 
FROM (
SELECT TOP(20) 
		C.CustomerID,
		C.CompanyName,
		C.ContactName,
		YEAR(O.OrderDate) AS 'Years',
		ROUND(SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)),2) AS 'Total Money Buy'
FROM Orders AS O	LEFT JOIN Customers AS C ON O.CustomerID = C.CustomerID
					LEFT JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID

GROUP BY C.CustomerID, C.CompanyName, C.ContactName,YEAR(O.OrderDate)
ORDER BY ROUND(SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)),2) DESC
) AS H 
) AS B 
WHERE B.BXH=1
GO