# Movies API

A RESTful **ASP.NET Core 9 Web API** for managing movies list.
Built with **Entity Framework Core**, **JWT Authentication**, and **Clean Architecture** principles.

---

## 🚀 Features
- User registration & login with JWT authentication
- Role-permissions based authorization (Admin, User)
- Movies management
- Swagger/OpenAPI documentation
- EF Core with code-first migrations
- Docker support for containerized deployment

---

## 🛠️ Tech Stack
- ASP.NET Core 9
- Entity Framework Core
- PostgreSQL
- Docker
- JWT Bearer Authentication
- Bcrypt
- Scalar
- Clean Architecture

## Getting Started

### 📋 Prerequisites
- .NET 9 SDK
- PostgreSQL

---

### ⚙️ Installation
```bash
git clone https://github.com/kozmamisha/MoviesApi.git
cd MoviesApi
dotnet build
```

---

### Run Database Migrations
```bash
dotnet ef database update
```

---

### Run the API
```bash
dotnet run --project MoviesApi
```

API will be available at:
👉 http://localhost:5000 (or configured port)
