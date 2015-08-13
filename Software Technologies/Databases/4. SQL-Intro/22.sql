SELECT t.Name AS [Departments and Towns] 
FROM Towns t
UNION
SELECT dpm.Name 
FROM Departments dpm