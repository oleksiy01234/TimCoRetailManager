create table [dbo].[Product]
(
	[Id] int not null primary key identity,
	[ProductName] nvarchar(50) not null,
	[Description] nvarchar(MAX) not null,
	[RetailPrice] money not null,
    [QuantityInStock] INT NOT NULL DEFAULT 1,
	[CreatedAt] datetime2 not null default getutcdate(),
	[ModifiedAt] datetime2 not null default getutcdate()
)
