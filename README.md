# CS - Case Study Project

## Overview

This is a fullstack case study project built with ASP.NET Core 8.0. It consists of:
- **CaseStudy.API**: A RESTful backend API for product management (with PostgreSQL support)
- **CaseStudy.Frontend**: An ASP.NET Core MVC frontend for product listing and interaction

---

## Technologies Used
- ASP.NET Core 8.0 (Web API & MVC)
- Entity Framework Core 9
- PostgreSQL (NeonDB compatible)
- Npgsql.EntityFrameworkCore.PostgreSQL
- Bootstrap 5 (Frontend UI)
- Newtonsoft.Json

---

## Project Structure

```
CS/
  CaseStudy/
    CaseStudy.API/         # Backend API
    CaseStudy.Frontend/    # Frontend MVC
    CaseStudy.sln          # Solution file
  README.md
```

---

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [PostgreSQL Database](https://neon.tech/) (or compatible)

### 1. Clone the Repository
```sh
git clone <repo-url>
cd CS/CaseStudy
```

### 2. Configure Database Connection

Edit both `CaseStudy.API/appsettings.json` and `CaseStudy.API/appsettings.Development.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Host=ep-floral-fire-ab4dgh5k-pooler.eu-west-2.aws.neon.tech; Database=neondb; Username=neondb_owner; Password=npg_Yoe0dmWVl4gs; SSL Mode=Require; Channel Binding=Require;"
}
```

### 3. Install Dependencies
```sh
dotnet restore
```

### 4. Apply Migrations & Update Database
```sh
cd CaseStudy.API
# If switching from SQL Server, delete old Migrations folder first
# rm -r Migrations
# Then:
dotnet ef migrations add InitialMigration
# (if not already present)
dotnet ef database update
```

### 5. Run the Projects
#### Backend API
```sh
cd CaseStudy.API
dotnet run
```
#### Frontend
Open a new terminal:
```sh
cd ../CaseStudy.Frontend
dotnet run
```

---

## API Endpoints

### ProductsController
- `GET    /api/products`           : List all products
- `GET    /api/products/{id}`      : Get product by ID
- `GET    /api/products/price/{id}`: Calculate price for product
- `POST   /api/products`           : Create new product
- `PUT    /api/products`           : Update product
- `DELETE /api/products/{id}`      : Delete product

---

## Product Model
```csharp
public class Product {
    public int Id { get; set; }
    public string name { get; set; }
    public double popularityScore { get; set; }
    public double weight { get; set; }
    public string yellowimage { get; set; }
    public string roseimage { get; set; }
    public string whiteimage { get; set; }
}
```

---

## Frontend
- ASP.NET Core MVC
- Main page: lists products, allows color selection, shows product images in a slider
- Fetches product data and prices from the API

---

## Notes
- Ensure your PostgreSQL/NeonDB instance is accessible from your development environment.
- If you change the connection string key (e.g., from `Local` to `DefaultConnection`), update it in both `appsettings.json` and `Program.cs`.
- For a fresh start, delete the `Migrations` folder and re-create migrations after switching database providers.

---

## License
This project is for educational and demonstration purposes.
