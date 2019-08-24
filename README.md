# ITRW324Project2-MVC-
Same as ITRW324Project2 but using MVC

NuGet Packages:
-EntityFramework
-Microsoft.AspNetCore.App
-Microsoft.AspNetCore.Razor.Design
-Microsoft.NETCore.App
-Microsoft.VisualStudio.Web.CodeGeneration.Design
-MySql.Data.Entity
-MySql.Data.EntityFrameworkCore

How to add a View and display it:
1. Go to Views, right click and add View under Home
2. Go to Controllers -> HomeController

3.   Add code:
     public IActionResult *Example*() //Return *Example* View
        {
            return View();
        }

4. Go to Views -> Shared -> _Layout.cshtml

5. in <body>...<div class="navbar...">...</div>...</body> add:
           <li class="nav-item">
               <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="*Example*">*Example*</a>
           </li>

How to add a View connected to db"
1. Go to Views, right click and add View under Home
2. Go to Controllers -> HomeController

3. Add code:

        public IActionResult *Example*() //Return User Table in DB to Example
        {
            var result = _context.User.ToList();
            return View(result);
        }

4. Go to Views -> Shared -> _Layout.cshtml

5. in <body>...<div class="navbar...">...</div>...</body> add:
           <li class="nav-item">
               <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="*Example*">*Example*</a>
           </li>

6. Go Startup.cs at the bottom where app.UseMvc(routes => ) is found
7. Add route:
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=*Example*}/{id?}");
