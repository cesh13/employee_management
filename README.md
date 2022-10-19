# Employee Managagement App

Employee Management App is solution containing three projects as following described

| Project                      | Description                                                                               |
| ---------------------------- | ----------------------------------------------------------------------------------------- |
| EmployeeManagementApp        | Front end application built with Blazor Server (Target framework: .Net 6.0)               |
| EmployeeManagementDataAccess | Class Library used as a data access layer (Target framework: .Net 6.0)                    |
| EmployeeManagementDB         | Sql Server Database project that holds the definition of the database to run as a localdb |

Before running the project you need to publish the sql database project:

1. Right click the sql server database project
2. Click on publish
3. Click on the Edit button next to "Target database connection"
4. On the tabs at the top click on Browse
5. Choose local and then MSSQLLocalDB
6. Accept that configuration and add a name in the Database name, you could use: EmployeeManagementDB, possibly you wont need to change the connection string if you use that name
7. At this point you could Save the profile to use it to publish later or just click Publish.
8. Database should be published in localdb
9. You can verify by going into the view menu at the top of visual studio and clicking on "SQL Server object explorer" and navigate through that explorer to SQL Server -> (localdb) -> databases
10. To make sure your connection string is correct, right click on the database and click properties, look for the connection string and copy it
11. Go to the EmployeeManagementApp project, locate appsettings.json and find the ConnectionString object, modify the information on the default setting with the new connection string.

Notes:

- Based on the previous description make sure your environment is able to run .Net 6, and visual studio is up to date.
- This project makes use of SQL Server Data Tools for Visual Studio, so those features must be installed to make use of the Sql Server Database Project.
