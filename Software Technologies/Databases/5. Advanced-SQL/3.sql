SELECT e.FirstName, e.MiddleName, e.LastName, e.Salary, d.Name
FROM Employees e, Departments d
WHERE e.Salary =
	(SELECT MIN(Salary) FROM Employees
	WHERE e.DepartmentID = e.DepartmentID)
ORDER BY d.Name ASC 