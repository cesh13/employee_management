CREATE PROCEDURE [dbo].[spEmployee_GetOne]
	@EmployeeID int
AS
	SELECT * 
	FROM dbo.[Employee] e 
	WHERE e.EmployeeID = @EmployeeID
RETURN 0
