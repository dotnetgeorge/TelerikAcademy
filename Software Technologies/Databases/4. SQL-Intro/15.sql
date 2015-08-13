SELECT Employees.FirstName, Employees.MiddleName, Employees.LastName
FROM Employees
WHERE ISNULL(Employees.ManagerID, 0) = 0