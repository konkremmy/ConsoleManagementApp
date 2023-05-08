using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartB.Views.ViewMenus
{
    public class ViewCreateMenu
    {
        public static void PrintCreationMenu()
        {
            Console.WriteLine("1: Create new Course");
            Console.WriteLine("2: Create new Trainer");
            Console.WriteLine("3: Create new Student");
            Console.WriteLine("4: Create new Assignment");           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("E: Press 'E' to go to Back");
            Console.ResetColor();
            Console.WriteLine();           
        }
    }
}
