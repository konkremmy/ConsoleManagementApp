using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Controllers;
using AssignmentPartB.Entities;

namespace AssignmentPartB.Views
{

    public class ViewAssignmentsPerCourse
    {
        public void ViewAssignmentsPerCourses(IEnumerable<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Title",-15}{"Title",-15}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(course.Title, -15);
                Console.ResetColor();
                foreach (var assignment in course.Assignments)
                {
                    Console.WriteLine($"{"",-30}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{"",-15}{assignment.Title}");
                    Console.WriteLine();
                }
            }
        }
    }
}
