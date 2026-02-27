# DMS Project

## 📌 Overview
The **DMS (Data Management System)** project is a modular ASP.NET Core solution designed for secure, scalable, and maintainable enterprise applications. It leverages **Entity Framework Core**, **ASP.NET Core Identity**, and **Blazor Fluent UI** for a modern, user-friendly experience.

---

## 🔐 Security Architecture
- **Authentication**
  - ASP.NET Core Identity with `ApplicationUser`
  - JWT bearer tokens for API endpoints
  - Role-based access control (RBAC)

- **Authorization**
  - Claims-based policies (e.g., `CanEditPerson`, `IsAdmin`)
  - Conditional rendering in Blazor UI based on roles

- **Data Protection**
  - HTTPS enforced
  - Audit fields (`CreatedDate`, `ModifiedDate`, `CreatedBy`)
  - Optional encryption for sensitive fields (ID numbers, medical aid info)

- **API Security**
  - Rate limiting and IP filtering
  - CORS restricted to trusted domains
  - Swagger secured with OAuth2 flow

---

## 🧱 Project Structure
The solution follows **Clean Architecture** principles:
