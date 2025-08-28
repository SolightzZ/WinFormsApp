

CREATE PROCEDURE CountProductsByCategory AS 
BEGIN 
    Select C.CategoryID, C.CategoryName, COUNT(P.ProductID) AS ProductCount
    FROM Products AS P INNER JOIN Categories AS C ON P.CategoryID = C.CategoryID
    GROUP BY C.CategoryID, C.CategoryName
END

EXEC CountProductsByCategory


CREATE PROCEDURE WorkShop8 
    @Categories int,
    @Year VARCHAR(10) AS 
BEGIN
SELECT CU.CustomerID, CompanyName, SUM(OD.UnitPrice * Quantity) AS SaleVolumes
FROM Categories AS C INNER JOIN Products AS P ON C.CategoryID = P.CategoryID
                        INNER JOIN [Order Details] AS OD ON P.ProductID = OD.ProductID 
                        INNER JOIN Orders AS O ON OD.OrderID = O.OrderID 
                        INNER JOIN Customers AS CU ON O.CustomerID = CU.CustomerID 
WHERE C.CategoryID = @Categories AND YEAR(O.OrderDate) = @Year
GROUP BY CU.CustomerID, CU.CompanyName
END

EXEC WorkShop8 1, '1997'

DROP PROCEDURE WorkShop8