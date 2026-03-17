namespace University_Course_Enrollment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Course cs1 = PickCourse();

            Console.WriteLine("Enter Student Name");
            string name = Console.ReadLine();

            cs1.EnrollStudent(name);

        }

        public static Course PickCourse()
        {
            int ch;
            while (true)
            {
                Console.WriteLine("Enter Choice 1 - Online Course | 2 - In Person Course | 3 - Lab Course");
                if (int.TryParse(Console.ReadLine(), out ch))
                {
                    Console.WriteLine("Enter Course Name");
                    string? CourseName = Console.ReadLine();
                    if (ch == 1)
                    {

                        Console.WriteLine("Enter Video Link");
                        string? VideoLink = Console.ReadLine();

                        return new OnlineCourse(CourseName, VideoLink);

                    }
                    else if (ch == 2)
                    {
                        Console.WriteLine("Enter RoomNumber : ");
                        string? RoomNumber = Console.ReadLine();

                        int Capacity;
                        Console.WriteLine("Enter Capacity");
                        while (!int.TryParse(Console.ReadLine(), out Capacity))
                        {
                            Console.WriteLine("Enter Capacity");
                        }

                        return new InPersonCourse(CourseName, RoomNumber, Capacity);

                    }
                    else if (ch == 3)
                    {
                        Console.WriteLine("Is Lab follow the Safely Precaution [y/N]");
                        string safety = Console.ReadLine().ToLower();

                        if(safety == "y" || safety == "Yes")
                        {
                            return new LabCourse(CourseName, true);
                        }


                        return new LabCourse(CourseName, false);

                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                
            }
        }
    }

}