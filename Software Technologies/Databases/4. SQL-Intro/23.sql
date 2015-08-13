SELECT empl.FirstName, empl.LastName, mng.FirstName + ' ' + mng.LastName AS Manager
FROM Employees mng
RIGHT JOIN Employees empl
ON mng.ManagerID = empl.EmployeeID