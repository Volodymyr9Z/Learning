USE Contacts;

BULK INSERT dbo.ContactRoles
	FROM 'C:\Users\VolodymyrZlaman\Desktop\Learning\sql-server-database-programming-stored-procedures\Database\contactsdb\importfiles\05_ContactRoles.csv'
WITH
(
	ROWTERMINATOR = '\n',
	FIELDTERMINATOR = ',',
	FIRSTROW = 2,
	
	CHECK_CONSTRAINTS
);
	
GO


