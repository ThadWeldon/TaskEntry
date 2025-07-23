# TaskEntry - ASP.NET Core Task Tracker

A simple web-based task tracker built with ASP.NET Core Razor Pages and Entity Framework Core (SQLite).  
Easily add, complete, and delete tasks with a clean, modern UI.

## Features

- Add tasks with a title and description
- Mark tasks as completed/incomplete
- Delete all completed tasks with one click
- Responsive, centered layout with a modern design
- Data stored locally in a SQLite database

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- (Optional) [Visual Studio Code](https://code.visualstudio.com/) or Visual Studio

### Setup

1. **Clone the repository:**
    ```sh
    git clone https://github.com/yourusername/TaskEntry.git
    cd TaskEntry/TaskEntry/TaskTracker
    ```

2. **Restore dependencies:**
    ```sh
    dotnet restore
    ```

3. **Apply database migrations:**
    ```sh
    dotnet ef database update
    ```

4. **Run the application:**
    ```sh
    dotnet run
    ```

5. **Open your browser:**  
   Visit the URL shown in the terminal

## Project Structure

- `Models/TaskEntryDB.cs` - The task entity model
- `Data/AppDBContext.cs` - Entity Framework Core database context
- `Pages/Index.cshtml` - Main Razor Page for the UI
- `Pages/Index.cshtml.cs` - Page model (C# logic)
- `Program.cs` - ASP.NET Core app startup

## Customization

- Update styles in `Pages/Index.cshtml` for your preferred look.
- Extend the model or add new features as needed.
