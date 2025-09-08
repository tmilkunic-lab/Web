## Solution Layout
ApplicationCore (Entities, Interfaces)  
Infrastructure (EF Core DbContext + Repositories)  
Web (Controllers, Views, Program.cs)

## Route Map
### Home
- GET /      → HomeController.Index
- GET /about → HomeController.About

### Products
- GET /Products                    → ProductsController.Index
- GET /Products/{id:int}           → ProductsController.Details(id)

## How to run
1) Set connection string `DefaultConnection` in Web/appsettings.json  
2) Run Web (Ctrl+F5)
