CREATE DATABASE [Registry];

USE [Registry];

CREATE TABLE Users(
	UserId VARCHAR(255) NOT NULL UNIQUE,
	[Name] VARCHAR(255) NOT NULL,
	Email VARCHAR(255) NOT NULL,
	[Password] VARCHAR(255) NOT NULL
);

INSERT INTO Users(UserId, [Name], Email, [Password]) VALUES ('1', 'Arthur', 'admin@email.com', 'admin123');

SELECT UserId, [Name], Email, Password FROM Users 
WHERE UserId = UserId