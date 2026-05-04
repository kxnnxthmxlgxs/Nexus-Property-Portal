# Nexus Property Portal
### **AI-Powered Real Estate Analytics**

The **Nexus Property Portal** is a production-ready .NET 10 web application that integrates SQL Server data persistence with Machine Learning logic. It is designed to provide real-time market valuations and portfolio insights for property investors and managers.

## 🚀 System Overview
<img width="1347" height="637" alt="HomePage" src="https://github.com/user-attachments/assets/ac523184-e01d-4bc4-ae4b-e8667466d756" />
*Figure 1: High-level system overview showing the integration of the Data Tier, AI Inference engine, and Full-Stack architecture.*

## ✨ Core Features

### **1. AI-Driven Market Valuation**
The system features a custom `PricePredictionService` that calculates a property's estimated market value based on its physical attributes. The application provides immediate visual feedback through "Good Value" badges when a property is priced below the AI estimate.

![Property Inventory and AI Estimates](images/inventory.png)
*Figure 2: The Property Inventory dashboard showing total portfolio value and AI-calculated market estimates.*

### **2. Deep Dive Analytics**
Users can view a detailed breakdown of how a property compares to the average market price in its specific suburb.

![Property Analysis View](images/analysis.png)
*Figure 3: Detailed suburb-level market analysis for specific listings.*

### **3. Comprehensive Property Management (CRUD)**
A secure, streamlined interface for managing the property lifecycle, from registration to data cleanup.

![Registration and Editing](images/registration_edit.png)
*Figure 4: Secure forms for registering new properties and modifying existing records with data validation.*

![Deletion Confirmation](images/delete.png)
*Figure 5: Safety-first deletion workflow to protect the integrity of the AI training dataset.*

## 🛠️ Technical Stack
*   **Framework:** .NET 10 (ASP.NET Core MVC)
*   **Database:** Microsoft SQL Server
*   **Logic:** Custom Linear Regression (v1.0)
*   **Styling:** Bootstrap 5 with custom CSS for "Nexus AI" branding.
*   **Hardware Target:** Optimized for high-speed performance on standard local development environments (8GB RAM / i3 10th Gen).

## 🧠 Key Development Achievements
*   **Type-Safe Precision:** Resolved critical type-mismatch constraints between SQL `decimal` financial data and ML-driven `double` calculations.
*   **Responsive Dashboarding:** Built a dynamic UI that calculates portfolio totals and averages in real-time.
*   **Branding & UX:** Established a cohesive brand identity for **Nexus Sync Solutions** throughout the application.

---

**Developed by Kenneth Malgas**  
*Founder of Nexus Sync Solutions | IT Graduate*

---

## 📸 Project Gallery

### **Main Dashboard**
![Home Page](OPM401Project/images/HomePage.png)

### **Property Inventory & AI Analytics**
![Inventory](OPM401Project/images/Inventory.png)

### **Search & Filtering**
![Inventory with Filter](images/Inventory with Filter.png)

### **Detailed Analysis**
![Property Details](images/Property details .png)

### **Property Management (CRUD)**
![Register New](images/Register new property.png)
![Edit Property](images/Edit property .png)
![Delete Property](images/Delete property.png)
