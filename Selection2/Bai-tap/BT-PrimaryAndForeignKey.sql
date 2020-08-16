CREATE DATABASE PrimaryAndForeignKey;
GO

USE PrimaryAndForeignKey;
GO

CREATE TABLE Customers (
customer_number INT UNIQUE NOT NULL,
fullname NVARCHAR(50),
address NVARCHAR(100),
email VARCHAR(50),
phone VARCHAR(20)
PRIMARY KEY (customer_number)
)
GO

CREATE TABLE Accounts  (
account_number  INT UNIQUE NOT NULL,
account_type INT DEFAULT 0,
date  DATE,
balance FLOAT
PRIMARY KEY (account_number)
)
GO

ALTER TABLE Accounts
ADD 
	customer_number INT,
	FOREIGN KEY (customer_number) REFERENCES Customers(customer_number);
GO


CREATE TABLE Transactions   (
tran_number INT IDENTITY,
account_number INT,
date  DATE,
amounts  FLOAT,
descriptions NVARCHAR(100)
PRIMARY KEY (tran_number)
FOREIGN KEY (account_number) REFERENCES Accounts(account_number)
)
GO