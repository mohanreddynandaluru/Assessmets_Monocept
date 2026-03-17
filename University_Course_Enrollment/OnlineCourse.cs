using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Enrollment
{
    internal class OnlineCourse : Course
    {
        public string? VideoLink;

        public OnlineCourse(string CourseName, string VideoLink) : base(CourseName)
        {
            while(string.IsNullOrWhiteSpace(VideoLink))
            {
                Console.WriteLine("Invalid Link Enter Valid Link");
                VideoLink = Console.ReadLine();
            } 
            this.VideoLink = VideoLink;
        }

        public override void EnrollStudent(string studentName)
        {
            Console.WriteLine($"{studentName} enrolled in ONLINE course '{CourseName}' via {VideoLink}");
        }


    }
}
