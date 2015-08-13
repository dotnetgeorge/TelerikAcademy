SELECT Employees.FirstName, Employees.MiddleName, Employees.LastName, Addresses.AddressText
FROM Employees, Addresses
WHERE Employees.AddressID = Addresses.AddressID