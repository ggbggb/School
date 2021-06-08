CREATE TABLE [dbo].[Contacts]
(
	[ContactPK] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Title] NVARCHAR(10) NULL, 
    [FirstName] NVARCHAR(20) NOT NULL DEFAULT '', 
    [MiddleName] NVARCHAR(20) NULL, 
    [LastName] NVARCHAR(20) NOT NULL DEFAULT '', 
    [DateOfBirth] DATE NULL,
    [Address] NVARCHAR(150) NULL, 
    [PostCode] VARCHAR(10) NULL, 
    [Country] VARCHAR(20) NULL, 
    [Phone] VARCHAR(20) NULL, 
    [Email] VARCHAR(50) NULL, 
    [ContactByPhone] BIT NULL, 
    [ContactByEmail] BIT NULL, 
    [IsDeleted] BIT NOT NULL DEFAULT 0, 
    [IsActive] BIT NOT NULL DEFAULT 1, 
)
