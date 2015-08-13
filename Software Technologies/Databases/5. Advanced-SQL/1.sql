SELECT e.FirstName, e.LastName, e.Salary
FROM Employees e
WHERE e.Salary = 
	(SELECT MIN(Employees.Salary) FROM Employees)