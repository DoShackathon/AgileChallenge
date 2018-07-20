CREATE TABLE [dbo].[Subjects] (
    [ContactId]    INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (MAX) NULL,
    [LastName]     NVARCHAR (MAX) NULL,
    [MiddleName]   NVARCHAR (MAX) NULL,
    [EmailAddress] NVARCHAR (MAX) NULL,
    [MobilePhone]  NVARCHAR (MAX) NULL,
    [WorkPhone]    NVARCHAR (MAX) NULL,
    [HomePhone]    NVARCHAR (MAX) NULL,
    [AddressLine1] NVARCHAR (MAX) NULL,
    [AddressLine2] NVARCHAR (MAX) NULL,
    [City]         NVARCHAR (MAX) NULL,
    [StateCode]    NVARCHAR (MAX) NULL,
    [CountryCode]  NVARCHAR (MAX) NULL,
    [ZipCode]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED ([ContactId] ASC)
);

