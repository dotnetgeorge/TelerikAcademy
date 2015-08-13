CREATE PROC usp_WithdrawMoney(@AccountID int, @Money float)
AS
	BEGIN TRAN
		UPDATE Accounts
		SET Balance -= @Money
		WHERE ID = @AccountID
		COMMIT
GO

CREATE PROC usp_DepositMoney(@AccountID int, @money float)
AS
	BEGIN TRAN
		UPDATE Accounts
		SET Balance += @Money
		WHERE ID = @AccountID
		COMMIT
GO

EXEC usp_WithdrawMoney 1, 2000
EXEC usp_DepositMoney 1, 2000
GO