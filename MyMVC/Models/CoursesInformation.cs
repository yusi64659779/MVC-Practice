using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyMVC.Models
{
    public class CoursesInformation
    {
        [Required]
        [DataType(DataType.Text)]
        [DisplayName("CourseID")]
        public string CourseID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [DisplayName("CourseName")]
        public string CourseName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Teacher")]
        public string Teacher { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Location")]
        public string Location { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Time")]
        public string Time { get; set; }

        
    }
}
