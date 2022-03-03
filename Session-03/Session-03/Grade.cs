using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        //TODO: Set another name for Grade so it won't be the same with the class
        //public int Grade { get; set; }

        public Grade()
        {
            ID = Guid.NewGuid();
        }
    }
}
