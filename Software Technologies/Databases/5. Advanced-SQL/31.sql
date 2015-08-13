DECLARE @Tran varchar(7) = 'Restore'

BEGIN TRAN @Tran
	DROP TABLE EmployeesProjects
ROLLBACK TRAN @Tran