CREATE TABLE [dbo].[Suppliers]
(
    [SupplierID] INT IDENTITY(1,1) NOT NULL,
    [SupplierName] VARCHAR(150) NOT NULL,
    [ContactPerson] VARCHAR(100) NOT NULL,
    [PhoneNumber] VARCHAR(30) NOT NULL,
    [EmailAddress] VARCHAR(150) NULL,
    [PhysicalAddress] VARCHAR(255) NULL,
    [Status] VARCHAR(20) NOT NULL
        CONSTRAINT [DF_Suppliers_Status] DEFAULT 'Active',

    CONSTRAINT [PK_Suppliers]
        PRIMARY KEY ([SupplierID]),

    CONSTRAINT [UQ_Suppliers_SupplierName]
        UNIQUE ([SupplierName])
);