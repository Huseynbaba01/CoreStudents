using Microsoft.AspNetCore.Mvc;
using StudentsApplication.Models;
using System.Collections.Generic;
using System.Linq;

// 1. Cookies niye silinmir?  2. CSS fayli nece elave etmek olar?

namespace StudentsApplication.Controllers
{

    public class HomeController : Controller
    {
       

        public static List<Student> students = new() { };
        
        /*
        [HttpGet]
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

        [Route("main")]
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

        [Route("add")]
        [HttpPost]
        public IActionResult AddStudent(string NAME, string SURNAME, string DEGREE)
        {
            MPDContext db = new();
            db.Students.Add(new Student { Degree = DEGREE, Name = NAME, Surname = SURNAME});
            db.SaveChanges();
            return View();
        }
        [Route("")]
        [Route("login")]
        [HttpPost]
        public IActionResult Login(string USERNAME, string PASSWORD)
        {
            MPDContext db = new();
            db.Users.Add(new User { Password = PASSWORD, Username = USERNAME });
            db.SaveChanges();

            //To save login data we use https cookies
            Microsoft.AspNetCore.Http.CookieOptions options = new();
            if (HttpContext.Request.Cookies.ContainsKey("username"))
            {
                HttpContext.Response.Cookies.Delete("username");
            }
            if (HttpContext.Request.Cookies.ContainsKey("password"))
            {
                HttpContext.Response.Cookies.Delete("password");
            }
            HttpContext.Response.Cookies.Append("username", USERNAME, options);
            HttpContext.Response.Cookies.Append("password", PASSWORD, options);

            //We use CookiesOptions class to add some functionalities to the cookies (add expiration date)
            options.Expires = new System.DateTimeOffset(System.DateTime.Now.AddMinutes(1));
            
            /*
            db.Users.Add(new User
            {
                Password = "cookie " + HttpContext.Request.Cookies["password"],
                Username = "cookie " + HttpContext.Request.Cookies["username"]
            });

            db.SaveChanges();
            */
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {
            if (HttpContext.Request.Cookies.ContainsKey("username") 
                && HttpContext.Request.Cookies.ContainsKey("password"))
            {
                ViewBag.LastUser = new User
                {
                    Password = HttpContext.Request.Cookies["username"],
                    Username = HttpContext.Request.Cookies["password"]
                };
            }
            return View();
        }

        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }
    }
}
