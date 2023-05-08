using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartB.Views
{
    public class ViewExit
    {
        public static void PrintExit()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Thank you for visiting us");
            Console.ResetColor();
        }
    }
}
