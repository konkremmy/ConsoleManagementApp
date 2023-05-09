using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Controllers;
using AssignmentPartB.Entities;

namespace AssignmentPartB.Views
{
    public class ViewCourse
    {    
        public void ViewCourses(IEnumerable<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Title",-15}{"Type",-15}{"StartDate",-25}{"EndDate",-25}{"Stream",-25}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Title,-15}{course.Type,-15}{course.StartDate,-25}{course.EndDate,-25}{course.Stream,-25}");
            }
        }
        public void ViewCoursesId(IEnumerable<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-15}{"Title",-15}{"Type",-15}{"StartDate",-25}{"EndDate",-25}{"Stream",-25}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.CourseId,-15}{course.Title,-15}{course.Type,-15}{course.StartDate,-25}{course.EndDate,-25}{course.Stream,-25}");
            }
        }
    }
}
