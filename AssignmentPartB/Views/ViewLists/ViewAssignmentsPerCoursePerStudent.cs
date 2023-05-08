using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Controllers;
using AssignmentPartB.Entities;
using AssignmentPartB.RepositoryServices;

namespace AssignmentPartB.Views
{
    public class ViewAssignmentsPerCoursePerStudent
    {
        
        public void ViewAssignmentsPerCoursePerStudents(IEnumerable<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"FirstName",-15}{"LastName",-15}{"Title",-15}{"Title",-15}");
            Console.ResetColor();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName,-15}{student.LastName,-15}");
                foreach (var course in student.Courses)
                {
                    Console.WriteLine($"{"",-30}{course.Title,-15}");
                    foreach (var assignment in course.Assignments)
                    {
                        Console.WriteLine($"{"",-45}{assignment.Title,-15}");
                    }
                }
            }
        }

    }
}
