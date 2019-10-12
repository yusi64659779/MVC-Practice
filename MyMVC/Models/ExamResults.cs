using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC.Models
{
    public class ExamResults
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string Mark { get; set; }

        ExamResults Result1 = new ExamResults()
        {
            CourseID = "ISM6225",
            CourseName = "Distributed Information System",
            Mark="A-"
        };

        ExamResults Result2 = new ExamResults()
        {
            CourseID = "ISM6155",
            CourseName = "Enterprise Information System",
            Mark = "A+"
        };

        ExamResults Result3 = new ExamResults()
        {
            CourseID = "ISM6218",
            CourseName = "Advanced Database Management",
            Mark = "A"
        };
    }
}
