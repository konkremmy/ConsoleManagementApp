using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Entities;
using AssignmentPartB.Validations;

namespace AssignmentPartB.Views.ViewCreates
{
    public class ViewCreateTrainer
    {
        public Trainer CreateTrainer()
        {
            string firstname;
            do
            {
                Console.WriteLine("Give Trainer's firstname");
                firstname = Console.ReadLine();

            } while (Validation.IsntProperFirstName(firstname));

            string lastname;
            do
            {
                Console.WriteLine("Give Trainer's lastname");
                lastname = Console.ReadLine();

            } while (Validation.IsntProperLastName(lastname));
                             
            
            string subject = Console.ReadLine();
            do
            {
                Console.WriteLine("Give Trainer's Subject");
                subject = Console.ReadLine();
            } while (Validation.IsntProperSubject(subject));

            Trainer obj = new Trainer()
            {
                FirstName = firstname,
                LastName = lastname,              
                Subject = subject

            };

            return obj;
        }
    }
}
