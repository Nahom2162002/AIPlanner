
AIPlanner Project File Overview
===============================

Root Directory:
---------------
X - AIPlanner.sln
  > Visual Studio solution file — entry point to open the entire project.

AIPlanner/:
-----------
X - App.xaml / App.xaml.cs
  > Defines global resources (styles, themes) and initializes the app with the main page.
X - Main.razor
  > The shell for Blazor navigation and routing.
X - MauiProgram.cs
  > Configures dependency injection, fonts, and app startup logic.

Models/:
--------
X - TaskItem.cs
  > Represents a single task (title, description, due time, completion status).
X - UserPreferences.cs
  > Stores user settings like theme and OpenAI API key.

Data/:
------
X - AppDbContext.cs
  > Entity Framework Core context for working with SQLite and defining tables.
X - IRepository.cs
  > A generic interface for CRUD operations.
X - TaskRepository.cs
  > Implements IRepository for task management with EF Core.
- DbInitializer.cs
  > Ensures the database is created and optionally seeded.

Services/:
----------
- TimeBlocker.cs
  > (Placeholder) Logic for assigning times to tasks (time-blocking logic).

Services/AI/:
-------------
- ISchedulerAI.cs
  > Interface defining AI scheduling behavior.
- OpenAIScheduler.cs
  > Uses OpenAI or another LLM API to generate a daily plan.
- MockScheduler.cs
  > Dummy fallback scheduler that returns tasks as-is.

Services/Notifications/:
------------------------
- INotificationService.cs
  > Interface for scheduling user notifications.
- MauiNotificationService.cs
  > Platform-specific implementation of notifications (iOS, Android, etc).

ViewModels/:
------------
- MainViewModel.cs
  > Optional: manages global app state and routing.
- TaskViewModel.cs
  > Manages task-related logic and data binding.
- SettingsViewModel.cs
  > Manages settings like API key and theme.

Views/:
-------
- MainPage.razor
  > Shell or layout component.
- PlannerPage.razor
  > UI that displays tasks in a daily planner format.
- TaskPage.razor
  > List and manage (add/edit/delete) tasks.
- SettingsPage.razor
  > Input for OpenAI API key and user preferences.

Views/Components/:
------------------
- TaskCard.razor
  > Component that visually represents a task.
- TimeBlock.razor
  > Component that visually represents a scheduled time block.

Constants/:
-----------
- AppConstants.cs
  > Stores app-wide constants such as database names and keys.

Helpers/:
---------
- Extensions.cs
  > Extension methods for common utilities (e.g., date formatting).

Resources/Fonts/ and Resources/Images/:
---------------------------------------
> Stores fonts and images used by the app.

wwwroot/:
---------
> Static files (CSS, JS, images) for the Blazor web layer.
