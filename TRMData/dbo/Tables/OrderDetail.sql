create table [dbo].[OrderDetail]
(
	[Id] int not null primary key identity,
	[OrderId] int not null,
	[ProductId] int not null,
	[Quantity] int not null default 1,
	[PurchasePrice] money not null,
	[Tax] money not null default 0
)
