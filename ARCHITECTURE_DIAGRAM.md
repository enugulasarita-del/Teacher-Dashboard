# Architecture Diagram - VSIT Teacher Dashboard

## Application Flow

```
┌─────────────────────────────────────────────────────────────────┐
│                         Program.cs                              │
│                    Application Entry Point                      │
└────────────────────────────┬────────────────────────────────────┘
                             │
                             ▼
┌─────────────────────────────────────────────────────────────────┐
│                        LoginForm                                │
│  ┌──────────────────────────────────────────────────────────┐  │
│  │  Username: [____________]                                │  │
│  │  Password: [____________]                                │  │
│  │  [Login] [Cancel]                                        │  │
│  └──────────────────────────────────────────────────────────┘  │
└────────────────────────────┬────────────────────────────────────┘
                             │
                             ▼
                      ┌──────────────┐
                      │ UserService  │
                      │ Authenticate │
                      └──────┬───────┘
                             │
                ┌────────────┴────────────┐
                │                         │
                ▼                         ▼
          Valid User              Invalid User
                │                         │
                ▼                         ▼
      SessionManager.CurrentUser    Error Message
                │                    Return to Login
                ▼
┌─────────────────────────────────────────────────────────────────┐
│                   MainDashboardForm                             │
│  ┌──────────────────────────────────────────────────────────┐  │
│  │  Sidebar Menu (Role-Based)                               │  │
│  │  ┌────────────────────────────────────────────────────┐  │  │
│  │  │  🏠 Home                                           │  │  │
│  │  │  📅 Timetable                                      │  │  │
│  │  │  📢 Notices                                        │  │  │
│  │  │  🎥 VAC Lectures                                   │  │  │
│  │  │  ⚙️ Settings                                       │  │  │
│  │  │  📚 Course Management                              │  │  │
│  │  │  📝 Assignment Management                          │  │  │
│  │  │  🎓 Grading System                                 │  │  │
│  │  │  ✅ Daily Attendance                               │  │  │
│  │  │  📈 Reports & Analytics                            │  │  │
│  │  │  📊 Student Performance                            │  │  │
│  │  │  📚 Resource Library                               │  │  │
│  │  │  📖 Student Directory                              │  │  │
│  │  │  📋 My Tasks                                       │  │  │
│  │  │  ─────────────────────────────────────────────     │  │  │
│  │  │  🔐 Admin Panel (Admin Only)                       │  │  │
│  │  │  👥 User Management (Admin Only)                   │  │  │
│  │  │  ⚙️ System Settings (Admin Only)                   │  │  │
│  │  │  ─────────────────────────────────────────────     │  │  │
│  │  │  🚪 Logout                                         │  │  │
│  │  └────────────────────────────────────────────────────┘  │  │
│  └──────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────┘
                             │
                             │ Click Menu Item
                             ▼
        ┌────────────────────────────────────────┐
        │     Individual Feature Forms           │
        ├────────────────────────────────────────┤
        │  • HomeForm                            │
        │  • TimetableForm                       │
        │  • NoticesForm                         │
        │  • VacLecturesForm                     │
        │  • CourseManagementForm                │
        │  • AssignmentManagementForm            │
        │  • GradingSystemForm                   │
        │  • AttendanceForm                      │
        │  • ReportsForm                         │
        │  • StudentPerformanceForm              │
        │  • ResourceLibraryForm                 │
        │  • StudentDirectoryForm                │
        │  • TasksForm                           │
        │  • SettingsForm                        │
        │  ─────────────────────────────────     │
        │  • AdminPanelForm (Admin Only)         │
        │  • UserManagementForm (Admin Only)     │
        │  • SystemSettingsForm (Admin Only)     │
        └────────────────────────────────────────┘
```

## Role-Based Access Control

```
┌─────────────────────────────────────────────────────────────────┐
│                      SessionManager                             │
│  ┌──────────────────────────────────────────────────────────┐  │
│  │  CurrentUser: User                                       │  │
│  │  IsLoggedIn: bool                                        │  │
│  │  IsAdmin: bool                                           │  │
│  │  IsTeacher: bool                                         │  │
│  │  IsStudent: bool                                         │  │
│  └──────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────┘
                             │
                ┌────────────┼────────────┐
                │            │            │
                ▼            ▼            ▼
         ┌──────────┐  ┌──────────┐  ┌──────────┐
         │  Admin   │  │ Teacher  │  │ Student  │
         └────┬─────┘  └────┬─────┘  └────┬─────┘
              │             │             │
              ▼             ▼             ▼
    ┌─────────────────┐ ┌──────────┐ ┌──────────┐
    │ All Features    │ │ Teaching │ │ View     │
    │ + Admin Panel   │ │ Features │ │ Only     │
    │ + User Mgmt     │ │          │ │          │
    │ + System Config │ │          │ │          │
    └─────────────────┘ └──────────┘ └──────────┘
```

## Data Flow - User Management

```
┌─────────────────────────────────────────────────────────────────┐
│                   UserManagementForm                            │
│  ┌──────────────────────────────────────────────────────────┐  │
│  │  [Add] [Edit] [Delete] [Refresh]                         │  │
│  │  Search: [________]  Filter: [All Roles ▼]              │  │
│  │  ┌────────────────────────────────────────────────────┐  │  │
│  │  │ ID │ Username │ Name │ Email │ Role │ Status │...  │  │  │
│  │  ├────┼──────────┼──────┼───────┼──────┼────────┼────┤  │  │
│  │  │ 1  │ admin    │ ...  │ ...   │Admin │Active  │... │  │  │
│  │  │ 2  │ teacher  │ ...  │ ...   │Teach │Active  │... │  │  │
│  │  │ 3  │ student  │ ...  │ ...   │Stud  │Active  │... │  │  │
│  │  └────────────────────────────────────────────────────┘  │  │
│  └──────────────────────────────────────────────────────────┘  │
└────────────────────────────┬────────────────────────────────────┘
                             │
                             ▼
                      ┌──────────────┐
                      │ UserService  │
                      ├──────────────┤
                      │ GetAllUsers()│
                      │ AddUser()    │
                      │ UpdateUser() │
                      │ DeleteUser() │
                      │ GetByRole()  │
                      └──────┬───────┘
                             │
                             ▼
                    ┌─────────────────┐
                    │  In-Memory List │
                    │  List<User>     │
                    └─────────────────┘
```

## Component Relationships

```
┌─────────────────────────────────────────────────────────────────┐
│                         Models Layer                            │
│  ┌──────────────────────────────────────────────────────────┐  │
│  │  User                                                    │  │
│  │  - Id, Username, Password, FullName, Email              │  │
│  │  - Role (Admin/Teacher/Student)                         │  │
│  │  - IsActive, CreatedDate, LastLoginDate                 │  │
│  └──────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────┘
                             │
                             ▼
┌─────────────────────────────────────────────────────────────────┐
│                       Services Layer                            │
│  ┌──────────────────────────────────────────────────────────┐  │
│  │  UserService                                             │  │
│  │  - Authenticate(), GetAllUsers(), AddUser()             │  │
│  │  - UpdateUser(), DeleteUser(), GetUsersByRole()         │  │
│  └──────────────────────────────────────────────────────────┘  │
│  ┌──────────────────────────────────────────────────────────┐  │
│  │  SessionManager (Static)                                 │  │
│  │  - CurrentUser, IsLoggedIn, IsAdmin, IsTeacher          │  │
│  │  - IsStudent, Logout()                                   │  │
│  └──────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────┘
                             │
                             ▼
┌─────────────────────────────────────────────────────────────────┐
│                    Presentation Layer (Forms)                   │
│  ┌──────────────────────────────────────────────────────────┐  │
│  │  Authentication Forms                                    │  │
│  │  - LoginForm                                             │  │
│  │  - MainDashboardForm                                     │  │
│  └──────────────────────────────────────────────────────────┘  │
│  ┌──────────────────────────────────────────────────────────┐  │
│  │  Admin Forms                                             │  │
│  │  - AdminPanelForm                                        │  │
│  │  - UserManagementForm                                    │  │
│  │  - UserEditForm                                          │  │
│  │  - SystemSettingsForm                                    │  │
│  └──────────────────────────────────────────────────────────┘  │
│  ┌──────────────────────────────────────────────────────────┐  │
│  │  Feature Forms                                           │  │
│  │  - HomeForm, TimetableForm, NoticesForm, etc.           │  │
│  └──────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────┘
```

## Session Lifecycle

```
Application Start
      │
      ▼
LoginForm Displayed
      │
      ▼
User Enters Credentials
      │
      ▼
UserService.Authenticate()
      │
      ├─── Valid ────► SessionManager.CurrentUser = user
      │                        │
      │                        ▼
      │               MainDashboardForm Opens
      │                        │
      │                        ▼
      │               User Interacts with Features
      │                        │
      │                        ▼
      │               User Clicks Logout
      │                        │
      │                        ▼
      │               SessionManager.Logout()
      │                        │
      │                        ▼
      │               Return to LoginForm
      │
      └─── Invalid ──► Error Message
                              │
                              ▼
                       Return to LoginForm
```

## Menu Visibility Logic

```
MainDashboardForm.ConfigureMenuBasedOnRole()
                │
                ▼
        Check SessionManager.CurrentUser.Role
                │
    ┌───────────┼───────────┐
    │           │           │
    ▼           ▼           ▼
  Admin      Teacher     Student
    │           │           │
    ▼           ▼           ▼
Show All    Show Teaching  Show Limited
Features    Features       Features
    │           │           │
    ├─ Admin Panel (✓)     │
    ├─ User Mgmt (✓)       │
    ├─ System Settings (✓) │
    │           │           │
    └─ All Teaching Features
                │           │
                └─ Teaching Features
                            │
                            └─ View-Only Features
```

---

**Legend:**
- ✅ = Implemented
- ⚠️ = Needs Work
- 🔐 = Admin Only
- 📝 = Teacher Feature
- 👁️ = Student View-Only
