# 🎬 MovieReviewSite 🍿

🌟 **MovieReviewSite** is a full-featured ASP.NET Core MVC web application for movie enthusiasts to browse, review, and rate movies. The platform supports user authentication, role-based access control, and a responsive, modern UI built with Bootstrap. Admins can manage movies and reviews, while regular users can write reviews and view trending films. 🎥✨

---

## 📁 Folder Structure
```text
MovieReviewSite/
├─ Controllers/        # Handles application logic and routing
├─ Data/               # Database context and migrations
├─ Migrations/         # EF Core migrations
├─ Models/             # C# model classes
├─ Views/              # Razor views for UI
├─ wwwroot/            # Static files (CSS, JS, images)
├─ Properties/         # Project properties and settings
├─ obj/                # Temporary object files (auto-generated)
├─ bin/                # Compiled binaries
├─ appsettings.json    # Application configuration
├─ appsettings.Development.json # Development-specific settings
├─ MovieReviewSite.sln  # Solution file
├─ MovieReviewSite.csproj # Project file
├─ Program.cs          # Entry point of the application
└─ LICENSE             # Project license
```

---


## 🚀 **Features**

- 🔑 **User Authentication**: Secure registration and login with ASP.NET Identity.
- 👥 **Role-Based Access**: Admin and User roles with different access privileges.
- 🎞 **Movie Management**: CRUD operations for movies (title, genre, release date, description, poster).
- ⭐ **Review System**: Users can add, view, and delete reviews with ratings.
- 📊 **Dashboard Views**: Separate dashboards for Admins and Users.
- 🔥 **Trending Movies Section**: Highlights the top movies on the homepage.
- 📱 **Responsive UI**: Built with Bootstrap 5, FontAwesome icons, and modern design patterns.
- ✉️ **Contact Form**: Users can submit messages directly via the website.
- 🌗 **Theme Toggle**: Light/dark mode switch for improved user experience.

---

## 🛠 **Technologies Used**

- 💻 **Backend**: ASP.NET Core MVC, Entity Framework Core
- 🔐 **Authentication**: ASP.NET Identity
- 🎨 **Frontend**: Bootstrap 5, FontAwesome, jQuery
- 🗄 **Database**: SQL Server / SQLite
- ✅ **Validation**: jQuery Validation & Unobtrusive Validation

---

## ⚡ **Setup Instructions**

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/MovieReviewSite.git
   ```
2. **Navigate to the project folder**
   ```bash
   cd MovieReviewSite
   ```
3. **Configure the database connection**
   - Open appsettings.json
   - Update the ConnectionStrings:DefaultConnection to match your SQL Server or SQLite configuration.
4. **Apply migrations**
   ```bash
   dotnet ef database update
   ```
5. **Run the application**
   ```bash
   dotnet run
   ```
6. **Access the application**
   - Open a browser and navigate to: https://localhost:5001

---

## 📸 **Screenshots**

<img width="1365" height="609" alt="home" src="https://github.com/user-attachments/assets/8bde2ca2-444b-423f-8bd1-f4344bb6d02b" />
Figure 1: Home page displaying the welcome section and trending movies.


<img width="969" height="605" alt="trend" src="https://github.com/user-attachments/assets/4121bc6e-9454-4555-b9d4-df5d4818f7b8" />
Figure 2 : List of trending movies with details and navigation.


<img width="1358" height="267" alt="ready" src="https://github.com/user-attachments/assets/b83085fd-fb90-4f4b-90cb-5b85457e4c6e" />
Figure 3 : Users can create an account to view movie details and add reviews.


<img width="888" height="608" alt="reg" src="https://github.com/user-attachments/assets/b3a64a88-8f4b-4df1-93b3-df7fc727d77f" />
Figure 4 : Registration page for new users.


<img width="1154" height="539" alt="login" src="https://github.com/user-attachments/assets/aeaea8f3-34ef-415a-a478-7fd574257129" />
Figure 5 : Login page for existing users.


<img width="1256" height="612" alt="all" src="https://github.com/user-attachments/assets/a43070a4-653a-43f9-9b20-fa92449f3851" />
Figure 6 : Admin dashboard showing options to create, edit, view, and delete movies.


<img width="1220" height="597" alt="addmovie" src="https://github.com/user-attachments/assets/c10cd85b-f4d1-4260-b2cd-dc42443e0e70" />
Figure 7 : Admin can add a new movie with details like title, genre, and poster.


<img width="1183" height="603" alt="editmovie" src="https://github.com/user-attachments/assets/9de84d9c-97d4-48b4-9559-550a645dd7ec" />
Figure 8 : Admin can edit existing movie details.


<img width="1178" height="537" alt="addreview" src="https://github.com/user-attachments/assets/c5f83bc9-6a36-4d29-ae8c-53e4ecf2db88" />
Figure 9 : Users can add reviews for movies including rating and comments.


<img width="1182" height="370" alt="reviews" src="https://github.com/user-attachments/assets/cc357616-80d2-4501-ae5c-c1ed0bb48f33" />
Figure 10 : Admin view of all reviews submitted by users.


<img width="1246" height="538" alt="pro" src="https://github.com/user-attachments/assets/6872a45b-ecc7-4c6a-97ff-94e511b9a489" />
Figure 11 : User profile page displaying personal details.


<img width="1086" height="550" alt="contact" src="https://github.com/user-attachments/assets/f862700e-5e0e-4e8a-a4ac-a62cfcfa6c79" />
Figure 12 : Contact form page for users to send messages or inquiries.

---

## 📝 **License**
This project is licensed under the MIT License 🔓.
