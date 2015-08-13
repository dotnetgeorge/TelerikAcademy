SELECT Employees.FirstName, Employees.MiddleName, Employees.LastName 
FROM Employees
WHERE Employees.Salary > 50000
ORDER BY Employees.Salary DESC