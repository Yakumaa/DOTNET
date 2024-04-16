using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using MVC.Models;//to access controller

namespace MVC.Controllers
{
    //controller is used to handle all the incoming http request.
    //it contains group of action method (such method returns view)
    //which handles the incoming request. for each controller there should be 
    //folder in view and for each action method there be file of view.
    //to access controlller from url tab: domain/controller/actionmethod
    //if a class is to be contrller then it should inherit superclass controller
    //in C# controller is a C# class

    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            //accessing model
            Student s1 = new Student()
            {
                Id = 1,
                Name = "Test",
                Gender = "male",
                Faculty = "csit",
                Grade = "C"
            };
            return View(s1);
        }
        public string printDetail()
        {
            return "hello csit 6th";
        }
        public string printData(string name, string id)
        {
            return $"person having id {id} is {name}";
        }
    }
}
