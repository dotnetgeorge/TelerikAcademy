USE Northwind
GO

CREATE PROCEDURE ups_PersonsWithMoreMoney(@money money = 0)
AS
	SELECT p.FirstName + ' ' + p.LastName AS [Full Name], a.Balance
	FROM Persons p
	JOIN Accounts a
	ON p.ID = a.PersonID
	WHERE a.Balance > @money

GO

EXEC ups_PersonsWithMoreMoney 3000