USE master
GO

CREATE DATABASE TestPerformance;
GO

USE TestPerformance
GO

CREATE TABLE Comments (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Content TEXT NOT NULL,
	CommentDate DATE NOT NULL
)
GO

DECLARE @Loop INT
SET @Loop = 10000000
DECLARE @Text VARCHAR(100)
DECLARE @Index INT
SET @Index = 1
DECLARE @Date DATE
SET @Date = GETDATE()

WHILE @Loop > 0
BEGIN
	SET @Text = 'Comments is just test : ' + CONVERT(VARCHAR(100), @Index) + ' : ' + CONVERT(VARCHAR(100), NEWID())
	INSERT INTO dbo.Comments VALUES(@Text, @Date)
	SET @Loop = @Loop - 1
	SET @Index = @Index + 1
END

GO

UPDATE dbo.Comments 
SET CommentDate = CONVERT(DATE, '2005-09-01')
WHERE ID LIKE '%9999'

GO

UPDATE dbo.Comments 
SET CommentDate = CONVERT(DATE, '2006-09-01')
WHERE ID LIKE '%8888'

GO

UPDATE dbo.Comments 
SET CommentDate = CONVERT(DATE, '2007-09-01')
WHERE ID LIKE '%7777'

GO

UPDATE dbo.Comments 
SET CommentDate = CONVERT(DATE, '2008-09-01')
WHERE ID LIKE '%6666'

GO

UPDATE dbo.Comments 
SET CommentDate = CONVERT(DATE, '2009-09-01')
WHERE ID LIKE '%5555'

GO

UPDATE dbo.Comments 
SET CommentDate = CONVERT(DATE, '2010-09-01')
WHERE ID LIKE '%4444'

GO

UPDATE dbo.Comments 
SET CommentDate = CONVERT(DATE, '2011-09-01')
WHERE ID LIKE '%3333'

GO

UPDATE dbo.Comments 
SET CommentDate = CONVERT(DATE, '2012-09-01')
WHERE ID LIKE '%2222'

GO

UPDATE dbo.Comments 
SET CommentDate = CONVERT(DATE, '2013-09-01')
WHERE ID LIKE '%1111'

GO

UPDATE dbo.Comments 
SET CommentDate = CONVERT(DATE, '2000-05-01')
WHERE ID LIKE '1111%'

GO

CHECKPOINT; DBCC DROPCLEANBUFFERS;

SELECT * FROM Comments
WHERE CommentDate > '2004-05-01' AND CommentDate < '2011-09-01'

GO -- 00:02:06 Without Cache - 6000 rows

SELECT * FROM Comments
WHERE CommentDate > '2004-05-01' AND CommentDate < '2011-09-01'

GO -- 00:00:00 With Cache 

CREATE INDEX IDX_Comments_CommentDate ON Comments(CommentDate)

CHECKPOINT; DBCC DROPCLEANBUFFERS;

SELECT * FROM Comments
WHERE CommentDate > '2004-05-01' AND CommentDate < '2011-09-01'

GO -- Without Cache and with index on CommentDate (DATE <- Type) . Time is: 00:01:14 - 6000 rows

SELECT * FROM Comments
WHERE Content LIKE '%4444%'

GO -- Without Caching And Without Full-Text Time Is : 00:03:30

CREATE FULLTEXT CATALOG CommentsFullTextCatalog WITH ACCENT_SENSITIVITY = OFF

GO

CREATE FULLTEXT INDEX ON Comments([Content])
KEY INDEX PK__Comments__3214EC2749A46474
ON CommentsFullTextCatalog
WITH CHANGE_TRACKING AUTO

GO -- Create full-text catalog and full-text index

CHECKPOINT; DBCC DROPCLEANBUFFERS;

SELECT * FROM Comments
WHERE CONTAINS(Content, '%4444%')

GO -- Without Caching And With Full-Text Time Is: 00:00:37
