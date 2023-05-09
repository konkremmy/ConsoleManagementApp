using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Controllers;
using AssignmentPartB.Entities;

namespace AssignmentPartB.Views
{
    public class ViewAssignment
    {    
        public void ViewAssignments(IEnumerable<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Title",-15}{"OralMark",-15}{"TotalMark",-15}{"Description",-15}{"SubDateTime",-25}");
            Console.ResetColor();
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{assignment.Title,-15}{assignment.OralMark,-15}{assignment.TotalMark,-15}{assignment.Description,-15}{assignment.SubDateTime,-25}");
            }
        }
        public void ViewAssignmentsId(IEnumerable<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-15}{"Title",-15}{"OralMark",-15}{"TotalMark",-15}{"Description",-15}{"SubDateTime",-25}");
            Console.ResetColor();
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{assignment.AssignmentId,-15}{assignment.Title,-15}{assignment.OralMark,-15}{assignment.TotalMark,-15}{assignment.Description,-15}{assignment.SubDateTime,-25}");
            }
        }
    }
}
