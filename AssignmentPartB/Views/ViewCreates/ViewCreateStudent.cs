using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Entities;
using AssignmentPartB.RepositoryServices;
using AssignmentPartB.Validations;

namespace AssignmentPartB.Views.ViewCreates
{
    public class ViewCreateStudent
    {
        
        public Student CreateStudent()
        {

            string firstname;
            do
            {
                Console.WriteLine("Give Student's Firstname");
                firstname = Console.ReadLine();

            } while (Validation.IsntProperFirstName(firstname));
            
            string lastname;
            do
            {
                Console.WriteLine("Give Student's Lastname");
                lastname = Console.ReadLine();

            } while (Validation.IsntProperLastName(lastname));

            string feesfirst;
            int fees;
            do
            {
                Console.WriteLine("Give Tuitionfees");
                feesfirst = Console.ReadLine();

            } while (Validation.IsntProperFees(feesfirst));
            fees = Convert.ToInt32(feesfirst);

            string dobfirst;
            DateTime dob;
            do
            {
                Console.WriteLine("Give DateOfBirth");
                dobfirst = Console.ReadLine();
            } while (Validation.IsntProperDateOfBirth(dobfirst));
            dob = Convert.ToDateTime(dobfirst);

            Student obj = new Student();
            {
                obj.FirstName = firstname;
                obj.LastName = lastname;
                obj.TuitionFees = fees;
                obj.DateOfBirth = dob;
            };

            
            
            return obj;
        }
        
    }
}
