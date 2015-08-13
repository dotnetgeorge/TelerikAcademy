SELECT e.FirstName, e.LastName, e.Salary
FROM Employees e
WHERE e.Salary >
	(SELECT MIN(Salary) FROM Employees) + (SELECT MIN(Salary) FROM Employees) * 0.1
ORDER BY e.Salary