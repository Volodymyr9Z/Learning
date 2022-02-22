USE Contacts;

BULK INSERT dbo.Contacts
	FROM 'C:\Users\VolodymyrZlaman\Desktop\Learning\sql-server-database-programming-stored-procedures\Database\contactsdb\importfiles\01_Contacts.csv'
WITH
(
	ROWTERMINATOR = '\n',
	FIELDTERMINATOR = ',',
	FIRSTROW = 2,
	
	CHECK_CONSTRAINTS
)
	
GO


