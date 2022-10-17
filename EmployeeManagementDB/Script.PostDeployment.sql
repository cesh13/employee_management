IF not exists (SELECT 1 FROM dbo.[Employee])
BEGIN
	INSERT INTO dbo.[Employee] (FirstName, LastName, Phone, Zip, HireDate) VALUES ('Cesar', 'Molina', '(123) 236-9988', '98987', '11-01-2022')
END
