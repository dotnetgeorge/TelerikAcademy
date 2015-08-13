CREATE VIEW UsersLoggedToday AS
SELECT FullName, LastLoginTime FROM Users
WHERE DAY(LastLoginTime) = DAY(GETDATE()) AND YEAR(LastLoginTime) = YEAR(GETDATE())