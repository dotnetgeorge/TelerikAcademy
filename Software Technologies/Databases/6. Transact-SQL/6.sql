USE Northwind
GO

CREATE TABLE Logs (
	LogID INT IDENTITY(1,1) PRIMARY KEY,
	AccountID INT NOT NULL,
	OldSum MONEY,
	NewSum MONEY NOT NULL
)

GO

CREATE TRIGGER tr_LogAccountInsert ON Accounts FOR INSERT
AS
	DECLARE @AccountID INT
	SET @AccountID = (SELECT ID FROM inserted)
	DECLARE @OldSum MONEY
	SET @OldSum = (SELECT Balance FROM Accounts)
	DECLARE @NewSum MONEY
	SET @NewSum = (SELECT Balance FROM inserted)

	INSERT INTO Logs VALUES(@AccountID, @OldSum, @NewSum)
GO

INSERT INTO Persons VALUES('Victoria', 'Calloway', '411-80-1496')
INSERT INTO Accounts VALUES(4, 10000)