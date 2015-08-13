CREATE TABLE Users (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Username varchar(50) UNIQUE NOT NULL,
	Password varchar(50) NOT NULL,
	FullName varchar(100) NOT NULL,
	LastLoginTime datetime,
	CHECK (LEN(Password) > 5)
)