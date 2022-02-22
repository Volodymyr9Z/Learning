USE Contacts;

BULK INSERT dbo.ContactPhoneNumbers
	FROM 'C:\Users\VolodymyrZlaman\Desktop\Learning\sql-server-database-programming-stored-procedures\Database\contactsdb\importfiles\04_ContactPhoneNumbers.csv'
WITH
(
	ROWTERMINATOR = '\n',
	FIELDTERMINATOR = ',',
	FIRSTROW = 2,
	
	CHECK_CONSTRAINTS
);
	
GO


