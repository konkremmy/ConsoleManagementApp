using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Controllers;
using AssignmentPartB.Entities;
using AssignmentPartB.RepositoryServices;

namespace AssignmentPartB.Views
{
    public class ViewStudentPerCourse
    {
        public void ViewStudentsPerCourse(IEnumerable<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"",-30}{"FirstName",-15}{"LastName",-15}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{course.Title}");
                Console.ResetColor();
                foreach (var student in course.Students)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{"",-30}{student.FirstName,-15}{student.LastName,-15}");
                }
            }
        }
    }
}
