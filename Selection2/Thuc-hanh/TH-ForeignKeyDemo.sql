CREATE DATABASE ForeignKeyDemo;
GO

USE ForeignKeyDemo;
GO

CREATE TABLE customers(
   id INT IDENTITY(1,1) PRIMARY KEY,
   name VARCHAR(40),
   address VARCHAR(255),
   email VARCHAR(255)
);
GO

CREATE TABLE orders1(
   id INT IDENTITY(1,1),
   staff VARCHAR(50),
   PRIMARY KEY(id),
   customer_id INT FOREIGN KEY REFERENCES customers(id)
);
GO

CREATE TABLE orders2(
   id INT IDENTITY(1,1) PRIMARY KEY,
   staff VARCHAR(50),
   customer_id INT,
   FOREIGN KEY (customer_id) REFERENCES customers(id)
);