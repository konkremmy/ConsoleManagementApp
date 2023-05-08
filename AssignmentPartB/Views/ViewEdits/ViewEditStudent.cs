using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Validations;

namespace AssignmentPartB.Views.ViewEdits
{
    public class ViewEditStudent
    {
        public int EditStudent()
        {
            string input;
            do
            {
                Console.WriteLine("Edit Student By Id");
                input = Console.ReadLine();
            } while (Validation.IsntProperId(input));
            return Convert.ToInt32(input);           
        }
    }
}
