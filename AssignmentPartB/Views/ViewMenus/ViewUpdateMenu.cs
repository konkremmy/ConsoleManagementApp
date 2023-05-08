using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartB.Views.ViewMenus
{
    public class ViewUpdateMenu
    {
        public static void PrintUpdateMenu()
        {
            Console.WriteLine("1: Update Course");
            Console.WriteLine("2: Update Trainer");
            Console.WriteLine("3: Update Student");
            Console.WriteLine("4: Update Assignment");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("E: Press 'E' to go to Back");
            Console.ResetColor();
        }
    }
}
