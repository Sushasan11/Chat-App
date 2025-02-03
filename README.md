Chat App - .NET MAUI Hybrid with SignalR
A real-time chat application built with .NET MAUI Hybrid (Blazor WebView) and ASP.NET Core using SignalR for real-time messaging.

🚀 Features
✅ Real-Time Messaging – Uses SignalR WebSockets for instant updates.
✅ Message Storage – Saves chat history in an SQLite database.
✅ Blazor Hybrid Frontend – Runs on Web, Windows, macOS, and Android.
✅ Multi-User Support – Auto-assigns a username to each user.
✅ Persisted Chat History – Fetches previous messages on login.
✅ Responsive UI – Smooth animations and mobile-friendly design.

🛠 Tech Stack
Frontend
.NET MAUI Blazor Hybrid
SignalR Client for WebSockets
Blazor Components & CSS Animations
Backend
ASP.NET Core Web API
SignalR for Real-Time Communication
Entity Framework Core with SQLite
Database
SQLite (Can be upgraded to PostgreSQL or Firebase Firestore)
📂 Project Structure
pgsql
Copy
Edit
/ChatApp
 ├── /ChatApp.Server (Backend - ASP.NET Core)
 │   ├── /Controllers (API Controllers)
 │   ├── /Data (Entity Framework Database Context)
 │   ├── /Hubs (SignalR Real-Time Messaging)
 │   ├── /Models (Database Models)
 │   ├── /Migrations (SQLite Migrations)
 │   ├── Program.cs (Main Application Entry)
 ├── /ChatApp.Client (Frontend - .NET MAUI Blazor)
 │   ├── /Pages (Blazor Pages)
 │   ├── /wwwroot/css (Frontend Styling)
 │   ├── MainPage.razor (Chat UI)
⚡️ Installation & Setup
1️⃣ Clone the Repository
sh
Copy
Edit
git clone https://github.com/your-username/ChatApp-MAUI.git
cd ChatApp-MAUI
2️⃣ Backend Setup
Navigate to Backend Folder
sh
Copy
Edit
cd ChatApp.Server
Install Dependencies
sh
Copy
Edit
dotnet restore
Run Migrations & Start Server
sh
Copy
Edit
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
The API will start at http://localhost:5001
SignalR Hub will be available at http://localhost:5001/chathub
3️⃣ Frontend Setup
Navigate to Frontend Folder
sh
Copy
Edit
cd ChatApp.Client
Install Dependencies
sh
Copy
Edit
dotnet restore
Run the .NET MAUI Blazor App
sh
Copy
Edit
dotnet build
dotnet run
📌 API Endpoints
Method	Endpoint	Description
GET	/api/chat/messages	Fetch last 50 messages
POST	/chathub	Send a real-time message
🖥️ How It Works
User opens the chat app.
A random username is assigned.
Previous chat messages are loaded from the SQLite database.
Messages sent by any user appear in real-time using SignalR.
Chat history persists even after app restart.
📦 Deployment
Backend: Deploy ASP.NET Core to Azure / AWS / DigitalOcean.
Frontend: Package MAUI app for Android, Windows, and macOS.
