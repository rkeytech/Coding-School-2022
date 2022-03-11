using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    public class ProfessorHandler : Handler
    {
        public Professor ProfessorItem { get; set; }

        public ProfessorHandler()
        {

        }

        public Professor CreateObject(List<Professor> professorList)
        {
            var professor = new Professor();
            professorList.Add(professor);

            return professor;
        }

        public Professor CreateObject(List<Professor> professorList, string name = "Insert Name")
        {
            var professor = new Professor()
            {
                Name = name,
            };
            professorList.Add(professor);

            return professor;
        }

        public void DeleteObject(Professor professor, List<Professor> professorList)
        {
            professorList.Remove(professor);
        }

        public void Teach(Course course, DateTime datetime)
        {
            //TODO: Add the course in the Courses?? What's the use of datetime?
        }

        public void SetGrade(Guid studentID, Guid courseID, int grade)
        {
            var gradeItem = new Grade()
            {
                StudentID = studentID,
                CourseID = courseID,
                Value = grade
            };

            //TODO: Add the newly created grade in the Grades of the University

        }
    }
}
