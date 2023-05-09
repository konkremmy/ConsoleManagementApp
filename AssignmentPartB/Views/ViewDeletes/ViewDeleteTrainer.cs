using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Validations;

namespace AssignmentPartB.Views.ViewDeletes
{
    public class ViewDeleteTrainer
    {
        public int GetTrainersIdForDelete()
        {
            string input;
            do
            {
                Console.WriteLine("Delete Trainer By Id");
                input = Console.ReadLine();
            } while (Validation.IsntProperId(input));
            return Convert.ToInt32(input);
        }      
    }
}
