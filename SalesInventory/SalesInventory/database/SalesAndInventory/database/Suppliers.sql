CREATE TABLE [dbo].[Suppliers]
(
    [SupplierID] INT IDENTITY(1,1) NOT NULL,
    [SupplierName] VARCHAR(150) NOT NULL,
    [ContactPerson] VARCHAR(100) NULL,
    [Phone] VARCHAR(30) NULL,
    [Email] VARCHAR(100) NULL,
    [Address] VARCHAR(255) NULL,
    [Status] VARCHAR(20) NOT NULL DEFAULT 'Active',

    CONSTRAINT [PK_Suppliers]
        PRIMARY KEY ([SupplierID])
);