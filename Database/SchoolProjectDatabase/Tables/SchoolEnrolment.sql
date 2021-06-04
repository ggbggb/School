﻿CREATE TABLE [dbo].[SchoolEnrolment]
(
	[SE_PK] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [SE_CLS_Class] UNIQUEIDENTIFIER NOT NULL, 
    [SE_STD_Student] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT FK_SCHOOLENROLMENT_CLASS FOREIGN KEY ([SE_CLS_Class]) REFERENCES [Class](CLS_PK),
    CONSTRAINT FK_SCHOOLENROLMENT_STUDENT FOREIGN KEY ([SE_STD_Student]) REFERENCES [Student](STD_PK),
)