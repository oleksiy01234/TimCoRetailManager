create table [dbo].[User]
(
   [Id] nvarchar(128) not null primary key,
   [FirstName] nvarchar(50) not null,
   [LastName] nvarchar(50) not null,
   [Email] nvarchar(256) not null,
   [CreatedAt] datetime2 not null default getutcdate()
)
