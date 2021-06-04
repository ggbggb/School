CREATE TABLE [dbo].[UserRole]
(
	[UR_PK] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [UR_Code] VARCHAR(10) NOT NULL DEFAULT '', 
    [UR_Description] VARCHAR(20) NOT NULL DEFAULT ''
)

/* OWN: School Owner
 * TCH: Teacher
 * STD: Student
 * PAR: Parent/Guardian
*/