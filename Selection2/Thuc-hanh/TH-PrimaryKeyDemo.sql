CREATE DATABASE PrimaryKeyDemo
GO

USE PrimaryKeyDemo
GO

CREATE TABLE Users1(
	UserId INT IDENTITY(1,1) PRIMARY KEY,
	Username VARCHAR(20) NOT NULL,
	Password VARCHAR(20) NOT NULL,
	Email VARCHAR(50) NOT NULL,
);

CREATE TABLE Users2(
	UserId INT IDENTITY(1,1),
	Username VARCHAR(20) NOT NULL,
	Password VARCHAR(20) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	PRIMARY KEY (UserId, UserName)
);