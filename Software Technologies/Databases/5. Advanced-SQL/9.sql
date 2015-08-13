SELECT d.Name, AVG(e.Salary) AS AverageSalary
FROM Departments d
JOIN Employees e 
ON d.DepartmentID = e.DepartmentID
GROUP BY d.Name