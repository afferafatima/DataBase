--QUESTION 1
SELECT c.CustomerID, o.OrderID, o.OrderDate
FROM Customers c
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID;

--QUESTION 2
SELECT c.CustomerID, o.OrderID, o.OrderDate
FROM Customers c
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderID IS NULL;

--QUESTION 3
SELECT c.CustomerID, o.OrderID, o.OrderDate
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE YEAR(o.OrderDate) = 1997 AND MONTH(o.OrderDate) = 7;

--QUESTION 4
SELECT CustomerID, COUNT(OrderID) AS totalorders
FROM Orders
GROUP BY CustomerID;

--QUESTION 5
--NO SOLUTION

--QUESTION 6
SELECT E.EmployeeID, o.OrderDate AS Date
FROM Employees E
JOIN Orders o ON E.EmployeeID = o.EmployeeID
WHERE o.OrderDate > '1996-07-04' AND o.OrderDate < '1997-08-04';

--QUESTION 7
SELECT c.CustomerID,COUNT(DISTINCT o.OrderID) AS TotalOrders,SUM(od.Quantity) AS TotalQuantity
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
WHERE c.Country = 'USA'
GROUP BY c.CustomerID;
--QUESTION 8
SELECT c.CustomerID,c.CompanyName,o.OrderID,o.OrderDate
FROM Customers c
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID AND  o.OrderDate = '1997-07-04';
--QUESTION 10
--YES
--QUESTION 10

SELECT 
    e.FirstName + ' ' + e.LastName AS EmployeeName,
    e.Birthdate AS Age,
     m.Birthdate AS ManagerAge
FROM 
    Employees e
JOIN 
    Employees m ON e.ReportsTo = m.EmployeeID
WHERE 
    e.Birthdate < m.Birthdate;
--QUESTION 11
SELECT 
    p.ProductName,
    o.OrderDate
FROM 
    Products p
JOIN 
    [Order Details] od ON p.ProductID = od.ProductID
JOIN 
    Orders o ON od.OrderID = o.OrderID
WHERE 
     o.OrderDate = '1997-08-08';
--QUESTION 12
SELECT 
    o.ShipAddress AS Address,
    o.ShipCity AS City,
    o.ShipCountry AS Country
FROM 
    Orders o
JOIN 
    Employees e ON o.EmployeeID = e.EmployeeID
WHERE 
    e.FirstName = 'Anne'
    AND o.ShippedDate > o.RequiredDate;

--QUESTION 13
SELECT DISTINCT
    c.Country
FROM 
    Orders o
JOIN 
    Customers c ON o.CustomerID = c.CustomerID
JOIN 
    [Order Details] od ON o.OrderID = od.OrderID
JOIN 
    Products p ON od.ProductID = p.ProductID
WHERE 
    p.CategoryID = 1; -- Assuming CategoryID 1 represents beverages


