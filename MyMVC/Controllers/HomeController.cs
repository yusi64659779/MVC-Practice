using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;

namespace MyMVC.Controllers
{
    public class HomeController : Controller
    {
      
        public ViewResult Index()
        {
            return View("Homepage");
        }

        [HttpGet]
        public ViewResult StudentLoginForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult StudentLoginForm(StudentLogin students)
        {
            Repository.AddStudent(students);
            return View("Welcomepage", students);
        }
        
        public ActionResult CourseInfo()
        {
            List<CoursesInformation> listcourse = new List<CoursesInformation>();

            CoursesInformation information1 = new CoursesInformation();
            {
                information1.CourseID = "ISM6155";
                information1.CourseName = "Enterprise Info Sys Management";
                information1.Location = "BSN230";
                information1.Teacher = "Deepak Sainanee";
                information1.Time = "R 6:30PM-9:15PM";
            }
            listcourse.Add(information1);

            CoursesInformation information2 = new CoursesInformation();
            {
                information2.CourseID = "ISM6218";
                information2.CourseName = "Advanced Database Management";
                information2.Location = "BSN2300";
                information2.Teacher = "Don Berndt";
                information2.Time = "M 6:30PM-10:15PM";
            }
            listcourse.Add(information2);

            CoursesInformation information3 = new CoursesInformation();
            {
                information3.CourseID = "ISM6225";
                information3.CourseName = "Distributed Information System";
                information3.Location = "CIS2084";
                information3.Teacher = "Clinton Daniel";
                information3.Time = "T 6:30PM-9:15PM";
            }
            listcourse.Add(information3);

            return View(listcourse);
        }

        public ActionResult ExamResults()
        {
            List<ExamResults> listresults = new List<ExamResults>();

            ExamResults Result1 = new ExamResults()
            {
                CourseID = "ISM6225",
                CourseName = "Distributed Information System",
                Mark = "A-"
            };
            listresults.Add(Result1);

            ExamResults Result2 = new ExamResults()
            {
                CourseID = "ISM6155",
                CourseName = "Enterprise Information System",
                Mark = "A+"
            };
            listresults.Add(Result2);

            ExamResults Result3 = new ExamResults()
            {
                CourseID = "ISM6218",
                CourseName = "Advanced Database Management",
                Mark = "A"
            };
            listresults.Add(Result3);

            return View(listresults);
        }

        /*
       public IActionResult About()
       {
           ViewData["Message"] = "Your application description page.";

           return View();
       }

       public IActionResult Contact()
       {
           ViewData["Message"] = "Your contact page.";

           return View();
       }

       public IActionResult Privacy()
       {
           return View();
       }

       [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
       public IActionResult Error()
       {
           return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
       }
       */
    }
}
