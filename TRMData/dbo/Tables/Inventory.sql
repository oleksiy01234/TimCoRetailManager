CREATE TABLE [dbo].[Inventory]
(
	[Id] int not null primary key identity,
	[ProductId] int not null,
	[Quantity] int not null default 1,
	[PurchasePrice] money not null,
	[CreatedAt] datetime2 not null default getutcdate()
)
