CREATE TABLE [dbo].[Address]
(
	[AddressId] INT IDENTITY (1, 1) NOT NULL,
	[ContactId] int not null,
	AddressLine1 NVARCHAR(MAX),
	AddressLine2 NVARCHAR(max),
	City NVARCHAR(max),
	State NVARCHAR(max),
	Zip NVARCHAR(max),
	Country NVARCHAR(max), 
    CONSTRAINT [FK_Address_Subjects] FOREIGN KEY (ContactId) REFERENCES dbo.Subjects(ContactId)
)
