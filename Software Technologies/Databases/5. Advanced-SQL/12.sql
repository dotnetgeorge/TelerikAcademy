SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], COALESCE(m.FirstName + ' ' + m.LastName, '(no manager)') AS [Manager Name]
FROM Employees e
LEFT JOIN Employees m
ON e.ManagerID = m.EmployeeID