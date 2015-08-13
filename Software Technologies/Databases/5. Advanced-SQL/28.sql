SELECT t.Name, COUNT(*) AS [Count of managers]
FROM Employees e
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t
ON t.TownID = a.TownID
WHERE e.ManagerID IS NOT NULL
GROUP BY t.Name
ORDER BY [Count of managers] DESC