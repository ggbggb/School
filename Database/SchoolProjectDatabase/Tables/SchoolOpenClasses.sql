﻿CREATE TABLE [dbo].[SchoolOpenClasses]
(
	[SAC_PK] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [SAC_SCL_School] UNIQUEIDENTIFIER NOT NULL, 
    [SAC_ST_SchoolTerm] UNIQUEIDENTIFIER NULL, 
    [SAC_CLS_Class] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT FK_SCHOOLOPENCLASSES_SCHOOL FOREIGN KEY ([SAC_SCL_School]) REFERENCES [Schools](SCL_PK),
    CONSTRAINT FK_SCHOOLOPENCLASSES_SCHOOLTERM FOREIGN KEY ([SAC_ST_SchoolTerm]) REFERENCES [SchoolTerms](ST_PK),
    CONSTRAINT FK_SCHOOLOPENCLASSES_CLASS FOREIGN KEY ([SAC_CLS_Class]) REFERENCES [Classes](CLS_PK)

)
