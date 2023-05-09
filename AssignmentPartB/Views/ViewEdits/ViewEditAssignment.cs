using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Validations;

namespace AssignmentPartB.Views.ViewEdits
{
    public class ViewEditAssignment
    {
        public int GetAssignmentsIdForEdit()
        {
            string input;
            do
            {
                Console.WriteLine("Edit Assignment By Id");
                input = Console.ReadLine();
            } while (Validation.IsntProperId(input));
            return Convert.ToInt32(input);
        }
    }
}

