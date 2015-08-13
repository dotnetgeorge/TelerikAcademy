SELECT empl.FirstName, empl.MiddleName, empl.LastName, empl.HireDate
FROM Employees empl
RIGHT JOIN Departments dpm
ON empl.DepartmentID = dpm.DepartmentID
WHERE dpm.Name = 'SALES' OR dpm.Name = 'Finance' AND empl.HireDate BETWEEN '1994-12-31' AND '2006-01-01'