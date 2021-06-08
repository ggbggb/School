﻿CREATE TABLE [dbo].[Invoices]
(
	[InvoicePK] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [SchoolPK] UNIQUEIDENTIFIER NOT NULL,
    [InvoiceNo] VARCHAR(20) NOT NULL DEFAULT '',
    [Description] NVARCHAR(100) NOT NULL DEFAULT '', 
    [DueDate] DATE NOT NULL, 
    [InvoiceFromPK] UNIQUEIDENTIFIER NOT NULL, 
    [InvoiceToPK] UNIQUEIDENTIFIER NOT NULL, 
    [InvoiceForPK] UNIQUEIDENTIFIER NOT NULL, 
    [IsPaid] BIT NOT NULL DEFAULT 0, 
    [IsDeleted] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT FK_INVOICES_SCHOOL FOREIGN KEY ([SchoolPK]) REFERENCES [Schools](SchoolPK),
    CONSTRAINT FK_INVOICES_INVOICEFROM FOREIGN KEY ([InvoiceFromPK]) REFERENCES [Contacts](ContactPK),
    CONSTRAINT FK_INVOICES_INVOICETO FOREIGN KEY ([InvoiceToPK]) REFERENCES [Contacts](ContactPK),
    CONSTRAINT FK_INVOICES_INVOICEFOR FOREIGN KEY ([InvoiceForPK]) REFERENCES [Contacts](ContactPK),
)
