-- 1. Liệt kê thông tin các hóa đơn bao gồm số hóa đơn, ngày và ngày giao hàng trong tháng 7/1997? 
SELECT OrderID, OrderDate, ShippedDate
FROM Orders
WHERE MONTH(OrderDate) = 7 AND YEAR(OrderDate) = 1997
GO
-- Trong quý 1 năm 1997?
SELECT OrderID, OrderDate, ShippedDate, DATEPART(QUARTER,OrderDate) AS 'Quarter'
FROM Orders
WHERE DATEPART(QUARTER,OrderDate) = 1 AND YEAR(OrderDate) = 1997
GO
--  Trong nữa tháng đầu tiên của tháng 7/1997?
SELECT OrderID, OrderDate, ShippedDate
FROM Orders
WHERE MONTH(OrderDate) = 7 AND YEAR(OrderDate) = 1997 AND DAY(OrderDate) < 16
GO

-- 2. Liệt kê thông tin STT, Tên, Ngày sinh của nhân viên.
SELECT EmployeeID, LastName, FirstName, BirthDate
FROM Employees
GO

-- 3. Liệt kê các khách hàng đã mua hàng trong năm 1997
SELECT DISTINCT C.* 
FROM Customers AS C LEFT JOIN Orders AS O ON C.CustomerID = O.CustomerID
WHERE YEAR(O.OrderDate) = 1997
GO

-- 4. Liệt kê các sản phẩm do công ty Exotic Liquids cung cấp trong năm 1997 và 1998
SELECT DISTINCT P.* 
FROM Orders AS O LEFT JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID,
	[Order Details] LEFT JOIN Products AS P ON [Order Details].ProductID = P.ProductID 
WHERE (YEAR(OrderDate) = 1998 OR YEAR(OrderDate) = 1997) AND P.SupplierID = 1
GO

-- 5. Liệt kê chi tiết về ID, Tên sản phẩm, Số lượng, Đơn giá, Giảm giá, Thành tiền (trước giảm giá) của các đơn đặt hàng
SELECT	OD.OrderID,
		P.ProductName,
		OD.UnitPrice,
		Quantity,
		Discount,
		(OD.UnitPrice * OD.Quantity) AS 'Total Price'
FROM [Order Details] AS OD LEFT JOIN Products AS P ON OD.ProductID = P.ProductID
GO

-- 6. Liệt kê các thông tin chi tiết trên của các đơn đặt hàng trong tháng 1/1998
SELECT * FROM Orders
WHERE MONTH(OrderDate) = 1 AND YEAR(OrderDate) = 1998
GO

-- 7. Tính thêm số tiền thanh toán trên mỗi hóa đơn
SELECT	OD.*, 
		(OD.UnitPrice * OD.Quantity*(1-OD.Discount)) AS 'Total Money'
FROM [Order Details] AS OD LEFT JOIN Products AS P ON OD.ProductID = P.ProductID 
GO
-- 8. Tính tổng doanh thu bán hàng:

--  a. Theo từng năm
SELECT	YEAR(O.OrderDate) AS 'Order Year', 
		SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)) AS 'Revenue'
FROM Orders AS O LEFT JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
GROUP BY YEAR(OrderDate)
ORDER BY YEAR(OrderDate) ASC;
GO
--  b. Theo từng quý năm 1997
SELECT	DATEPART(QUARTER,OrderDate) AS 'Quarter',
		SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)) AS 'Revenue'
FROM Orders AS O LEFT JOIN [Order Details] OD ON O.OrderID = OD.OrderID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY DATEPART(QUARTER,OrderDate)
ORDER BY DATEPART(QUARTER,OrderDate)
GO

-- 9. Đếm số hóa đơn bán được trong mỗi năm
SELECT	YEAR(O.OrderDate) AS 'Year',
		COUNT(O.OrderID) AS 'Count Order'
FROM Orders AS O
GROUP BY YEAR(O.OrderDate)
ORDER BY YEAR(O.OrderDate) ASC
GO

-- 10.Tính tổng doanh số bán hàng của mỗi nhân viên trong năm 1997.
SELECT	CONCAT(E.FirstName,'',E.LastName) AS 'Employee Name',
		SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)) AS 'Revenue'
FROM Orders AS O	LEFT JOIN Employees AS E ON O.EmployeeID = E.EmployeeID
					LEFT JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY CONCAT(E.FirstName,'',E.LastName)
GO
-- Tìm nhân viên có doanh số bán hàng cao nhất.
SELECT	TOP 1
		CONCAT(E.FirstName,'',E.LastName) AS 'Employee Name',
		SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)) AS 'Revenue'
FROM Orders AS O	LEFT JOIN Employees AS E ON O.EmployeeID = E.EmployeeID
					LEFT JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
WHERE YEAR(O.OrderDate) = 1997
GROUP BY CONCAT(E.FirstName,'',E.LastName)
ORDER BY SUM(OD.UnitPrice * OD.Quantity*(1-OD.Discount)) DESC
GO