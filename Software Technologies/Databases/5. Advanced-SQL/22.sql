BEGIN TRAN
SELECT
LOWER(LEFT(FirstName, 1) + LastName) + CONVERT(nvarchar(5), ROW_NUMBER() OVER(ORDER BY FirstName)) AS UserName,
FirstName + ' ' + LastName AS FullName
INTO #TempUsers
FROM Employees;
INSERT Users
SELECT UserName, UserName + REPLACE(ISNULL(SPACE(6 - LEN(UserName)),''), ' ', '*'), FullName, NULL, NULL
FROM #TempUsers;
DROP TABLE #TempUsers;
GO