# Stock_Tracking - ASP.NET MVC Stock Management System

## 📋 About The Project

A comprehensive stock management system developed with ASP.NET MVC. Built using Entity Framework, SQL Server, and modern web technologies.

## ✨ Features

- ✅ Product management (CRUD operations)
- ✅ Category management
- ✅ Customer management
- ✅ 15 Stored Procedures
- ✅ 4 User-Defined Functions
- ✅ 12 Database Triggers
- ✅ Responsive design (Bootstrap)
- ✅ Entity Framework Code First approach

## 🛠️ Technologies

- **Backend**: ASP.NET MVC 5, C#
- **Database**: SQL Server, Entity Framework 6
- **Frontend**: HTML5, CSS3, JavaScript, jQuery, Bootstrap

## 📁 Project Structure
```
Stock_Tracking/
├── Controllers/        # MVC Controllers
├── Models/Entity/      # Entity Framework models
├── Views/             # Razor view files
├── Database/          # SQL scripts and documentation
├── Content/           # CSS files
├── Scripts/           # JavaScript files
└── App_Start/         # Application configuration
```

## 🚀 Installation

### 1. Database Setup
```bash
# Run the DatabaseScript.sql file from the Database folder
cd Database
# Open DatabaseScript.sql in SSMS and execute with F5
```

### 2. Connection Settings

Update the connection string in `Web.config`:
```xml
<connectionStrings>
  <add name="DefaultConnection" 
       connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=mvcstokk;Integrated Security=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 3. Run The Project
```bash
# Open the project in Visual Studio
# Press F5 to run
```



## 📧 Contact

Project Link: [https://github.com/suhavural/Stock_Tracking](https://github.com/suhavural/Stock_Tracking)
