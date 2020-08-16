CREATE DATABASE BTStore
GO

USE BTStore
GO

CREATE TABLE customersNumber (
customerNumber INT NOT NULL PRIMARY KEY,
customerName NVARCHAR(50) NOT NULL,
contactLastName NVARCHAR(50) NOT NULL,
contactFirstName NVARCHAR(50) NOT NULL,
phone NVARCHAR(50) NOT NULL,
addressLine1 NVARCHAR(50) NOT NULL,
addressLine2 NVARCHAR(50) DEFAULT NULL,
city NVARCHAR(50) NOT NULL,
state NVARCHAR(50) NOT NULL,
postalCode NVARCHAR(15) NOT NULL,
country NVARCHAR(50) NOT NULL,
creditLimit FLOAT,
--salesRepEmployeeNumber INT FOREIGN KEY REFERENCES Employees(employeeNumber),
--officeCode VARCHAR(10) FOREIGN KEY REFERENCES Offices(officeCode)
)
GO

ALTER TABLE customersNumber
ADD alesRepEmployeeNumber INT
	FOREIGN KEY (alesRepEmployeeNumber) REFERENCES Employees(employeeNumber),
	officeCode VARCHAR(10) FOREIGN KEY REFERENCES Offices(officeCode)
GO

CREATE TABLE Orders (
orderNumber INT NOT NULL PRIMARY KEY,
orderDate DATE NOT NULL,
requiredDate DATE NOT NULL,
shippedDate DATE,
status NVARCHAR(15) NOT NULL,
comments TEXT,
quantityOrdered INT NOT NULL,
priceEach FLOAT NOT NULL
--customerNumber INT FOREIGN KEY REFERENCES customersNumber(customerNumber)
)
GO

ALTER TABLE Orders
ADD customerNumber INT FOREIGN KEY REFERENCES customersNumber(customerNumber);
GO

CREATE TABLE Payments (
customerNumber INT NOT NULL,
checkNumber VARCHAR(50) NOT NULL,
paymentDate DATE NOT NULL,
amount FLOAT NOT NULL,
--FOREIGN KEY (customerNumber) REFERENCES customersNumber(customerNumber)
)
GO

ALTER TABLE Payments
ADD FOREIGN KEY (customerNumber) REFERENCES customersNumber(customerNumber);
GO

CREATE TABLE Products (
productCode VARCHAR(15) NOT NULL PRIMARY KEY,
productName NVARCHAR(70) NOT NULL,
productScale NVARCHAR(70) NOT NULL,
productVendor NVARCHAR(10) NOT NULL,
productDescription TEXT NOT NULL,
quantityInStock INT NOT NULL,
checkNumber VARCHAR(50) NOT NULL,
paymentDate DATE NOT NULL,
buyPrice FLOAT NOT NULL,
MSRP FLOAT NOT NULL,
--productLine VARCHAR(50) FOREIGN KEY REFERENCES Productlines(productLine)
)
GO

ALTER TABLE Products
ADD productLine VARCHAR(50) FOREIGN KEY REFERENCES Productlines(productLine);
GO

CREATE TABLE Productlines (
productLine VARCHAR(50) NOT NULL PRIMARY KEY,
textDescription TEXT,
image VARCHAR(50)
)
GO

CREATE TABLE Employees (
employeeNumber INT NOT NULL PRIMARY KEY,
lastName NVARCHAR(50) NOT NULL,
firstName NVARCHAR(50) NOT NULL,
email NVARCHAR(100) NOT NULL,
jobTitle NVARCHAR(50) NOT NULL,
--salesRepEmployeeNumber INT FOREIGN KEY REFERENCES customersNumber(salesRepEmployeeNumber)
--reportTo VARCHAR(10) FOREIGN KEY REFERENCES Offices(officeCode)
)
GO

ALTER TABLE Employees
ADD reportTo VARCHAR(10) FOREIGN KEY REFERENCES Offices(officeCode)
GO

ALTER TABLE Employees
ADD productLine VARCHAR(50) FOREIGN KEY REFERENCES Productlines(productLine);
GO

CREATE TABLE Offices (
officeCode VARCHAR(10) NOT NULL PRIMARY KEY,
city NVARCHAR(50) NOT NULL,
phone NVARCHAR(50) NOT NULL,
addressLine1 NVARCHAR(50) NOT NULL,
addressLine2 NVARCHAR(50),
state NVARCHAR(50),
country NVARCHAR(50) NOT NULL,
postalCode VARCHAR(15) NOT NULL
)
GO

CREATE TABLE OrderDetails (
productCode VARCHAR(15) FOREIGN KEY REFERENCES Products(productCode),
orderNumber INT FOREIGN KEY REFERENCES Orders(orderNumber)
)
GO 

