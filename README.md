🧠 AI-Powered Daily Planner
A cross-platform productivity app built with .NET MAUI Blazor that uses AI to generate personalized daily schedules based on user tasks, preferences, and goals.

✨ Features
🕒 AI Scheduling Assistant: Automatically prioritizes and organizes your tasks using OpenAI's GPT-based logic.

📆 Time Blocking: Visualize and edit your day with intuitive drag-and-drop time blocks.

🔔 Reminders & Notifications: Stay on track with real-time notifications for upcoming tasks.

🧠 Task Intelligence: Suggests optimal scheduling based on urgency, time estimates, and user focus hours.

💾 Data Persistence: Stores tasks, preferences, and completions using SQLite and EF Core.

📱 Cross-Platform: Runs on Android, iOS, Windows, and macOS via .NET MAUI.

🚀 Tech Stack
Frontend: Blazor (MAUI), Razor Components, MVVM

Backend: C#, .NET MAUI

Database: SQLite with Entity Framework Core

AI Integration: OpenAI API (Chat Completions)

Architecture: Clean Architecture (Models, Services, ViewModels, Pages)


📦 Installation
Clone the repository:

git clone https://github.com/yourusername/ai-daily-planner.git
cd ai-daily-planner

Configure your OpenAI API key:

Create a appsettings.json or Secrets.json file and add:

{
  "OpenAI": {
    "ApiKey": "YOUR_OPENAI_API_KEY"
  }
}

Run the project:

In Visual Studio, choose the target platform (Android, Windows, etc.) and hit Run.

🧠 How It Works
Users input tasks with optional tags: priority, deadline, duration.

The app sends this data to the OpenAI API for intelligent scheduling.

The AI responds with a sorted, time-blocked day plan.

Users can adjust the schedule manually and receive suggestions in real-time.
