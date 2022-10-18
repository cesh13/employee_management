CREATE PROCEDURE [dbo].[spEmployee_Create]
	@firstName nvarchar(100),
	@lastName nvarchar(100),
	@phone nvarchar(14),
	@zip nvarchar(10),
	@hireDate date
AS
BEGIN
	INSERT INTO dbo.[Employee] (FirstName, LastName, Phone, Zip, HireDate) 
	VALUES (@firstName, @lastName, @phone, @zip, @hireDate)
END
