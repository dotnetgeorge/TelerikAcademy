USE Northwind
GO

CREATE PROC dbo.ups_TotalIncomes(@SupplierName nvarchar(40), @StartDate DATETIME, @EndDate DATETIME)
AS
	SET NOCOUNT ON;
	SELECT (od.UnitPrice) AS [Total Incomes]
	FROM Suppliers s
	JOIN Products p
	ON s.SupplierID = p.SupplierID
	JOIN [Order Details] od
	ON od.ProductID = p.ProductID
	JOIN Orders o
	ON o.OrderID = od.OrderID
	WHERE s.CompanyName = @SupplierName AND o.OrderDate BETWEEN @StartDate AND @EndDate
RETURN
GO

DECLARE @SupplierName nvarchar(40)
SET @SupplierName = 'Pavlova, Ltd.'
DECLARE @StartDate DATETIME
SET @StartDate = CAST('01-01-1996' AS DATETIME)
DECLARE @EndDate DATETIME
SET @EndDate = CAST('01-01-1999' AS DATETIME)
DECLARE @Result MONEY
EXEC dbo.ups_TotalIncomes @SupplierName, @startDate, @endDate
GO 