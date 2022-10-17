CREATE TABLE [dbo].[Employee]
(
	[EmployeeID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LastName] NCHAR(100) NOT NULL, 
    [FirstName] NCHAR(100) NOT NULL, 
    [Phone] NCHAR(14) NOT NULL, 
    [Zip] NCHAR(10) NOT NULL, 
    [HireDate] DATE NOT NULL
)
