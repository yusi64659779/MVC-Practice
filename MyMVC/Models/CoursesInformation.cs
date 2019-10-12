using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC.Models
{
    public class CoursesInformation
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }

        CoursesInformation CourInfo1 = new CoursesInformation()
        {
            CourseID = "ISM6225",
            CourseName = "Distributed Information System",
            Teacher = "Clinton Daniel",
            Location = "CIS2084",
            Time = "T 6:30PM-9-15PM"
        };

        CoursesInformation CourInfo2 = new CoursesInformation()
        {
            CourseID = "ISM6155",
            CourseName = "Enterprise Information System",
            Teacher = "Deepak Sainanee",
            Location = "BSN230",
            Time = "R 6:30PM-9:15PM"
        };

        CoursesInformation CourInfo3 = new CoursesInformation()
        {
            CourseID = "ISM6218",
            CourseName = "Advanced Database Management",
            Teacher = "Don Berndt",
            Location = "BSN2300",
            Time = "M 6:30PM-10:15PM"
        };

    }
}
