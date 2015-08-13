INSERT Users VALUES ('ddddddddddd', 'ddddddddd', 'dddddddddd', CONVERT(DATE, '09.03.2010', 104), 1)

UPDATE Users SET LastLoginTime = NULL
WHERE LastLoginTime < CONVERT(DATE, '10.03.2010', 104)