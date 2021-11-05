create table [dbo].[Order]
(
	[Id] int not null primary key identity,
	[CashierId] nvarchar(128) not null,
	[CreatedAt] datetime2 not null,
	[SubTotal] money not null,
	[Tax] money not null,
	[Total] money not null
)
