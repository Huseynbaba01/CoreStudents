using Microsoft.AspNetCore.Mvc;
using StudentsApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentsApplication.Controllers
{
    public class HomeController : Controller
    {
       

        public static List<Student> students = new List<Student> { };
        /*[HttpGet]
        public async Task<IActionResult> Get()
        {
            var user = new User
            {
                Password = "111111",
                Username = "User"
            };

            return Ok(user);
        }
        */

        /*    We don't allow user access main page without logging in:)  
              public IActionResult Main()
                {

                    MPDContext db = new();
                    ViewBag.students = db.Students.ToList<Student>();
                    return View();
                    return View();
                }*/


        [HttpPost]
        public IActionResult Main(string USERNAME, string PASSWORD)
        {
            MPDContext db = new();
            bool isUser = false;
            foreach(User u in db.Users)
            {
                if(u.Username.Equals(USERNAME) && u.Password.Equals(PASSWORD))
                {
                    isUser = true;
                    break;
                }
            }
            if (isUser){
                ViewBag.students = db.Students.ToList<Student>();
                return View();
            } 
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(string NAME, string SURNAME, string DEGREE)
        {
            MPDContext db = new();
            db.Students.Add(new Student { Degree = DEGREE, Name = NAME, Surname = SURNAME});
            db.SaveChanges();
            return View();
        }

        [HttpPost]
        public IActionResult Login(string USERNAME, string PASSWORD)
        {
            MPDContext db = new();
            db.Users.Add(new User { Password = PASSWORD, Username = USERNAME });
            db.SaveChanges();
            HttpContext.Response.Cookies.Append("username", USERNAME);
            HttpContext.Response.Cookies.Append("password", PASSWORD);
            db.Users.Add(new User
            {
                Password = "cookie " + HttpContext.Request.Cookies["password"],
                Username = "cookie " + HttpContext.Request.Cookies["username"]
            });

            db.SaveChanges();
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
