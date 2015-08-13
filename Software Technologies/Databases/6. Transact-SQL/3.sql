USE Northwind
GO

CREATE FUNCTION fn_YearsIncrease(@sum DECIMAL, @yearRate DECIMAL, @months DECIMAL)
RETURNS DECIMAL
AS
BEGIN
	DECLARE @yearsIncrease decimal
	SET @yearsIncrease = (@sum * @months) * @yearRate
	RETURN @yearsIncrease
END

GO

SELECT dbo.fn_YearsIncrease(100, 2.05, 12) AS [Years Increase]
GO