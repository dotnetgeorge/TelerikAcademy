USE TelerikAcademy
GO

CREATE PROC usp_EmployeesInTown @Results CURSOR VARYING OUTPUT
AS
	BEGIN
		SET @Results = CURSOR FOR
		SELECT emp.LastName, towns.Name FROM Employees emp
		JOIN Addresses addr 
			ON emp.AddressID = addr.AddressID
		JOIN Towns towns 
			ON addr.TownID = towns.TownID
		GROUP BY towns.TownID, towns.Name, emp.LastName
		OPEN @Results
	END
GO

DECLARE @EmployeesInTowns CURSOR
DECLARE @LastName varchar(20), @TownName varchar(20)
EXEC usp_EmployeesInTown @Results = @EmployeesInTowns OUTPUT