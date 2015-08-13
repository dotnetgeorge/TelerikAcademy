SELECT COUNT(*) AS [Count of employees in Sales] 
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID AND d.Name = 'Sales'