CREATE PROCEDURE [dbo].[spEmployee_Search]
	@searchText nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.[Employee] e
	WHERE e.LastName like '%' + @searchText + '%' 
	OR e.Phone like '%' + @searchText + '%' 
END
