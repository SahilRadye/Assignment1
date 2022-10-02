using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemoApp_WGS.Models;

namespace MVCDemoApp_WGS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }

        //take id value from user and print same on view
        public ActionResult GetData(int? id)
        {
            ViewBag.msg = "Data = " + id;
            return View();  
        }

        //Conventional Routing
        //routes.MapRoute(
        //        name: "Default",
        //        url: "{controller}/{action}/{id}",
        //        defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional


        //Attribute Base Routing
        //url: "{controller}/{action}/{id}"
        [Route("home/Greet/{name?}")]
        public ActionResult Greet(string name)
        {
            ViewBag.msg = "Hello , " + name;
            return View();
        }

        //Attribute Base Routing
        [Route("home/AddNumbers/{num1?}/{num2?}")]
        public ActionResult AddNumbers(int? num1 , int? num2)
        {
            ViewBag.sum = "Addition = " + (num1 + num2);
            return View();
        }


        public ActionResult ModelDemo()
        {
            Employee employee = new Employee { EmpId = 101 , EmpName = "Sahil" , Salary = 27000};
            ViewBag.employee = employee;
            return View();  
        }

        public ActionResult EmployeeForm()
        {
            Employee employee = new Employee();
            return View();
        }

        public ActionResult DisplayEmployee(Employee employee)
        {

            if (ModelState.IsValid)
            {
                return View(employee);
            }
            return View("EmployeeForm", employee);
        }

        public ActionResult UserForm()
        {          
            return View();           
        }

        public ActionResult CheckingUser(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.UserName == "admin" && user.Password == "123")
                {
                    return RedirectToAction("EmployeeForm", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "INVALID USER");
                }
            }                   
            return View("UserForm", user);
        }

        public ActionResult StudentDetails()
        {
            return View();
        }

        public ActionResult StudentFeedback(Student student)
        {
            if (ModelState.IsValid)
            {
                ViewBag.msg = "Thanks " + student.StudentName + " for Sharing Feedback";
                return View();
            }
            
            return View("StudentDetails", student);
        }
    }
}