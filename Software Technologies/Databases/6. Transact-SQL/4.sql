USE Northwind
GO

CREATE PROC ups_CheckAccountsYearsRate
AS
	SELECT dbo.fn_YearsIncrease(Balance, CAST(ID AS DECIMAL), 1) AS [Increase Balance for One Month]
	FROM dbo.Accounts

GO

EXEC ups_CheckAccountsYearsRate
GO