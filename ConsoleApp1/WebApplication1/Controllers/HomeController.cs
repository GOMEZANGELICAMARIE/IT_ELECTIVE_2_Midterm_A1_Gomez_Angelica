using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            ViewData["Welcome"] = "Welcome to my Portfolio!";
            ViewData["Name"] = "Hello, Angelica Marie";
            ViewData["Description"] =
                "Hello! My name is Angelica Marie J. Gomez, currently a 3rd-year college student taking a Bachelor of Science in Information Technology. " +
                "Being an IT student, I enjoy web development and system analysis and design. I prioritize flexibility in the IT field because I believe it is crucial to solving practical problems.";
            return View();
        }


        public IActionResult About()
        {
            ViewData["Title"] = "About";
            ViewData["Biography & Goals"] =
                "I am Angelica Marie J. Gomez currently pursuing a Bachelor of Science in Information Technology and have developed a passion for programming and web development. I enjoy learning new technologies, solving problems, and creating applications that improve efficiency and make everyday tasks easier.";
            return View();
        }

        public IActionResult Skills()
        {
            ViewData["Title"] = "Skills";
            ViewData["Languages"] = "Vb.Net Programming, C#, Java, Python, SQL, HTML";
            ViewData["Framework"] = "ASP.NET Core MVC, Bootstrap 5, REST API";
            ViewData["Database"] = "MS SQL Server, Entity Framework Core";
            ViewData["Developer Tools"] = "Visual Studio, Git, GitHub, Pycharm";
            return View();
        }
        public IActionResult Projects()
        {
            ViewData["Title"] = "Projects";
            ViewData["Project 1"] = "Loan Calculator System";
            ViewData["Project 2"] = "Student Registration System";
            ViewData["Project 2"] = "ATM System";
            return View();
        }
        public IActionResult Contacts()
        {
            ViewData["Title"] = "Contact";
            ViewData["Email"] = "angelicamariegomez1@gmail.com";
            ViewData["Mobile Number"] = "+63 (123) 456-7890";
            ViewData["Github"] = "https://github.com/GOMEZANGELICAMARIE";
            ViewData["LinkedIn"] = "https://www.linkedin.com/in/angelica-marie-gomez";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}