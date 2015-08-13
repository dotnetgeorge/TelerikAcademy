SELECT empl.FirstName, empl.LastName, mng.FirstName + ' ' + mng.LastName AS Manager, adr.AddressText
FROM Employees empl
INNER JOIN Employees mng
ON empl.EmployeeID = mng.ManagerID
INNER JOIN Addresses adr
ON empl.AddressID = adr.AddressID