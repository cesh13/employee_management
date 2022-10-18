CREATE PROCEDURE [dbo].[spEmployee_GetAll]
AS
BEGIN
	SELECT * FROM dbo.[Employee]
	ORDER BY dbo.[Employee].HireDate DESC
END
