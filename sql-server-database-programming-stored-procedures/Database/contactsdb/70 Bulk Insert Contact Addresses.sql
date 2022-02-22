USE Contacts;
	
BULK INSERT dbo.ContactAddresses
	FROM 'C:\Users\VolodymyrZlaman\Desktop\Learning\sql-server-database-programming-stored-procedures\Database\contactsdb\importfiles\02_ContactAddresses.csv'
WITH
(
	ROWTERMINATOR = '\n',
	FIELDTERMINATOR = ',',
	FIRSTROW = 2,
	
	CHECK_CONSTRAINTS
);

GO


