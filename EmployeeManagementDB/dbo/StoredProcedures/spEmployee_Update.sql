CREATE PROCEDURE [dbo].[spEmployee_Update]
	@employeeid int,
	@firstName nvarchar(100),
	@lastName nvarchar(100),
	@phone nvarchar(14),
	@zip nvarchar(10),
	@hireDate date
AS
BEGIN
	UPDATE dbo.[Employee]
	SET FirstName = @firstName, LastName = @lastName, Phone = @phone, Zip = @zip, HireDate = @hireDate
	WHERE dbo.[Employee].EmployeeID = @employeeid
END
