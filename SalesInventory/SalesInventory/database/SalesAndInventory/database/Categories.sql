CREATE TABLE [dbo].[Categories]
(
	[CategoryID] INT IDENTITY(1,1) NOT NULL,
    [CategoryName] VARCHAR(100) NOT NULL,
    [Description] VARCHAR(255) NULL,
    [Status] VARCHAR(20) NOT NULL DEFAULT 'Active',

    CONSTRAINT [PK_Categories]
        PRIMARY KEY ([CategoryID]),

    CONSTRAINT [UQ_Categories_CategoryName]
        UNIQUE ([CategoryName])
)
