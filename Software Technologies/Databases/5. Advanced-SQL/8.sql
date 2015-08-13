SELECT COUNT(*) AS [Count of employees with managers] 
FROM Employees e
WHERE ISNULL(e.ManagerID, 0) = 0