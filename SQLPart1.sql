create database CompanyDB

use CompanyDB
--1 Create table Employees
create table Employees(EmployeeID INT IDENTITY(1,1) PRIMARY KEY, FirstName VARCHAR(50), LastName VARCHAR(50), Department VARCHAR(50), Salary DECIMAL(10,2))

--2 Inserted values
INSERT INTO Employees(FirstName, LastName, Department, Salary)VALUES('John','Doe','HR',50000)
INSERT INTO Employees(FirstName, LastName, Department, Salary)VALUES('Jane','Smith','IT',60000)
INSERT INTO Employees(FirstName, LastName, Department, Salary)VALUES('David','Lee','Marketing',55000)

--3
--Display table
SELECT * FROM Employees

---Display Those in IT Department and Salary > 5000
SELECT FirstName, LastName, Salary FROM Employees WHERE Department = 'IT' AND Salary > 50000;

---Find Maximum Salary
SELECT MAX(Salary) AS HighestSalary FROM Employees


--4
---Update salary of john doe as 55000
UPDATE Employees
SET Salary = 55000
WHERE FirstName = 'John' AND LastName = 'Doe'


---Change department name of jane smith to marketing
UPDATE Employees
SET Department = 'Marketing'
WHERE FirstName = 'Jane' AND LastName = 'Smith'

---5
---Delete the record of David Lee
DELETE FROM Employees
WHERE FirstName = 'David' AND LastName = 'Lee'

----Delete all employees in Marketing
DELETE FROM Employees
WHERE Department = 'Marketing' 








---5
--CREATING PRODUCTS TABLE
CREATE TABLE Products(ProductID INT IDENTITY(1,1)PRIMARY KEY,ProductName VARCHAR(50), Category VARCHAR(50), Price DECIMAL(10,2), Stock Decimal(10,2))
--INSERTING VALUES
INSERT INTO Products(ProductName, Category, Price, Stock) VALUES('Laptop','Electronics',1000,50)
INSERT INTO Products(ProductName, Category, Price, Stock) VALUES('Mouse', 'Electronics',20,200)
INSERT INTO Products(ProductName, Category, Price, Stock) VALUES('Keyboard','Electronics',30,150)
INSERT INTO Products(ProductName, Category, Price, Stock) VALUES('Printer','Electronics',150,75)


--Display Table
SELECT * FROM Products


--Select products sorted by price in descending order
SELECT * FROM Products ORDER BY Price DESC


--Update the price of the mouse to 25
UPDATE Products
SET Price = 25
WHERE ProductName = 'Mouse'


--Delete the product with ProductID = 2
DELETE FROM Products
WHERE ProductID = 2

--Select products sorted by ProductName in Alphabetical order
SELECT * FROM Products ORDER BY ProductName ASC;



--7 Library Management
CREATING TABLE BOOKS
CREATE TABLE Books(BookID INT IDENTITY(1,1) PRIMARY KEY, Title VARCHAR(150), Author VARCHAR(150), PublishedYear INT, AvailableCopies INT)
SELECT * FROM Books
--INSERING VALUES
INSERT INTO Books(Title, Author, PublishedYear, AvailableCopies) VALUES 
('The Great Gatsby', 'F. Scott Fitzgerald', 1925, 3),
('1984', 'George Orwell', 1949, 2),
('To Kill a Mockingbird','Harper Lee',1960,5),
('Brave New World','Aldous Huxley',1932,4)

--Update the available copies of "1984" to 5
UPDATE Books
SET AvailableCopies = 5
WHERE Title = '1984'

--Delete the book with BookID 1 (The Greater Gatsby)
DELETE FROM Books
WHERE BookID = 1

--Write a query to select books published after 1950
SELECT * FROM Books WHERE PublishedYear > 1950



--8 Customer Management
--CREATING TABLE CUSTOMERS
CREATE TABLE Customers(CustomerID INT IDENTITY(201,1) PRIMARY KEY, CustomerName VARCHAR(100), EMail VARCHAR(150), PhoneNumber VARCHAR(15))

--INSERTING VALUES
INSERT INTO Customers(CustomerName, EMail, PhoneNumber) VALUES 
('Alice Johnson', 'alice@example.com', '555-1234'),
('Bob Smith', 'bob@example.com', '555-5678'),
('Charlie Brown','charlie@example.com','555-8765')

SELECT * FROM Customers

--Inserting a new customer details into the table
INSERT INTO Customers(CustomerName, EMail, PhoneNumber) VALUES ('David Wilson', 'david@example.com', '555-4321')

--Update phone number of Alice Jhonson to 555-9999
UPDATE Customers
SET PhoneNumber = '555-9999'
WHERE CustomerName = 'Alice Johnson'

-- Delete the customer with CustomerID 202
DELETE FROM Customers
WHERE CustomerID = 202






---9 Orders Management
-- Creating table Orders
CREATE TABLE Orders(OrderID INT IDENTITY(301,1) PRIMARY KEY, CustomerID INT, OrderDate DATE, TotalAmount DECIMAL(10,2))

--Inserting Values
INSERT INTO Orders(CustomerID, OrderDate, TotalAmount) VALUES 
(201,'2024-09-01',250),
(202,'2024-09-02',150),
(203,'2024-09-03',200)

SELECT * FROM Orders

---INSERT new order
INSERT INTO Orders(CustomerID, OrderDate, TotalAmount) VALUES (204,'2024-09-04',300)

--Update the TotalAmount for OrderID 301 to 275.00
UPDATE Orders
SET TotalAmount = 275
WHERE OrderID = 301

--Delete the order with OrderID 302
DELETE FROM Orders
WHERE OrderID = 302


--Orders greater than 200
SELECT * FROM Orders WHERE TotalAmount > 200


--Select Only OrderID and TotalAmount
SELECT OrderID,TotalAmount FROM Orders 


--10 PRIMARY KEY
--Creating table
CREATE TABLE Students(StudentID INT PRIMARY KEY, FirstName VARCHAR(100), LastName VARCHAR(100), EMail VARCHAR(100))

--Inserting Values
INSERT INTO Students(StudentID, FirstName, LastName, EMail) VALUES 
(1,'John','Doe','john.doe@example.com'),
(2, 'Jane','Smith','jane.smith@example.com'),
(3, 'Mike','Johnson','mike.johnson@example.com')

SELECT * FROM Students


--11 Foreign Key
-- Creating Table
CREATE TABLE Courses(CourseID INT PRIMARY KEY, CourseName VARCHAR(50), Credits INT)
--Inserting Values
INSERT INTO Courses(CourseID, CourseName, Credits) VALUES 
(101, 'DBMS', 3),
(102, 'Python', 2),
(103, 'Web Development',4)

SELECT * FROM Courses
--Creating table
CREATE TABLE Enrollments(EnrollmentID INT PRIMARY KEY, StudentID INT, CourseID INT, FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
FOREIGN KEY(CourseID) REFERENCES Courses(CourseID))
--Inserting values
INSERT INTO Enrollments(EnrollmentID, StudentID, CourseID) VALUES (1001, 1, 101),
(1002,1,102),
(1003,2,102),
(1004,2,101),
(1005,3,103),
(1006,1,103)

SELECT * FROM Enrollments


--12 Composite Key
--Creating table
CREATE TABLE OrderDetails(OrderID INT, ProductID INT, Quantity INT, PRIMARY KEY(OrderID, ProductID))
--Inserting values
INSERT INTO OrderDetails(OrderID, ProductID, Quantity) VALUES
(1,101,8),
(1,102,6),
(2,101,2),
(2,103,5),
(3,102,9),
(3,103,1)

SELECT * FROM OrderDetails


--13 Candidate Key and Alternate Key
--Creating table
CREATE TABLE Users(UserID INT PRIMARY KEY, EMail VARCHAR(100) UNIQUE, UserName VARCHAR(100) NOT NULL)
---Inserting values
INSERT INTO Users (UserID, EMail, UserName) 
VALUES 
(1, 'john.doe@example.com','johndoe'),
(2,'jane.smith@example.com','janesmith'),
(3,'mike.johnson@example.com','mikejohnson'),
(4,'alice.joseph@example.com','alicejoseph')

SELECT * FROM Users

--14
--CREATING PRODUCTS TABLE
CREATE TABLE Products2(ProductID INT IDENTITY(1,1) PRIMARY KEY,ProductName VARCHAR(50), Category VARCHAR(50), Price DECIMAL(10,2), Stock Decimal(10,2))
--INSERTING VALUES
INSERT INTO Products2(ProductName, Category, Price, Stock) VALUES('Laptop','Electronics',1000,50),
('Mouse', 'Electronics',20,200),
('Keyboard','Electronics',30,150),
('Printer','Electronics',150,75)

SELECT * FROM Products WHERE Price BETWEEN 30 AND 150
SELECT * FROM Products WHERE Price>30 AND Price<160

SELECT * FROM Products2

--15 Natural Key
---Creating Table
CREATE TABLE Employees2(SSN CHAR(11) PRIMARY KEY, FName VARCHAR(50) NOT NULL, LName VARCHAR(50) NOT NULL, Position VARCHAR(50) NOT NULL)
---Inserting values
INSERT INTO Employees2(SSN, FName, LName, Position) 
VALUES
('12345678','John','Doe','SDE'),
('63636464', 'Jane','Smith','Manager'),
('75734555', 'Mike', 'Johnson', 'Analyst'),
('64646667', 'Alice', 'Joseph', 'Designer')

SELECT * FROM Employees2

--16 Unique Key
CREATE TABLE Customers2(CustomerID INT PRIMARY KEY, Name VARCHAR(50), PhoneNumber VARCHAR(50) UNIQUE);

INSERT INTO Customers2(CustomerID, Name, PhoneNumber) 
VALUES
('12345678','John','838389494'),
('63636464', 'Jane','783475785'),
('75734555', 'Mike', '858855443'),
('64646667', 'Alice', '7858494')

SELECT * FROM Customers2


--17 VIEWS BASIC VIEW CREATION
-- Create a simple view named EmployeeView that displays the FirstName, LastName, and Department columns from the Employees table.
CREATE VIEW 
EmployeeView 
AS 
SELECT FirstName, Lastname, Department FROM Employees
-- Query the view to display the details
SELECT * FROM EmployeeView


--18 UPDATING DATA THROUGH VIEW
--- Create a view named EditableEmployeeView that shows EmployeeID, FirstName,LastName, and Salary.
CREATE VIEW EditableEmployeeView AS 
SELECT EmployeeID, FirstName, LastName, Salary FROM Employees
SELECT * FROM EditableEmployeeView
SELECT * FROM Employees
---- Update the salary of an employee using the view.
UPDATE EditableEmployeeView
SET Salary = 80000
WHERE EmployeeID = 1

--- Verify the update
SELECT * FROM EditableEmployeeView WHERE EmployeeID = 1

--19 VIEW WITH CALCULATED COLUMNS
----Create a view named EmployeeSalaryBonusView that displays each employee’s FirstName, LastName, Salary, and a calculated column Bonus (10% of the salary).
CREATE VIEW EmployeeSalaryBonusView AS 
SELECT FirstName, LastName, Salary, Salary * 0.10 AS Bonus FROM Employees

--Query the view
SELECT * FROM EmployeeSalaryBonusView

--20 ALTERING A VIEW
----Alter the EmployeeView from Assignment 1 to include a new column Salary.
ALTER VIEW EmployeeView AS
SELECT FirstName, LastName, Department, Salary FROM Employees

---Verify the view with the updated column.
SELECT * FROM EmployeeView

--21 VIEW WITH PARAMETERS(SIMULATED VIA A FILTERS)
---Create a view named FilteredEmployeeView from employees table that displays EmployeeID,FirstName,LastName & Department.
CREATE VIEW FilteredEmployeeView AS
SELECT EmployeeID, FirstName, LastName, Department FROM Employees 

---Use a query on the view to return employees in a specific department (e.g.,DepartmentID = 2).
SELECT * FROM FilteredEmployeeView WHERE Department = 'HR'

--22 DROPPING A VIEW
-- Drop the EmployeeView that was created in the previous assignments.
DROP VIEW EmployeeView
--Try to query the view again.
SELECT * FROM EmployeeView

