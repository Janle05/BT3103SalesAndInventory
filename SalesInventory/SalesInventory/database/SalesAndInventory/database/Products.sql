CREATE TABLE [dbo].[Products]
(
    [ProductID] INT IDENTITY(1,1) NOT NULL,
    [ProductName] VARCHAR(150) NOT NULL,
    [CategoryID] INT NOT NULL,
    [SupplierID] INT NOT NULL,
    [UnitPrice] DECIMAL(10,2) NOT NULL,
    [StockQuantity] INT NOT NULL,
    [ReorderLevel] INT NOT NULL,
    [Status] VARCHAR(20) NOT NULL DEFAULT 'Active',

    CONSTRAINT [PK_Products]
        PRIMARY KEY ([ProductID]),

    CONSTRAINT [FK_Products_Categories]
        FOREIGN KEY ([CategoryID])
        REFERENCES [dbo].[Categories]([CategoryID]),

    CONSTRAINT [FK_Products_Suppliers]
        FOREIGN KEY ([SupplierID])
        REFERENCES [dbo].[Suppliers]([SupplierID])
);