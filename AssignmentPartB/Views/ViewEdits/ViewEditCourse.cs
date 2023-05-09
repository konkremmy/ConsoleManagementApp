using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Validations;

namespace AssignmentPartB.Views.ViewEdits
{
    public class ViewEditCourse
    {
        public int GetCoursesIdForEdit()
        {
            string input;
            do
            {
                Console.WriteLine("Edit Course By Id");
                input = Console.ReadLine();
            } while (Validation.IsntProperId(input));
            return Convert.ToInt32(input);
        }
    }
}
