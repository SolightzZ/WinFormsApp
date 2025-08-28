CREATE VIEW Current_Products AS
SELECT ProductID, ProductName, UnitPrice, UnitsInStock
FROM Products
WHERE Discontinued = 0;

----------------------------------------------------------------------------

SELECT * FROM Current_Products
WHERE UnitPrice >= 50




---------------------------- DataBase 1 ------------------------------------------------
SELECT  P.ProductID, ProductName, SUM(OD.UnitPrice * Quantity) As Sale_Volumes 
FROM  Suppliers As S  INNER JOIN Products As P ON S.SupplierID = P.SupplierID  
                        INNER JOIN [Order Details] As OD ON P.ProductID = OD.ProductID 
                        INNER JOIN Orders As O ON OD.OrderID = O.OrderID 
WHERE   Country = @supplierCountry AND YEAR(OrderDate) = @saleYear AND ShipCountry = @shipCountry Group By P.ProductID, ProductName
                    

----------------------------- DataBase 2 -----------------------------------
CREATE VIEW ProductByVolume AS
SELECT P.ProductID, ProductName, OD.UnitPrice, Quantity, OrderDate, Country, ShipCountry
FROM  Suppliers As S  INNER JOIN Products As P ON S.SupplierID = P.SupplierID  
                        INNER JOIN [Order Details] As OD ON P.ProductID = OD.ProductID 
                        INNER JOIN Orders As O ON OD.OrderID = O.OrderID 
SELECT ProductID, ProductName, SUM(UnitPrice * Quantity) As Sale_Volumes 

FROM ProductByVolume
WHERE Country = @supplierCountry  AND YEAR(OrderDate) =  @saleYear AND ShipCountry = @shipCountry
GROUP BY ProductID, ProductName

----------------------------------------------------------------------------

DROP VIEW ProductByVolume;

SELECT * FROM ProductByVolume
WHERE TotalSales >= 10000