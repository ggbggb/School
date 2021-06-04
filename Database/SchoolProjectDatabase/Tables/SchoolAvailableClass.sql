﻿CREATE TABLE [dbo].[SchoolAvailableClass]
(
	[SAC_PK] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [SAC_SCL_School] UNIQUEIDENTIFIER NOT NULL, 
    [SAC_ST_SchoolTerm] UNIQUEIDENTIFIER NULL, 
    [SAC_CLS_Class] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT FK_SCHOOLAVAILABLECLASS_SCHOOL FOREIGN KEY ([SAC_SCL_School]) REFERENCES [School](SCL_PK),
    CONSTRAINT FK_SCHOOLAVAILABLECLASS_SCHOOLTERM FOREIGN KEY ([SAC_ST_SchoolTerm]) REFERENCES [SchoolTerm](ST_PK),
    CONSTRAINT FK_SCHOOLAVAILABLECLASS_CLASS FOREIGN KEY ([SAC_CLS_Class]) REFERENCES [Class](CLS_PK)

)
