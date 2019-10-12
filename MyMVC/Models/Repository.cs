using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC.Models
{
    public class Repository
    {
        private static List<StudentLogin> students = new List<StudentLogin>();

        public static void AddStudent(StudentLogin login)
        {
            students.Add(login);
        }
    }
}
