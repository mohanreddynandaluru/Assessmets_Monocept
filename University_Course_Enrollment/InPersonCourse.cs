using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Enrollment
{
    internal class InPersonCourse : Course
    {
        public string RoomNumber;
        public int Capacity;
        public int enrolled=0;

        public InPersonCourse(string CourseName, string RoomNumber, int Capacity) : base(CourseName)
        {
            this.RoomNumber = RoomNumber;
            if(Capacity <= 0)
            {
                Capacity = 0;
                Console.WriteLine("Invalid capacity! Capacity set to 1");
            }
            this.Capacity = Capacity;
        }

        public override void EnrollStudent(string StudentName)
        {
            if(enrolled >=  Capacity)
            {
                Console.WriteLine("Room is full");
                return;
            }

            enrolled++;
            Console.WriteLine($"{StudentName} enrolled in IN-PERSON course '{CourseName}' (Room {RoomNumber})");

        }

    }
}
