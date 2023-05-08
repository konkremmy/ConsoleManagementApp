using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartB.Views.ViewMenus
{
    public class ViewDeleteMenu
    {
        public static void PrintDeleteMenu()
        {
            Console.WriteLine("1: Delete Course");
            Console.WriteLine("2: Delete Trainer");
            Console.WriteLine("3: Delete Student");
            Console.WriteLine("4: Delete Assignment");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("E: Press 'E' to go to Back");
            Console.ResetColor();
        }
    }
}
