﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institute
    {
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] ScheduledCourses { get; set; }

        public University()
        {
            Students = new Student[30];
            Courses = new Course[20];
            Grades = new Grade[600];
            ScheduledCourses = new Schedule[60];

        }

        public Student[] GetStudents()
        {
            return Students;
        }

        public Course[] GetCourse()
        {
            return Courses;
        }

        public Grade[] GetGrades()
        {
            return Grades;
        }

        public void SetSchedule(Guid courseID, Guid professorID, DateTime datetime)
        {
            // Write functionality to set a schedule for a course
        }
    }
}
