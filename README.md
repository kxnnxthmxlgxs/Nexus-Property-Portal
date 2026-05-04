# Nexus Property Portal
### **AI-Powered Real Estate Analytics**

The **Nexus Property Portal** is a production-ready .NET 10 web application that integrates SQL Server data persistence with Machine Learning logic. It is designed to provide real-time market valuations and portfolio insights for property investors and managers.

## 🚀 System Overview
<img width="1347" height="637" alt="HomePage" src="https://github.com/user-attachments/assets/ac523184-e01d-4bc4-ae4b-e8667466d756" />
*Figure 1: High-level system overview showing the integration of the Data Tier, AI Inference engine, and Full-Stack architecture.*

## ✨ Core Features

### **1. AI-Driven Market Valuation**
The system features a custom `PricePredictionService` that calculates a property's estimated market value based on its physical attributes. The application provides immediate visual feedback through "Good Value" badges when a property is priced below the AI estimate.

<img width="1343" height="638" alt="Inventory" src="https://github.com/user-attachments/assets/5e81a687-f134-4b11-93a2-369e2816478d" />
*Figure 2: The Property Inventory dashboard showing total portfolio value and AI-calculated market estimates.*

### **2. Deep Dive Analytics**
Users can view a detailed breakdown of how a property compares to the average market price in its specific suburb.

<img width="1345" height="635" alt="Property details " src="https://github.com/user-attachments/assets/91c73e1a-bc7d-4188-87c1-f6093a8def4a" />
*Figure 3: Detailed suburb-level market analysis for specific listings.*

### **3. Comprehensive Property Management (CRUD)**
A secure, streamlined interface for managing the property lifecycle, from registration to data cleanup.

<img width="1345" height="632" alt="Register new property" src="https://github.com/user-attachments/assets/ac60526c-636c-4038-b838-c38975e76fec" />
*Figure 4: Secure forms for registering new properties and modifying existing records with data validation.*

<img width="1341" height="636" alt="Delete property" src="https://github.com/user-attachments/assets/6c815fb0-d831-4c3b-8d9d-3382346827a5" />
<img width="1341" height="632" alt="Edit property " src="https://github.com/user-attachments/assets/565dc1e9-08f7-47ae-948c-f3ec1e21c18f" />
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
<img width="1347" height="637" alt="HomePage" src="https://github.com/user-attachments/assets/a9a044b6-f606-4f1b-9692-0dfd76146ff5" />

### **Property Inventory & AI Analytics**
<img width="1343" height="638" alt="Inventory" src="https://github.com/user-attachments/assets/24e7631b-392f-4b7d-8155-452569790ab1" />

### **Search & Filtering**
<img width="1340" height="630" alt="Inventory with Filter" src="https://github.com/user-attachments/assets/ee81d1a7-4334-4d74-82fb-90ea86b4f1e7" />

### **Detailed Analysis**
<img width="1345" height="635" alt="Property details " src="https://github.com/user-attachments/assets/91c73e1a-bc7d-4188-87c1-f6093a8def4a" />

### **Property Management (CRUD)**
<img width="1345" height="632" alt="Register new property" src="https://github.com/user-attachments/assets/ac60526c-636c-4038-b838-c38975e76fec" />
<img width="1341" height="632" alt="Edit property " src="https://github.com/user-attachments/assets/565dc1e9-08f7-47ae-948c-f3ec1e21c18f" />
<img width="1341" height="636" alt="Delete property" src="https://github.com/user-attachments/assets/6c815fb0-d831-4c3b-8d9d-3382346827a5" />

