SELECT empl.FirstName, empl.MiddleName, empl.LastName, mng.FirstName + ' ' + mng.LastName AS Manager
FROM Employees empl
INNER JOIN Employees mng
ON empl.ManagerID = mng.EmployeeID