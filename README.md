# BARE
A simple dictionary application, which is capable of translating English words or phrases into Hungarian.

Steps -

Database: SQLite database with a Dictionary table containing English words/phrases and their Hungarian translations.
Backend: C# .NET Core API to interact with the database.
Frontend: React application for users to enter English words/phrases and retrieve Hungarian translations.

Set Up the Database -
1. Create a SQLite database with a Dictionary table containing id, english_word, and hungarian_translation fields. 
CREATE TABLE Dictionary (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    english_word TEXT NOT NULL,
    hungarian_translation TEXT NOT NULL
);
2. Add some sample data based on your attached list

Creating the .NET Core Backend -
1. Create a new ASP.NET Core Web API Project: Install the SQLite and Entity Framework Core packages:
2. Install the SQLite and Entity Framework Core packages: dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
3. Run Migrations to Create the Database: dotnet ef migrations add InitialCreate
dotnet ef database update
4. Run the Application: dotnet run


Frontend -
1. Create a New React Application : npx create-react-app dictionary-frontend
2. Install Axios for HTTP Requests : npm install axios
3. Build the Search UI in App.js
4. Start the React Application : npm start
