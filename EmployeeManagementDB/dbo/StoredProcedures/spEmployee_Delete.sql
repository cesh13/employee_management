CREATE PROCEDURE [dbo].[spEmployee_Delete]
	@employeeID int
AS
	DELETE FROM dbo.[Employee] WHERE EmployeeID = @employeeID
RETURN 0
