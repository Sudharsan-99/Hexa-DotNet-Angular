
Use AutoMobileData

create database AutoMobileData;

CREATE TABLE Categories(
Category_Id		INT				PRIMARY KEY,
Category_Name	NVARCHAR(50)	NOT NULL
)

CREATE TABLE Brands(
Brand_Id	INT					PRIMARY KEY,
Brand_Name	NVARCHAR(50)		NOT NULL
)

CREATE TABLE Products(
Product_Id		INT				IDENTITY(100,1) PRIMARY KEY,
Product_Name	NVARCHAR(50)	NOT NULL,
Category_Id		INT				NOT NULL,
Brand_Id		INT				NOT NULL,
List_Price		NUMERIC(18,2)	NOT NULL,
FOREIGN KEY(Category_Id) REFERENCES Categories(Category_Id) ON DELETE CASCADE,
FOREIGN KEY(Brand_Id) REFERENCES Brands(Brand_Id) ON DELETE CASCADE
)

CREATE TABLE Customers(
Customer_Id		INT				IDENTITY(1,1) PRIMARY KEY,
First_Name		NVARCHAR(50)	NOT NULL,
Last_Name		NVARCHAR(50)	NOT NULL,
Name			AS(First_Name+' '+Last_Name),
Email			NVARCHAR(100)	UNIQUE,
Pin_Code		INT				CHECK(Pin_Code>0) NOT NULL
)

CREATE TABLE Order_Details(
Order_Id		INT			PRIMARY KEY,
Order_Date		DATETIME	NOT NULL,
Delivery_Date	DATETIME	NOT NULL,
Customer_Id		INT			NOT NULL,
FOREIGN KEY(Customer_Id) REFERENCES Customers(Customer_Id) ON DELETE CASCADE
)

CREATE TABLE Order_Item_Info(
Order_Id		INT				NOT NULL,
Product_Id		INT				NOT NULL,
Price			NUMERIC(10,2)	NOT NULL,
Qty				INT				NOT NULL,
Total			AS(Price*Qty),
FOREIGN KEY(Order_Id) REFERENCES Order_Details(Order_Id) ON DELETE CASCADE,
FOREIGN KEY(Product_Id) REFERENCES Products(Product_Id) ON DELETE CASCADE
)


-- Insert Categories
INSERT INTO Categories (Category_Id, Category_Name) VALUES
(1, 'Electronics'),
(2, 'Apparel');

-- Insert Brands
INSERT INTO Brands (Brand_Id, Brand_Name) VALUES
(1, 'Sony'),
(2, 'Nike');

-- Insert Products
INSERT INTO Products (Product_Name, Category_Id, Brand_Id, List_Price) VALUES
('Headphones', 1, 1, 599.99),
('Smartwatch', 1, 1, 299.99),
('Running Shoes', 2, 2, 149.99),
('Jacket', 2, 2, 89.99),
('Bluetooth Speaker', 1, 1, 129.50);

-- Insert Customers (One Piece characters)
INSERT INTO Customers (First_Name, Last_Name, Email, Pin_Code) VALUES
('Monkey', 'D luffy', 'luffy@gmail.com', 123456),
('Roronoa', 'Zoro', 'zoro@gmail.com', 234567),
('Nami', 'Swan', 'nami@gmail.com', 345678),
('Usopp', 'Sniper', 'usopp@gmail.com', 456789),
('Sanji', 'Cook', 'sanji@gmail.com', 567890);

-- Insert Order_Details
INSERT INTO Order_Details (Order_Id, Order_Date, Delivery_Date, Customer_Id) VALUES
(1, '2025-06-01', '2025-06-03', 1),
(2, '2025-06-02', '2025-06-04', 2),
(3, '2025-06-03', '2025-06-05', 3),
(4, '2025-06-04', '2025-06-06', 4),
(5, '2025-06-05', '2025-06-07', 5);

-- Insert Order_Item_Info
INSERT INTO Order_Item_Info (Order_Id, Product_Id, Price, Qty) VALUES
(1, 100, 199.99, 1),
(2, 101, 299.99, 2),
(3, 102, 149.99, 1),
(4, 103, 89.99, 3),
(5, 104, 129.50, 1);


--1. display customer list by the first name in descending order. 
SELECT * 
FROM Customers 
ORDER BY First_Name DESC;

--2.display the first name, last name, and city of the customers. 
--It sorts the customer list by the city first and then by the first name. 
SELECT First_Name, Last_Name, City
FROM Customers
ORDER BY City ASC, First_Name ASC;

--3.returns the top three most expensive products. 
SELECT TOP 3 * 
FROM Products 
ORDER BY List_Price DESC;

--4..finds the products whose list price is greater than 300 and model year is 2018. 
SELECT * 
FROM Products 
WHERE List_Price > 300 AND Model_Year = 2018;

--5.finds products whose list price is greater than 3,000 or model year is 2018. 
--Any product that meets one of these conditions is included in the result set. 
SELECT * 
FROM Products 
WHERE List_Price > 3000 OR Model_Year = 2018;

--6.find the products whose list prices are between 1,899 and 1,999.99.                      
SELECT * 
FROM Products 
WHERE List_Price BETWEEN 1899 AND 1999.99;

-- 7. Find products with list price 299.99, 466.99, or 489.99 using IN
SELECT * 
FROM Products 
WHERE List_Price IN (299.99, 466.99, 489.99);

-- 8. Find customers where the first character of last name is between A and C
SELECT * 
FROM Customers 
WHERE LEFT(Last_Name, 1) BETWEEN 'A' AND 'C';

-- 9. Find customers where the first character of first name is not A using NOT LIKE
SELECT * 
FROM Customers 
WHERE First_Name NOT LIKE 'A%';

-- 10. Return number of customers by state and city
-- Assuming 'State' and 'City' columns exist in Customers table
SELECT State, City, COUNT(*) AS Customer_Count
FROM Customers
GROUP BY State, City;

-- 11. Return number of orders placed by customer grouped by customer ID and year
SELECT 
  Customer_Id,
  YEAR(Order_Date) AS Order_Year,
  COUNT(*) AS Order_Count
FROM Order_Details
GROUP BY Customer_Id, YEAR(Order_Date);

-- 12. Find max and min list price grouped by Category_Id, filter by condition
SELECT 
  Category_Id,
  MAX(List_Price) AS Max_Price,
  MIN(List_Price) AS Min_Price
FROM Products
GROUP BY Category_Id
HAVING MAX(List_Price) > 4000 OR MIN(List_Price) < 500;


