CREATE TABLE [dbo].[Contact]
(
	[COT_PK] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [COT_Title] NVARCHAR(10) NULL, 
    [COT_FirstName] NVARCHAR(20) NOT NULL DEFAULT '', 
    [COT_MiddleName] NVARCHAR(20) NULL, 
    [COT_LastName] NVARCHAR(20) NOT NULL DEFAULT '', 
    [COT_DateOfBirth] DATE NULL,
    [COT_Address] NVARCHAR(150) NULL, 
    [COT_PostCode] VARCHAR(10) NULL, 
    [COT_Country] VARCHAR(20) NULL, 
    [COT_Phone] VARCHAR(20) NULL, 
    [COT_Email] VARCHAR(50) NULL, 
    [COT_ContactByPhone] BIT NULL, 
    [COT_ContactByEmail] BIT NULL, 
    [COT_IsDeleted] BIT NOT NULL DEFAULT 0, 
    [COT_IsActive] BIT NOT NULL DEFAULT 1, 
)
