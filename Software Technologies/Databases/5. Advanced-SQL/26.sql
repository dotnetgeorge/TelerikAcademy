SELECT e.FirstName, e.LastName, e.JobTitle, d.Name, e.Salary
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary =
	(SELECT MIN(Salary) FROM Employees
	WHERE d.DepartmentID = e.DepartmentID)