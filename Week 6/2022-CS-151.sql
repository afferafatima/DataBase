
--Q1
SELECT c.CustomerID, o.OrderID, o.OrderDate
FROM (SELECT CustomerID
    FROM [Northwind].[dbo].[Customers]) c
	LEFT JOIN
	[Northwind].[dbo].[Orders] o ON c.CustomerID = o.CustomerID;
--Q2
SELECT 
    c.CustomerID, 
    o.OrderID, 
    o.OrderDate 
FROM 
    [Northwind].[dbo].[Customers] c
LEFT JOIN 
    (
        SELECT 
            CustomerID, 
            OrderID, 
            OrderDate 
        FROM 
            [Northwind].[dbo].[Orders]
    ) o ON c.CustomerID = o.CustomerID
WHERE 
    o.OrderID IS NULL;

--Q3
SELECT 
    c.CustomerID, 
    o.OrderID, 
    o.OrderDate 
FROM 
    [Northwind].[dbo].[Customers] c
JOIN 
    (
        SELECT CustomerID, OrderID, OrderDate 
        FROM  [Northwind].[dbo].[Orders]
        WHERE YEAR(OrderDate) = 1997 AND MONTH(OrderDate) = 7
    ) o ON c.CustomerID = o.CustomerID;
--Q4
SELECT 
    c.CustomerID,
     CASE 
        WHEN o.totalorders IS NULL THEN 0
        ELSE o.totalorders
    END AS totalorders
FROM 
    [Northwind].[dbo].Customers c
LEFT JOIN 
    (
        SELECT 
            CustomerID, 
            COUNT(OrderID) AS totalorders 
        FROM 
            [Northwind].[dbo].Orders 
        GROUP BY 
            CustomerID
    ) o ON c.CustomerID = o.CustomerID;
--Q5
SELECT 
    E.EmployeeID, 
    E.FirstName, 
    E.LastName
FROM 
    Northwind.dbo.Employees AS E
CROSS JOIN 
    (
        SELECT TOP 5 ProductID FROM Northwind.dbo.Products
    ) AS N
ORDER BY 
    E.EmployeeID ASC;

	--Q6
	SELECT *
FROM Northwind.dbo.Products
WHERE UnitPrice > (
    SELECT AVG(UnitPrice)
    FROM Northwind.dbo.Products
)
--Q7
SELECT MAX(UnitPrice) AS SecondHighestPrice
FROM Northwind.dbo.Products
WHERE UnitPrice < (
    SELECT MAX(UnitPrice)
    FROM Northwind.dbo.Products
)
--Q8
SELECT 
    E.EmployeeID,
    O.OrderDate AS Date
FROM 
    Northwind.dbo.Employees AS E
CROSS JOIN 
    (
        SELECT OrderDate
        FROM Northwind.dbo.Orders
        WHERE OrderDate <= '1997-08-04 00:00:00.000' AND OrderDate >= '1996-07-04 00:00:00.000'
    ) AS O
ORDER BY 
    E.EmployeeID, 
    O.OrderDate;
--Q9
SELECT 
    c.CustomerID,
    (
        SELECT COUNT(o.OrderID) 
        FROM Northwind.dbo.Orders o 
        WHERE o.CustomerID = c.CustomerID
    ) AS TotalOrders,
    (
        SELECT SUM(od.Quantity) 
        FROM Northwind.dbo.Orders o 
        JOIN Northwind.dbo.[Order Details] od ON o.OrderID = od.OrderID 
        WHERE o.CustomerID = c.CustomerID
    ) AS TotalQuantity
FROM 
   Northwind.dbo.Customers c
WHERE 
    c.Country = 'USA';
--Q10
SELECT 
    c.CustomerID,
    c.CompanyName,
    o.OrderID,
    o.OrderDate
FROM 
   Northwind.dbo.Customers c
LEFT JOIN 
    (
        SELECT CustomerID, OrderID, OrderDate
        FROM Northwind.dbo.Orders
        WHERE CONVERT(date, OrderDate) = '1997-07-04'
    ) AS o ON c.CustomerID = o.CustomerID;

	--Q11-Q12
	SELECT 
    EmployeeName,
    EmployeeAge,
    ManagerAge
FROM (
    SELECT 
        e.FirstName + ' ' + e.LastName AS EmployeeName,
        DATEDIFF(hour, e.BirthDate, GETDATE()) / 8766 AS EmployeeAge,
        (
            SELECT DATEDIFF(hour, e1.BirthDate, GETDATE()) / 8766
            FROM Northwind.dbo.Employees AS e1
            WHERE e.ReportsTo = e1.EmployeeID
        ) AS ManagerAge
    FROM 
       Northwind.dbo.Employees AS e
) AS Subquery
WHERE 
    EmployeeAge > 60 
    AND ManagerAge >= 70
    AND EmployeeAge < ManagerAge;


--Q13
SELECT 
    p.ProductName,
    o.OrderDate
FROM 
    Northwind.dbo.Products p
JOIN 
    (
        SELECT OrderID, ProductID
        FROM Northwind.dbo.[Order Details]
        WHERE OrderID IN (
            SELECT OrderID
            FROM Northwind.dbo.Orders
            WHERE CONVERT(date, OrderDate) = '1997-08-08'
        )
    ) od ON p.ProductID = od.ProductID
JOIN 
   Northwind.dbo.Orders o ON od.OrderID = o.OrderID;
   --Q14
   SELECT 
    ShipAddress AS Address,
    ShipCity AS City,
    ShipCountry AS Country
FROM 
   Northwind.dbo.Orders
WHERE 
    EmployeeID = (
        SELECT EmployeeID 
        FROM Northwind.dbo.Employees 
        WHERE FirstName = 'Anne'
    )
    AND ShippedDate > RequiredDate;
	
--Q15
SELECT DISTINCT
    Country
FROM 
    Northwind.dbo.Customers
WHERE 
    CustomerID IN (
        SELECT DISTINCT
            o.CustomerID
        FROM 
           Northwind.dbo.Orders o
        JOIN 
            Northwind.dbo.[Order Details] od ON o.OrderID = od.OrderID
        JOIN 
            Northwind.dbo.Products p ON od.ProductID = p.ProductID
        WHERE 
            p.CategoryID = 1
    );
