using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Controllers;
using AssignmentPartB.Entities;

namespace AssignmentPartB.Views
{
    public class ViewStudentsWithMultipleCourse
    {
        
        public void ViewStudentsWithMultipleCourses(IEnumerable<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Students With Multiple Courses");
            Console.ResetColor();
            if (students.Count() > 0)
            {
                foreach (var student in students)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{student.FirstName,-15}");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("NO ONE");
            }
        }
    }
}
