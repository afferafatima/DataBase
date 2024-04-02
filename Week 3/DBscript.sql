--Question 1
SELECT
    OrderID,
    CustomerID,
    EmployeeID,
    DATEDIFF(day, RequiredDate, ShippedDate) AS DaysDelayed
FROM
    [Northwind].[dbo].[Orders]
WHERE
    ShippedDate > RequiredDate;
	
--Question 2

	SELECT DISTINCT
    Country
FROM
    [Northwind].[dbo].[Employees];
	
--Question 3

	SELECT
    EmployeeID,
    LastName,
    FirstName,
    Title,
    ReportsTo
FROM
    [Northwind].[dbo].[Employees]
WHERE
    ReportsTo IS NULL;

--Question 4

	SELECT
    ProductID,
    ProductName
FROM
    [Northwind].[dbo].[Products]
WHERE
    Discontinued = 1;

--Question 5

	SELECT DISTINCT
    OrderID
FROM
    [Northwind].[dbo].[Order Details]
WHERE
    Discount = 0 OR Discount IS NULL;

--Question 6

	SELECT
    CustomerID,
    ContactName,
    CompanyName
FROM
    [Northwind].[dbo].[Customers]
WHERE
    Region IS NULL OR Region = '';

--Question 7

	SELECT
    CustomerID,
    ContactName,
    Phone
FROM
    [Northwind].[dbo].[Customers]
WHERE
    Country IN ('UK', 'USA');

--Question 8

	SELECT
    SupplierID,
    CompanyName,
    HomePage
FROM
    [Northwind].[dbo].[Suppliers]
WHERE
    HomePage IS NOT NULL;

--Question 9

	SELECT DISTINCT
    Country
FROM
    [Northwind].[dbo].[Customers]
WHERE
    CustomerID IN (
        SELECT DISTINCT
            CustomerID
        FROM
            [Northwind].[dbo].[Orders]
        WHERE
            YEAR(OrderDate) = 1997
    );

--Question 10

	SELECT DISTINCT
    CustomerID
FROM
    [Northwind].[dbo].[Customers]
WHERE
    CustomerID NOT IN (
        SELECT DISTINCT
            CustomerID
        FROM
            [Northwind].[dbo].[Orders]
        WHERE
            ShippedDate IS NOT NULL
    );

--Question 11

	SELECT
    SupplierID,
    CompanyName,
    City
FROM
    [Northwind].[dbo].[Suppliers];


--Question 12

	SELECT
    SupplierID,
    CompanyName,
    City
FROM
    [Northwind].[dbo].[Suppliers];


--Question 13

	SELECT
    ProductName
FROM
    [Northwind].[dbo].[Products]
WHERE
    Discontinued = 0;


--Question 14

	SELECT
    OrderID
FROM
    [Northwind].[dbo].[Order Details]
WHERE
    Discount <= 0.1;


--Question 15

	SELECT
    EmployeeID,
    FirstName + ' ' + LastName AS EmployeeName,
    Phone + ' ext. ' + COALESCE(Extension, '') AS ContactNumberWithExtension
FROM
    [Northwind].[dbo].[Employees]
WHERE
    Region IS NULL OR Region = '';

