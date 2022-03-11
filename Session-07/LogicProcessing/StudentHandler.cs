using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    public class StudentHandler : Handler
    {
        public StudentHandler()
        {

        }

        public Student CreateObject(List<Student> studentList)
        {
            var student = new Student();
            studentList.Add(student);

            return student;
        }

        public Student CreateObject(List<Student> studentList, string name = "Insert Name")
        {
            var student = new Student()
            {
                Name = name,
            };
            studentList.Add(student);

            return student;
        }

        public void DeleteObject(Student student, List<Student> studentList)
        {
            studentList.Remove(student);
        }

        //public void Attend(Course course, DateTime datetime)
        //{
        //    //TODO: Add the course to the Courses of University? Datetime why?
        //}

        //public void WriteExam(Course course, DateTime datetime)
        //{
        //    //TODO: Where should I add the course for the exam??
        //}
    }
}
