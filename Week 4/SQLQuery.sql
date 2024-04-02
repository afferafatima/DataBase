
-- Q1
SELECT ProductName 
FROM [Northwind].[dbo].[Products] 
WHERE UnitPrice > (SELECT AVG(UnitPrice) FROM [Northwind].[dbo].[Products]);
-- Q2
SELECT 
    ShippedDate,
    COUNT(OrderID) AS NumberOfOrders
FROM 
    Orders
WHERE 
    ShippedDate IS NOT NULL -- Exclude orders that haven't been shipped
GROUP BY 
    ShippedDate
ORDER BY 
    ShippedDate;


-- Q3
SELECT Country
FROM [Northwind].[dbo].[Suppliers]
GROUP BY Country
HAVING COUNT(*) >= 2;

-- Q4
SELECT 
    MONTH(ShippedDate) AS MonthNumber,
    COUNT(*) AS OrdersDelayed
FROM 
    [Northwind].[dbo].[Orders]
WHERE 
    ShippedDate > RequiredDate
GROUP BY 
    MONTH(ShippedDate)
ORDER BY 
    MonthNumber;

-- Q5
SELECT  
    [OrderID],
    [Discount]
FROM [Northwind].[dbo].[Order Details]
WHERE Discount > 0;

-- Q6
SELECT 
    ShipCity,
    COUNT(*) AS NumberOfOrders
FROM 
    Orders
WHERE 
    ShipCountry = 'USA' 
    AND YEAR(ShippedDate) = 1997
GROUP BY 
    ShipCity
ORDER BY 
    NumberOfOrders DESC;

-- Q7
SELECT 
    ShipCountry AS Country,
    COUNT(*) AS OrdersDelayed
FROM 
    [Northwind].[dbo].[Orders]
WHERE 
    ShippedDate > RequiredDate
GROUP BY 
    ShipCountry
ORDER BY 
    OrdersDelayed DESC;

-- Q8
SELECT 
    [OrderID],
    [Discount],
    [UnitPrice]*[Quantity] AS [Total Price]
FROM [Northwind].[dbo].[Order Details]
WHERE Discount > 0;

-- Q9
SELECT 
    ShipRegion,
    ShipCity,
    COUNT(*) AS NumberOfOrders
FROM 
    [Northwind].[dbo].[Orders]
WHERE 
    YEAR(ShippedDate) = 1997
GROUP BY 
    ShipRegion, ShipCity
ORDER BY 
    ShipRegion, NumberOfOrders DESC;

