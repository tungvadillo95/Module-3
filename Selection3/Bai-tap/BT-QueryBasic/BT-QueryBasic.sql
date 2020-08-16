-- 1. Thông tin khách hàng (customer). Có bao nhiêu khách hàng?
SELECT COUNT(CustomerID) AS 'Customer Quantity' 
FROM Customers
GO

-- 2. Thông tin loại hàng. Có bao nhiêu loại hàng (category), mỗi loại hàng có bao nhiêu sản phẩm (product)
SELECT  Products.CategoryID, COUNT(Products.ProductID) AS 'Quantity Product'
FROM Products INNER JOIN Categories ON Products.CategoryID= Categories.CategoryID
GROUP BY Products.CategoryID
GO

-- 3. Thông tin nhân viên. Có bao nhiêu nhân viên (Employee)? 
SELECT COUNT(EmployeeID) AS 'Employee Quantity' 
FROM Employees
GO
--    Nâng cao: bạn có thể truy vấn được tên người quản lý (là người được nhân viên báo cáo) không?
SELECT Employees.FirstName AS EmployeeName, Reports.FirstName AS Manager 
FROM Employees LEFT JOIN Employees AS Reports ON Employees.ReportsTo = Reports.EmployeeID
GO

-- 4. Thông tin các nhà cung cấp (supplier). Có bao nhiêu nhà cung cấp.
SELECT COUNT(SupplierID) AS 'Supplier Quantity' 
FROM Suppliers
GO

-- 5. Đơn hàng (order) được lưu trữ gồm những năm nào?
SELECT YEAR(OrderDate) AS 'Order Year', COUNT(Orders.OrderDate) AS 'Quantity'
FROM Orders
GROUP BY YEAR(OrderDate)
ORDER BY COUNT(Orders.OrderDate) DESC;
GO

-- 6. Khách hàng thường sống ở những quốc gia nào? 
SELECT * FROM Customers
SELECT Country AS 'Customer Country', COUNT(Customers.Country) AS 'Quantity'
FROM Customers
GROUP BY Country
ORDER BY COUNT(Customers.Country) DESC;
GO
-- Những quốc gia nào có nhà cung cấp?
SELECT Country FROM Suppliers
GROUP BY Country
GO

-- 7. Liệt kê các khách hàng không có số Fax?
SELECT * FROM Customers
WHERE Fax IS NULL
GO

-- 8. Liệt kê các khách hàng sống ở Pháp. 
SELECT * FROM Customers
WHERE Country = 'France'
GO
-- Liệt kê các khách hang sống ở Pháp và Tây Ban Nha
SELECT * FROM Customers
WHERE Country = 'France' OR Country = 'Spain'
GO

-- 9. Liệt kê các khách hàng không sống ở Châu Mỹ
SELECT CustomerID, CompanyName, ContactName, Country
FROM Customers
WHERE Region IS NULL
GO

--10. Liệt kê các hóa đơn của năm 1997
SELECT OD.* 
FROM Orders LEFT JOIN [Order Details] OD ON Orders.OrderID = OD.OrderID
WHERE YEAR(Orders.OrderDate) = 1997
GO

-- 11. Liệt kê 3 hóa đơn mới nhất
SELECT TOP 3 OD.*
FROM Orders INNER JOIN [Order Details] OD ON Orders.OrderID = OD.OrderID
ORDER BY OrderDate DESC;
GO

-- 12. Liệt kê các hóa đơn có cước phí >100$. 
SELECT * FROM Orders
WHERE Freight > 100
GO
-- Tìm hóa đơn có cước phí cao nhất, thấp nhất.
SELECT TOP 1 * FROM Orders
ORDER BY Freight DESC
GO

SELECT TOP 1 * FROM Orders
ORDER BY Freight ASC
GO

-- 13. Đếm số hóa đơn bán được của năm 1996, 1997 và cả 2 năm 1996, 1997
SELECT YEAR(OrderDate) AS 'Order Year', COUNT(Orders.OrderDate) AS 'Quantity'
FROM Orders
WHERE YEAR(OrderDate) = 1996 OR YEAR(OrderDate) = 1997
GROUP BY YEAR(OrderDate)
ORDER BY COUNT(Orders.OrderDate) DESC;
GO

-- 14. Tính đơn giá bình quân của tất cả sản phẩm, của sản phẩm thuộc loại hải sản (mã loại là 8)
SELECT * FROM Products
WHERE CategoryID = 8
GO

SELECT AVG(UnitPrice) AS 'AVG Uint Price'
FROM Products
WHERE CategoryID = 8
GO

-- 15. Liệt kê 3 sản phẩm có đơn giá mắc nhất.
SELECT TOP 3 * FROM Products
ORDER BY UnitPrice DESC
GO

-- 16. Liệt kê các sản phẩm có tên bắt đầu bằng ký tự N? Bắt đầu bằng ký tự N hoặc A? 
SELECT * FROM Products
WHERE ProductName LIKE 'N%' OR ProductName LIKE 'A%'
GO
-- Liệt kê các sản phẩm có tên không bắt đầu bằng N? Không bắt đầu bằng N và A?
SELECT * FROM Products
WHERE ProductName NOT LIKE 'N%'
GO

SELECT * FROM Products
WHERE ProductName NOT LIKE 'N%' AND ProductName NOT LIKE 'A%'
GO

-- 17. Liệt kê các sản phẩm có đơn giá từ 100 đến 200
SELECT * FROM Products
WHERE UnitPrice BETWEEN 100 AND 200;
GO

-- 18. Liệt kê các sản phẩm có số lượng tồn kho (units in stock) thấp hơn định mức tồn kho tối thiểu (reorder level)
SELECT * FROM Products
WHERE UnitsInStock < ReorderLevel;
GO

-- 19. Tính số sản phẩm được cung cấp bởi nhà cung cấp Tokyo Traders (có mã là 4)
SELECT Suppliers.CompanyName, COUNT(Products.SupplierID) AS 'Count'
FROM Products INNER JOIN Suppliers ON Products.SupplierID= Suppliers.SupplierID
WHERE Products.SupplierID = 4
GROUP BY Suppliers.CompanyName
GO