SELECT TOP(1) t.Name
FROM Employees e
JOIN Addresses a
ON a.AddressID = e.AddressID
JOIN Towns t
ON t.TownID = a.TownID
GROUP BY t.TownID, t.Name
ORDER BY COUNT(*) DESC