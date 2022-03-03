using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professor : Person
    {
        public string Rank { get; set; }
        public Course[] Courses { get; set; }


        public Professor()
        {
            Courses = new Course[20];
            Rank = "";
        }

        public void Teach(Course course, DateTime datetime)
        {
            // Write the functionality for the teaching
        }

        public void SetGrade(Guid studentID, Guid courseID, int grade)
        {
            // Write the functionality for changnig the grade of a student
        }
    }
}
