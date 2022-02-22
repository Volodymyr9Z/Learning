USE Contacts;

BULK INSERT dbo.ContactVerificationDetails
	FROM 'C:\Users\VolodymyrZlaman\Desktop\Learning\sql-server-database-programming-stored-procedures\Database\contactsdb\importfiles\06_ContactVerificationDetails.csv'
WITH
(
	ROWTERMINATOR = '\n',
	FIELDTERMINATOR = ',',
	FIRSTROW = 2,
	
	CHECK_CONSTRAINTS
);
	
GO


