CREATE TABLE Persons (
    Personid int IDENTITY(1,1) PRIMARY KEY,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int
);
CREATE TABLE Suppliers
( SupplierId INT IDENTITY NOT NULL PRIMARY KEY,
  SupplierName VARCHAR(50) NOT NULL,
  AccountRep VARCHAR(30) NOT NULL DEFAULT 'TBD',
);
GO
DROP TABLE Persons;
ALTER TABLE Persons ADD ContactNo VARCHAR(20);
ALTER TABLE Persons 
	ADD Bday VARCHAR(20), 
		Address VARCHAR(200);
ALTER TABLE Persons 
	DROP COLUMN Address;
EXEC sp_rename 'Persons.LastName', 'Name', 'COLUMN';
EXEC sp_rename 'Persons', 'Students';
SELECT*FROM Persons