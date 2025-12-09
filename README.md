# Sharp Tasks

**Course:** .NET Architecture & Development \
**Institution:** EHEI Oujda \
**Year:** 4th Year Software Engineering

## Project Overview
Sharp Tasks is a straightforward Task Management application built with **ASP.NET Core MVC**. 

The primary goal of this project is to demonstrate a solid understanding of the **MVC Design Pattern**, **Web State Management**, and **Authentication** without unnecessary complexity or over-engineering while upholding the SOLID principles.

### Key Features demonstrated
* **CRUD Operations:** Complete Create, Read, Update, Delete lifecycle for Tasks.
* **Authentication & Authorization:** User registration and login protection for task management.
* **State Management:**
  * **Cookies:** Used to persist user preferences (e.g., **Dark Theme** toggle).
  * **Sessions:** Used for temporary user data storage during the workflow.
* **Action Filters:** Custom logic applied to controller actions for validation and logging.

---

## Getting Started

### Prerequisites
* [.NET 9.0 SDK](https://dotnet.microsoft.com/download)

### Installation

1.  **Clone and Enter:**
    ```bash
    git clone [https://github.com/Kaiounet/sharp-tasks.git](https://github.com/Kaiounet/sharp-tasks.git)
    cd sharp-tasks
    ```

2.  **Run:**
    ```bash
    dotnet run
    ```