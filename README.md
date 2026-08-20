# 🛒 Shop Management System

A full-featured Shop Management System built with **C#**, **.NET**, **ASP.NET Web API**, and **Microsoft SQL Server**.

The system is designed to manage shop operations including users, inventory, sales, stock quantities, permissions, and buyer lists through a dedicated client application communicating with a server-side RESTful API.

---

## 📌 Overview

The **Shop Management System** is a complete client-server application designed for small to medium-sized shops.

The project focuses on applying real-world software engineering principles such as:

- Layered architecture
- RESTful API development
- Database transactions
- Stored procedures
- DTO-based communication
- Role-based authorization
- Input validation
- Exception handling
- Asynchronous API communication
- Pagination
- Separation of responsibilities

The project contains approximately **15,000 lines of source code** across the client, server, and database components.

---

# ✨ Features

## 👥 User Management

- Add new users
- Update users
- Delete users
- Search users
- Manage user roles
- Activate/deactivate users
- Role-based permissions
- User validation
- User-related error handling

---

## 📦 Stock Management

- Add new stocks
- Update stock information
- Search stocks
- Manage stock quantities
- Track stock prices and costs
- Prevent invalid quantities
- Validate stock availability
- Automatically update stock quantities after sales

---

## 🛍️ Sales Management

- Create new sales
- Add multiple products to a sale
- Update sale details
- Remove sale items
- Calculate total sale cost
- Automatically update stock quantities
- Prevent duplicate products inside the same buyer list
- Validate available stock quantity
- Transactional sale operations

---

## 🔐 Permission System

The system contains a role-based permission system.

Different roles have different capabilities within the application.

Example operations include:

- Show Users
- Add Users
- Update Users
- Show Stocks
- Add Stocks
- Update Stocks
- Show Sales
- Add Sales
- Update Sales

Unauthorized operations are blocked at the client level and validated through the business logic.

---

# 🏗️ Architecture

The project follows a layered client-server architecture.

```text
                    ┌───────────────────────┐
                    │     Client App        │
                    │      WinForms         │
                    └───────────┬───────────┘
                                │
                                │ HTTP / JSON
                                ▼
                    ┌───────────────────────┐
                    │      ASP.NET API      │
                    │       Controllers     │
                    └───────────┬───────────┘
                                │
                                ▼
                    ┌───────────────────────┐
                    │    Business Layer     │
                    │  Validation / Logic   │
                    └───────────┬───────────┘
                                │
                                ▼
                    ┌───────────────────────┐
                    │     Data Access       │
                    │       ADO.NET         │
                    └───────────┬───────────┘
                                │
                                ▼
                    ┌───────────────────────┐
                    │     SQL Server        │
                    │ Tables / Procedures   │
                    └───────────────────────┘
