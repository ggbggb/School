CREATE TABLE [dbo].[Transactions]
(
	[TransactionPK] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [TransactionDate] DATE NOT NULL, 
    [SchoolPK] UNIQUEIDENTIFIER NOT NULL, 
    [Description] NVARCHAR(100) NOT NULL DEFAULT '', 
    [IsCredit] BIT NOT NULL DEFAULT 0, 
    [Amount] MONEY NOT NULL DEFAULT 0, 
    [PayerContactPK] UNIQUEIDENTIFIER NOT NULL, 
    [PayeeContactPK] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT FK_TRANSACTIONS_SCHOOL FOREIGN KEY ([SchoolPK]) REFERENCES [Schools](SchoolPK),
    CONSTRAINT FK_TRANSACTIONS_PAYER FOREIGN KEY ([PayerContactPK]) REFERENCES [Contacts](ContactPK),
    CONSTRAINT FK_TRANSACTIONS_PAYEE FOREIGN KEY ([PayeeContactPK]) REFERENCES [Contacts](ContactPK),
)
