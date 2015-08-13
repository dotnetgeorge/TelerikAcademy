SELECT d.Name, e.JobTitle, d.DepartmentID, AVG(e.Salary) AS [Average employee salary]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.DepartmentID, d.Name, e.JobTitle