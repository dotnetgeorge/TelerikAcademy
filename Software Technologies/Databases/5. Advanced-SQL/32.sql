BEGIN TRAN
	SELECT * INTO #TempEmployeesProjects
	FROM EmployeesProjects

DROP TABLE EmployeesProjects

SELECT * INTO EmployeeProjects
FROM #TempEmployeesProjects

DROP TABLE #TempEmployeesProjects