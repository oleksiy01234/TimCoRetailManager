create procedure [dbo].[spProduct_GetAll]
as
begin
	set nocount on;

	select Id, ProductName, [Description], RetailPrice, QuantityInStock
	from dbo.Product
	order by ProductName;
end