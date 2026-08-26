# Notes API

A REST API for managing personal notes (CRUD), built with ASP.NET Core, Entity Framework Core, and SQLite.

## About This Project

This project was built as a hands-on learning exercise to gain practical experience 
with C# and the .NET ecosystem. I worked through it incrementally over a few days, 
building each layer (models, database, API endpoints) step by step to understand 
how the pieces fit together, coming from a primary background in mobile and 
frontend development (React Native, Flutter, React).

## Tech Stack

- ASP.NET Core (.NET 10)
- Entity Framework Core
- SQLite
- Swagger UI

## Endpoints

| Method | Endpoint          | Description        |
|--------|-------------------|---------------------|
| GET    | `/api/notes`      | Get all notes       |
| GET    | `/api/notes/{id}` | Get a single note   |
| POST   | `/api/notes`      | Create a new note   |
| PUT    | `/api/notes/{id}` | Update a note       |
| DELETE | `/api/notes/{id}` | Delete a note       |

## Running Locally

\`\`\`bash
dotnet restore
dotnet ef database update
dotnet run
\`\`\`

Then open `http://localhost:5097/swagger` to test the API.