# Nexus Property Portal
### **AI-Driven Real Estate Analytics System**

A full-stack .NET 10 web application featuring a custom AI price prediction engine specifically tuned for the **Gqeberha (Port Elizabeth)** property market.

## 🚀 Executive Summary
The **Nexus Property Portal** bridges the gap between static real estate listings and data-driven market insights. By utilizing a custom **Linear Regression service**, the application identifies whether properties are "Good Value" or "Above Market" based on physical attributes like square footage and room counts.

## 🛠️ The Tech Stack
*   **Backend:** ASP.NET MVC with .NET 10.
*   **Database:** Microsoft SQL Server with persistent storage.
*   **Logic Layer:** Custom `PricePredictionService` using weights derived from property market analysis.
*   **Hardware Optimization:** Developed and tested on an **8GB RAM i3 10th Gen Lenovo** to ensure high-performance execution on consumer-grade hardware.

## ✨ Core Features
*   **AI Value Estimation:** Real-time calculation of a property's estimated worth based on unit size and amenities.
*   **Management Dashboard:** High-level summary showing **Total Listings**, **Portfolio Value**, and **Average Property Size**.
*   **Visual Indicators:** Color-coded badges for instant market interpretation.
*   **Secure CRUD Operations:** Full management of property data with data integrity at the core.

## 🧠 Technical Highlights
*   **Type Safety & Precision:** Implemented strict handling of `decimal` and `double` types to ensure financial accuracy while maintaining the performance required for mathematical modeling.
*   **Service-Oriented Architecture:** Decoupled the AI math from the UI by utilizing Dependency Injection for the `PricePredictionService`.

## ⚙️ Installation
1.  Clone the repository.
2.  Update the connection string in `appsettings.json` to point to your local SQL Server instance.
3.  Apply Migrations: `Update-Database` in the Package Manager Console.
4.  Build and run in **Visual Studio 2026**.

---

**Developed by Kenneth Malgas**  
*Founder of Nexus Sync Solutions | IT Graduate*
