CREATE TABLE [dbo].[UserRoles]
(
	[UserRolePK] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Code] VARCHAR(10) NOT NULL DEFAULT '', 
    [Description] VARCHAR(20) NOT NULL DEFAULT ''
)

/* OWN: School Owner
 * TCH: Teacher
 * STD: Student
 * PAR: Parent/Guardian
*/