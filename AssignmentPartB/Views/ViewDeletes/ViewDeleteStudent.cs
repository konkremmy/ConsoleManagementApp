using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Entities;
using AssignmentPartB.Validations;

namespace AssignmentPartB.Views.ViewDeletes
{
    public class ViewDeleteStudent
    {
        public int DeleteStudent()
        {
            string input;           
            do
            {
                Console.WriteLine("Delete Student By Id");
                input = Console.ReadLine();
            } while (Validation.IsntProperId(input));
            return Convert.ToInt32(input);
        }       
    }
}
