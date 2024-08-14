# Araratian Apex Solutions
My name is Sausoon Abedian. I'm a back-end developer looking to start my front-end journey to become a full-stack developer. I need some projects to enrich my resume, so this repository contains my business website. 

## Leet Code Tracker
This project enables users to track their progress on each LeetCode question, score each attempt, organize questions into one or more groups, and add tags to each question. Additional features will be added later.

### Phase 1
The bare minimum for achiving the operations in one world skeleton of the application.

#### Requirements
1. User should be able to insert, delete and update questions.
2. User should be able to define groups and subgroups for example: Neetcode have categories for grouping questions and Neetcode can be a main group while the categories can be subgroups.
3. User should be able to define tags globally or for each group or subgroup.
4. User should be able to add scoring system globally or for each group such as defining conditions for earning the score.
5. User should be able to insert, delete and update the attempt to solve a question for specific programming language.
6. User should be able to enter the written code for each attempt in a code component or somthing like that.
7. User should be able to analize the performance of each question group or subgroup or global tag or group tag.

#### Architecture
1. Client-Side: Blazor WebAssembly
    1. Blazor WebAssembly: This is a client-side web framework that allows developers to build interactive web applications using C# and .NET. The application runs entirely in the browser via WebAssembly, which allows for a rich user experience with responsive UI components.
    2. SignalR: SignalR is used for real-time web functionality. It enables server-side code to push content to the connected clients instantly, creating real-time web applications. In a Blazor WebAssembly setup, SignalR can be used for scenarios like live chat, notifications, or real-time updates.
2. Server-Side: ASP.NET Core with Entity Framework
    1. ASP.NET Core API: The backend of the application is typically built using ASP.NET Core. This API serves the Blazor WebAssembly client and handles HTTP requests, business logic, and data management.
    2. SignalR Hub: SignalR also has a server-side component called a Hub, which manages the connections with the client and facilitates the real-time communication.
    3. Entity Framework Core (EF Core): EF Core is used as an Object-Relational Mapper (ORM) to interact with the SQL Server database. It provides a way to work with data as strongly typed objects, and LINQ can be used to query the data.
3. Database: SQL Server
    1. SQL Server: The SQL Server database is used for persistent data storage. EF Core interacts with SQL Server to perform CRUD operations, manage relationships, and ensure data integrity.
