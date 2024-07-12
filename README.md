# Installation project

- Step 1: Clone or download the project

Clone the project repository or download the code archive.

- Step 2: Open the project in Visual Studio

Open Visual Studio. Select Open a project or solution. Select the solution (.sln file) in the root directory of the project.

- Step 3: Configure the database

Open the appsettings.json file in the AuthApi project. Modify the database connection string to suit your environment: 

![image](https://github.com/user-attachments/assets/432c1e5d-c3fe-4f15-9e9c-551f0cded7ae)

- Step 4: Create and update the database

Open the Package Manager Console (Tools -> NuGet Package Manager -> Package Manager Console).
Run the commands to add the migration and upgrade the database:

**Add-Migration InitialCreate**

**Update-Database**

- Step 5: Start API server

Start the API server (YamSoftwareTestTaskREST_API) from Visual Studio (press F5 or click the run button).
Step 6: Launch the console application

In another instance of Visual Studio, open the ConsoleClient project.
Start the console application (YamSoftwareTestTask_Client) (press F5 or press the start button).
2. Script for filling the table with test data [dbo].[Users]
Step 1: Creating an SQL script for data filling

Open SQL Server Management Studio (SSMS) or another database management tool.
Run the following SQL script to populate the [dbo].[Users] table with test data:

INSERT INTO [dbo].[Users] (Username, Password, Name) VALUES

('testuser1', 'password1', 'Test User 1'),

('testuser2', 'password2', 'Test User 2'),

('testuser3', 'password3', 'Test User 3');

