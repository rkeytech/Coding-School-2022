using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    public class UniversityHandler : Handler
    {
        public University UniversityItem { get; set; }

        public UniversityHandler()
        {

        }
        
        public Course CreateCourse(List<Course> courses, string code="Insert Code")
        {
            var course = new Course()
            {
                Code = code
            };
            courses.Add(course);
            return course;
        }

        public void DeleteCourse(Course course, List<Course> courses)
        {
            courses.Remove(course);
        }

        public List<Student> GetStudents()
        {
            return UniversityItem.Students;
        }

        public List<Course> GetCourses()
        {
            return UniversityItem.Courses;
        }

        public List<Grade> GetGrades()
        {
            return UniversityItem.Grades;
        }

        public void SetSchedule(Guid courseID, Guid professorID, DateTime datetime)
        {

            var scheduledCourse = new Schedule()
            {
                CourseID = courseID,
                ProfessorID = professorID,
                Calendar = datetime
            };

            UniversityItem.ScheduledCourses.Add(scheduledCourse);
        }
    }
}
