# JobBoard
This JobBoard application uses C# ASP.NET Core controller manages CRUD (Create, Read, Update, Delete) operations for `Job` entities. It uses the Entity Framework Core for database interactions.
- **Index**: Displays a list of all jobs.
- **Details**: Shows details of a specific job by its ID.
- **Create**: Provides a form to add a new job and handles form submission.
- **Edit**: Allows editing of an existing job's details.
- **Delete**: Provides a confirmation page for deleting a job and handles the deletion.
- **Security**: Actions are secured with anti-forgery tokens and checks for valid model states to protect against invalid data submissions.
