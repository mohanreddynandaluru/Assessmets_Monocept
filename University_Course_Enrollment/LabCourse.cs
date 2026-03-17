
namespace University_Course_Enrollment
{
    internal class LabCourse : Course
    {
        public bool SafetyTrainingCompleted;

        public LabCourse(string CourseName, bool safety) : base(CourseName)
        {
            if (!safety)
            {
                Console.WriteLine("Safety training is mandatory.");
                return;
            }

            SafetyTrainingCompleted = safety;
        }

        public override void EnrollStudent(string studentName)
        {
            if (!SafetyTrainingCompleted)
            {
                Console.WriteLine("Safety training is mandatory");
                return;
            }
            Console.WriteLine($"{studentName} enrolled in LAB course '{CourseName}'");
        }
    }
}
