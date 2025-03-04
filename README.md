# CRUD Operations in C# Windows Forms Application

This repository contains a simple C# Windows Forms application for performing basic CRUD (Create, Read, Update, Delete) operations on a SQL Server database. It interacts with a `teacher` table in a `school` database, allowing users to insert, update, delete, and view records related to teachers.

## Features

- **Insert a new teacher record**: Allows users to insert a teacher's information (ID, Name, Surname, Address, Salary).
- **Update teacher record**: Enables the modification of existing teacher records based on the teacher's ID.
- **Delete teacher record**: Removes a teacher's record from the database using the teacher's ID.
- **View all records**: Displays all teacher records in a DataGridView.
- **Find teacher by ID**: Retrieves and displays a specific teacher's details based on their ID.

## Prerequisites

- **Visual Studio**: A .NET development environment such as Visual Studio is required to open and run the project.
- **SQL Server**: The application uses SQL Server for database operations. You'll need access to a SQL Server instance and the `school` database.
- **SQL Server Connection**: Update the connection string in the code to match your database setup.

## Database Setup

This application requires a `teacher` table in the `school` database. The table should have the following columns:

- `id` (Primary Key)
- `name`
- `surname`
- `address`
- `salary`

Ensure that the SQL Server instance is running and the database is set up before running the application.

## How to Use

1. Clone or download the repository to your local machine.
2. Open the solution file `CRUDOperations.sln` in Visual Studio.
3. Build and run the application.
4. Use the form interface to perform CRUD operations on the `teacher` table:
   - Insert new records by filling out the form and clicking "Insert".
   - Update existing records by providing the teacher's ID and modifying other fields, then click "Update".
   - Delete a record by entering the teacher's ID and clicking "Delete".
   - View all records by clicking "Show All".
   - Search for a teacher by ID using the "Find" button.

## Code Overview

The main logic of the application is contained in the `Form1` class, which handles the SQL operations:

- `btnInsert_Click`: Inserts a new teacher into the database.
- `btnUpdate_Click`: Updates an existing teacher's details.
- `btnDelete_Click`: Deletes a teacher record from the database.
- `btnShowAll_Click`: Displays all teachers in a DataGridView.
- `btnFind_Click`: Retrieves a teacher's details by ID and displays them.
- `displaydata`: A helper method to display teacher records in the DataGridView.

### Sample Code (Form1.cs)

```csharp
private void btnInsert_Click(object sender, EventArgs e)
{
    string query = $"insert into teacher values('{tbxTeacherId.Text}', '{tbxName.Text}', '{tbxSurname.Text}', '{tbxAddress.Text}', '{tbxSalary.Text}')";
    cmd.CommandText = query;
    conn.Open();
    cmd.ExecuteNonQuery();
    cleardata();
    conn.Close();
    displaydata();
}
