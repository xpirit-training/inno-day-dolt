# ConsoleApp README

# ConsoleApp

This is a .NET 8 console application that connects to a MySQL database and retrieves entries from the employee table using Entity Framework with POCOs.

## Project Structure

- **Program.cs**: Entry point of the application. Sets up the DbContext, connects to the MySQL database, retrieves all entries from the employee table, and prints them to the console.
- **AppDbContext.cs**: Defines the AppDbContext class, which inherits from DbContext. It includes a DbSet<Employee> property to represent the employee table in the database.
- **Models/Employee.cs**: Defines the Employee class as a POCO that represents the structure of the employee table. It includes properties such as Id, Name, and Position.
- **ConsoleApp.csproj**: Project file for the .NET application. Specifies the project dependencies, including Entity Framework and the MySQL connector.

## Setup Instructions

1. Ensure you have .NET 8 SDK installed on your machine.
2. Install the required NuGet packages:
   - Microsoft.EntityFrameworkCore
   - Pomelo.EntityFrameworkCore.MySql
3. Update the connection string in `AppDbContext.cs` to match your MySQL server settings.
4. Run the application using the command:
   ```
   dotnet run
   ```

## Usage

Upon running the application, it will connect to the MySQL database at `localhost:3306` with the user `root` and no password, retrieve all entries from the employee table, and print them to the console.