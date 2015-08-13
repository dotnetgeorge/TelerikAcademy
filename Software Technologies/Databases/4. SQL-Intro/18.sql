SELECT Employees.FirstName, Employees.MiddleName, Employees.LastName, Addresses.AddressText
FROM Employees
INNER JOIN Addresses
ON Employees.AddressID=Addresses.AddressID
