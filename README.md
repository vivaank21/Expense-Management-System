# 💰 Expense Management System

A modern and fully functional **Expense Management System** developed using **C# .NET Windows Forms** and **SQL Server**.  
This application helps users manage their daily income and expenses with reports, charts, and dashboard analytics.

---

## 🚀 Features

✅ Dashboard Overview  
✅ Add Income Records  
✅ Add Expense Records  
✅ Expense Category Management  
✅ Income Category Management  
✅ Expense Display & Reports  
✅ Income & Expense Analytics Charts  
✅ PDF Report Export  
✅ SQL Server Database Connectivity  
✅ User-Friendly Windows Forms UI  
✅ Custom Message Boxes & Alerts  

---

## 🖥️ Modules

### 📊 Dashboard
- Central navigation panel
- Quick access to all modules
- Analytics & chart integration

### 💵 Income Management
- Add income details
- Select income categories
- Store descriptions & amounts

### 💸 Expense Management
- Add expense records
- Expense date selection
- Category-wise expense tracking
- Description support

### 📈 Charts & Analytics
Includes professional chart visualizations:

- Last 6 Months Expense Trend
- Income vs Expense Comparison
- Expense Breakdown Analysis

### 📄 Reports
- View Income Reports
- View Expense Reports
- Export reports to PDF using iTextSharp

---

## 🛠️ Technologies Used

- **C# .NET Windows Forms**
- **SQL Server**
- **ADO.NET**
- **WinForms DataVisualization Charts**
- **iTextSharp PDF Library**

---

## 📦 NuGet Packages Used

```bash
Microsoft.Data.SqlClient
WinForms.DataVisualization
iTextSharp
````

---

## 🗄️ Database

The project uses **SQL Server** database connectivity with:

* `ExpenseTbl`
* `IncomeTbl`
* `ExpenseCategoryTbl`
* `IncomeCategoryTbl`

Connection string is configured inside:

```csharp
App.config
```

---

## ⚙️ Setup Instructions

### 1️⃣ Clone Repository

```bash
git clone vivaank21/Expense-Management-System
```

### 2️⃣ Open Project

Open solution file in Visual Studio:

```bash
connectivity.slnx
```

### 3️⃣ Configure Database

Update your SQL Server connection string inside:

```xml
<connectionStrings>
   <add name="Mycon"
        connectionString="YOUR_CONNECTION_STRING"/>
</connectionStrings>
```

### 4️⃣ Run Project

Press:

```bash
F5
```

or click:

```bash
Start Debugging
```

---

## 📂 Project Structure

```bash
connectivity/
│
├── Dashboard.cs
├── Expense.cs
├── Icome.cs
├── Report.cs
├── Chart.cs
├── DBConnection.cs
├── CustomMessageBox.cs
├── App.config
└── connectivity.csproj
```

---

## 📸 Main Functionalities

* Income Entry
* Expense Entry
* Data Reports
* PDF Generation
* Expense Analytics
* Financial Dashboard

---

---
## 📝 Documentation
* DataFlowDiagram
* Entity-Relational Diagram
* Data Dictionary
* Test-Case

  In Documentation Folder...
---

## 🎯 Future Improvements

* User Authentication
* Dark Mode UI
* Monthly Budget Goals
* Excel Export
* Cloud Database Integration
* Advanced Financial Insights

---

## 👨‍💻 Developer

Developed using C# .NET Windows Forms for learning and practical financial management purposes.

---

## 📜 License

This project is open-source and available for educational purposes.

## Note

This is a basic C# .net window based project for basic connectivity purpose
