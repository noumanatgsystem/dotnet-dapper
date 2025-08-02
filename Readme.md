# 🧱 Dapper + EF Core Clean Architecture CRUD API

This is a .NET 8 Web API project following the Clean Architecture pattern, combining **Dapper** for GET (read) operations and **Entity Framework Core** for POST/PUT/DELETE (write) operations.

---

## 📦 Tech Stack

* .NET 8 Web API
* Dapper (GET only)
* EF Core (POST, PUT, DELETE)
* SQL Server
* Clean Architecture

---

## 📁 Folder Structure

```
🔺 Entities                  # DapperDbModel
🔺 DataTransferModels       # DTOs
🔺 Interface                # Interfaces (e.g., IDapperService)
🔺 Services                 # Implementations
🔺 Controllers              # API endpoints
🔺 Context                  # EF DbContext
🔺 Program.cs               # Entry point
```

---

## ⚙️ Features

* ✅ Use Dapper for fast data retrieval (GET)
* ✅ Use EF Core for data modification (POST/PUT/DELETE)
* ✅ Clean layer separation (Presentation, Application, Infrastructure, Domain)
* ✅ SQL Server-based storage

---

## 🥪 API Endpoints

| Method | Endpoint                   | Description     |
| ------ | -------------------------- | --------------- |
| GET    | `/api/Dapper/GetAll`       | Get all records |
| GET    | `/api/Dapper/GetById/{id}` | Get by ID       |
| GET    | `/api/Dapper/GetByEmail`   | Get by Email    |
| POST   | `/api/Dapper/Save`         | Create record   |
| PUT    | `/api/Dapper/Update/{id}`  | Update record   |
| DELETE | `/api/Dapper/Delete/{id}`  | Delete record   |

---

## 🚀 Getting Started

### 🛒 Clone the repo

```bash
git clone https://github.com/noumanatgsystem/dotnet-dapper.git
cd dotnet-dapper
```

### 📝 Configure DB

Update your `appsettings.json` with a valid SQL Server connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=YourDbName;Trusted_Connection=True;"
}
```

### ⚒️ Apply EF Migrations (optional)

```bash
dotnet ef database update
```

### ▶️ Run the project

```bash
dotnet run
```

---

## ✅ Commands Summary

```bash
# Clone
git clone https://github.com/noumanatgsystem/dotnet-dapper.git

# Navigate
cd dotnet-dapper

# Update appsettings.json
# Add your SQL Server connection string

# (Optional) Apply migrations
dotnet ef database update

# Run the app
dotnet run
```

---

## 🧰 Suggestions for Extension

* Add Swagger for API testing
* Use FluentValidation for input validation
* Add AutoMapper for cleaner mapping
* Add Dockerfile + docker-compose
* CI/CD with GitHub Actions

---

## 🪪 License

Licensed under the MIT License.

---

Made with ❤️ by **Muhammad Nouman**
