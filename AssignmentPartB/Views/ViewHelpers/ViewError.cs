using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartB.Views
{
    public class ViewError
    {
        public static void PrintError()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Choice - Error 404");
            Console.ResetColor();
        }
    }
}
