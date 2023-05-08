using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Controllers;
using AssignmentPartB.Entities;

namespace AssignmentPartB.Views
{
    public class ViewTrainerPerCourse
    {   
        public  void ViewTrainerPerCourses(IEnumerable<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Title",-15}{"FirstName",-15}{"LastName",-15}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine(course.Title, -15);
                foreach (var trainer in course.Trainers)
                {
                    Console.WriteLine($"{"",-15}{trainer.FirstName,-15}{trainer.LastName,-15}");
                    Console.WriteLine();
                }
            }
        }
    }
}

