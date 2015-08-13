SELECT m.FirstName + ' ' + m.LastName AS [Manager Name], COUNT(*) AS [Count of employees]
FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName + ' ' + m.LastName
HAVING COUNT(*) = 5
