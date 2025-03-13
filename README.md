# Dependency Injection Practice - ClassRoom Controller

This project demonstrates a simple implementation of Dependency Injection (DI) in ASP.NET Core using a `ClassRoomController` and an `ITeacher` interface.

## Overview

The `ClassRoomController` depends on an `ITeacher` interface. This allows for loose coupling and makes the controller easily testable. The `Teacher` class implements the `ITeacher` interface and provides the necessary information.

## Project Structure

-   **Controllers:**
    -   `ClassRoomController.cs`: Contains the API endpoint to retrieve teacher information.
-   **Models:**
    -   `ITeacher.cs`: Defines the interface for teacher-related operations.
    -   `Teacher.cs`: Implements the `ITeacher` interface and provides teacher details.

## How to Use

1.  **Clone the repository.**
2.  **Open the project in your preferred IDE (e.g., Visual Studio).**
3.  **Run the application.**
4.  **Access the API endpoint:** `GET /api/ClassRoom/info`

## API Endpoint

-   `GET /api/ClassRoom/info`: Returns the teacher's first and last name.

## Dependency Injection Setup

In your `Startup.cs` (or `Program.cs` in .NET 6+), you'll need to register the `ITeacher` interface with its implementation. For example (in Program.cs):

```csharp
// ... other code ...
builder.Services.AddScoped<ITeacher, Teacher>();
// ... other code ...
