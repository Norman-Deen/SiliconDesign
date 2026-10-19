# SiliconDesign — ASP.NET Core MVC and Web API

A .NET 8 coursework project from EC Utbildning combining a Razor-based website, user accounts, course data, and backend APIs.

## Structure

| Path | Responsibility |
| --- | --- |
| `AspNetCore_MVC/` | MVC application, Razor views, account pages, SCSS, and browser scripts |
| `Infrastructure/` | Entity Framework Core, Identity entities, migrations, and shared data types |
| `WebApi/` | Course and subscriber API controllers |
| `SiliconDesign.sln` | Visual Studio solution |

## Stack

C# · .NET 8 · ASP.NET Core MVC · Identity · Entity Framework Core · SQL Server · REST APIs · Razor · HTML / SCSS / JavaScript

## Local development

Use the .NET 8 SDK and a compatible SQL Server instance. Review each application's configuration and supply database connection strings locally before running.

```bash
git clone https://github.com/Norman-Deen/SiliconDesign.git
cd SiliconDesign
dotnet restore SiliconDesign.sln
dotnet run --project AspNetCore_MVC/WepApp.csproj
```

The API is a separate application:

```bash
dotnet run --project WebApi/WebApi.csproj
```

Use the URLs printed by the application. Database setup and migrations may be required; this repository is an educational snapshot rather than a production deployment template.

## Author

[Nour Altinawi — Nourtin](https://nourtin.com/) · [LinkedIn](https://www.linkedin.com/in/nour-tinawi)

For my current Three.js, WebGL, and real-time 3D work, see [my profile](https://github.com/Norman-Deen).
