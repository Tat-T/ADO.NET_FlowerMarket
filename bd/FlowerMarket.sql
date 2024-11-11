CREATE DATABASE FlowerMarket
GO
USE FlowerMarket
GO

CREATE TABLE Flower
(
    ID INT PRIMARY KEY,
    Title VARCHAR(255),
    Price DECIMAL(10, 2),
    [Availability] INT   --Availability �������
);

INSERT INTO Flower (ID, Title, Price,[Availability] ) VALUES
(1, '����', 25.99, 100),
(2, '��������', 15.50, 50),
(3, '�������', 35.75, 75);

SELECT * FROM Flower

CREATE TABLE Clients
(
    ID INT PRIMARY KEY,
    [Name] VARCHAR(255),
    Phone VARCHAR(20),
    [Address] VARCHAR(255)
);

INSERT INTO Clients(ID, [Name], Phone,[Address] ) VALUES
(1, '����', '+79183586812', '��.���������,1'),
(2, '����', '+79521265789', '��.�������,5');

SELECT * FROM Clients