using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartB.Views
{
    public class ViewMenu
    {
        public static void PrintMenu()
        {
            const int first = -60;
            const int second = -60;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose an option");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine($"{"----------ALL DATA----------",first}{"----------E FOR EXIT----------",second}");
            Console.WriteLine($"{"1 - Students",first}");
            Console.WriteLine($"{"2 - Courses",first}");
            Console.WriteLine($"{"3 - Trainers",first}");
            Console.WriteLine($"{"4 - Assignments",first}");
            Console.WriteLine($"{"5 - StudentsPerCourse",first}");
            Console.WriteLine($"{"6 - TrainersPerCourse",first}");
            Console.WriteLine($"{"7 - AssignmentsPerCourse",first}");
            Console.WriteLine($"{"8 - AssignmentsPerStudentPerCourse",first}");
            Console.WriteLine($"{"9 - Students Who Have More Than 1 Course",first}");
        }
    }
}
