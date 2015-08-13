SELECT t.Name AS [Town Name], d.Name, COUNT(*) AS [Count of employees]
FROM Employees e
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t
ON a.TownID = t.TownID 
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY t.Name, d.Name
ORDER BY [Town Name] ASC, [Count of employees] DESC