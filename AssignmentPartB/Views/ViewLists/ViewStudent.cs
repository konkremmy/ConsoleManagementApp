using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Controllers;
using AssignmentPartB.Entities;
using AssignmentPartB.Views;

namespace AssignmentPartB.Views
{
    public class ViewStudent
    { 
               
        public void ViewStudents(IEnumerable<Student>  students)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"FirstName",-25}{"LastName",-25}{"DateOfBirth",-25}{"TuitionFees",-25}");
            Console.ResetColor();
            foreach (var stu in students)
            {
                Console.WriteLine($"{stu.FirstName,-25}{stu.LastName,-25}{stu.DateOfBirth,-25}{stu.TuitionFees,-25}");
            }
            
        }
        public void ViewStudentsId(IEnumerable<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-15}{"FirstName",-25}{"LastName",-25}{"DateOfBirth",-25}{"TuitionFees",-25}");
            Console.ResetColor();
            foreach (var stu in students)
            {
                Console.WriteLine($"{stu.StudentId,-15}{stu.FirstName,-25}{stu.LastName,-25}{stu.DateOfBirth,-25}{stu.TuitionFees,-25}");
            }
        }
        

    }
}
