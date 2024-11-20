
# Blogging Platform API
Project URL: https://github.com/Walidiss/BloggingPlatform.git
This is a simple RESTful API built with .NET Core for a personal blogging platform. The API provides basic CRUD operations for blog posts, including features to filter posts by a search term.

---

## Prerequisites

Before you begin, ensure you have the following installed on your machine:

- [.NET 9.0 or later](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) (or SQL Server LocalDB)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

---

## Getting Started

### 1. Clone the Repository

Use the following command to clone the repository:

```bash
git https://github.com/Walidiss/BloggingPlatform.git
cd BloggingPlatform
```

---

### 2. Set Up the Database

1. Open the `appsettings.json` file and configure the connection string to your SQL Server instance:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=BloggingPlatformDb;Trusted_Connection=True;"
   }
   ```

   Replace `(localdb)\\MSSQLLocalDB` with your SQL Server instance if you're not using LocalDB.

2. Run the following commands to apply the migrations and create the database:

   ```bash
   dotnet ef database update
   ```

---

### 3. Build and Run the API

1. Build the application:

   ```bash
   dotnet build
   ```

2. Run the application:

   ```bash
   dotnet run
   ```

3. By default, the API will be hosted at:  
   **http://localhost:5000**  
   **https://localhost:5001**

---

### 4. Test the Endpoints

Use a tool like [Postman](https://www.postman.com/) or [curl](https://curl.se/) to test the API.

#### Endpoints
- **Create a New Post**  
  **POST** `/blog/create`  
  **Request Body** (JSON):
  ```json
{
  "title": "My first Blog Post",
  "content": "This is the content of my first blog post.",
  "category": "Technology",
  "tags": ["Tech", "Programming"]
}
  ```

- **Get All Posts**  
  **GET** `/blog/postslist`

- **Filter Posts by Search Term**  
  **GET** `/blog/postslist`

- **Get a Single Post by ID**  
  **GET** `/blog/post/{id}`

- **Delete a Post**  
  **DELETE** `/blog/delete/{id}`

---

### 5. Running Tests

If the repository includes unit tests, you can run them using the following command:

```bash
dotnet test
```

---

## Notes

- Ensure the database server is running and accessible.
- If you encounter issues with migrations or connection strings, double-check the `appsettings.json` configuration.

---

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m 'Add new feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a pull request.

---

## License

This project is licensed under the [MIT License](LICENSE).
