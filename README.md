# Blazor Products Management

This project is a Blazor application for managing products. Users can display, add, update, and delete products through a custom API.

## Features

- Display products
- Add a product
- Update a product
- Delete a product

## Technologies Used

- Blazor WebAssembly
- .NET 8
- Custom RESTful API (ASP.NET Core Web API)
- Entity Framework Core
- SQL Server

## Getting Started

### Prerequisites

- .NET 8 SDK
- Visual Studio 2022 or Visual Studio Code
- SQL Server

### Setup Instructions

1. **Clone the Repository:**

    ```bash
    git clone (https://github.com/Shadi201711/Blazor-ITI-Lab)
    cd Blazor-ITI-Lab
    ```

2. **API Setup:**

    - Navigate to the `Api` folder.
    - Update `appsettings.json` with your database connection string.
    - Run database migrations:

      ```bash
      dotnet ef database update
      ```

    - Start the API:

      ```bash
      dotnet run
      ```

3. **Blazor App Setup:**

    - Navigate to the `Client` folder.
    - Update the API base URL in `Program.cs`.
    - Start the Blazor app:

      ```bash
      dotnet run
      ```

4. **Running the Application:**

    - Open `https://localhost:5001` in your browser.

## Usage

### Display Products

- View the list of products on the home page.

### Add a Product

- Click "Add Product", fill in the form, and click "Save".

### Update a Product

- Click "Edit" next to a product, modify the details, and click "Save".

### Delete a Product

- Click "Delete" next to a product and confirm the deletion.

## API Endpoints

- `GET /api/products` - Retrieve all products
- `GET /api/products/{id}` - Retrieve a product by ID
- `POST /api/products` - Add a new product
- `PUT /api/products/{id}` - Update a product
- `DELETE /api/products/{id}` - Delete a product


