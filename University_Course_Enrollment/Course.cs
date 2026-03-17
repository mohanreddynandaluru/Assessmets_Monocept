using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Enrollment
{
    abstract class Course
    {
        public string CourseName { get; set; }

        protected Course(string  courseName)
        {
            CourseName = courseName;
        }

        public abstract void EnrollStudent(string StudentName);
    }
}
