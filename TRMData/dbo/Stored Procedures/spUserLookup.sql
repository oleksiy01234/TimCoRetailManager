create procedure [dbo].[spUserLookup]
	@Id nvarchar(128)
as
begin
	set nocount on;

	select Id, FirstName, LastName, Email, CreatedAt
	from [dbo].[User]
	where Id = @Id;
end