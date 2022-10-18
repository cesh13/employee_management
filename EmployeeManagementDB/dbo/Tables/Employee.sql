CREATE TABLE [dbo].[Employee]
(
	[EmployeeID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LastName] NVARCHAR(100) NOT NULL, 
    [FirstName] NVARCHAR(100) NOT NULL, 
    [Phone] NVARCHAR(14) NOT NULL, 
    [Zip] NVARCHAR(10) NOT NULL, 
    [HireDate] DATE NOT NULL
)
