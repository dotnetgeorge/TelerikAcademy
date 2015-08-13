SELECT AVG(e.Salary) AS [Average Salary in Sales Department]
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID AND d.Name = 'Sales'