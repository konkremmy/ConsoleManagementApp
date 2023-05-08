using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Entities;
using AssignmentPartB.Validations;


namespace AssignmentPartB.Views.ViewCreates
{
    public class ViewCreateAssignment
    {
        public Assignment CreateAssignment()
        {
            string title;
            do
            {
                Console.WriteLine("Give Assignment's Title");
                title = Console.ReadLine();
            } while (Validation.IsntProperTitle(title));
           
            string description;
            do
            {
                Console.WriteLine("Give Assignment's Description");
                description = Console.ReadLine();
            } while (Validation.IsntProperDescription(description));

            string oralmarkfirst;
            int oralmark;
            do
            {
                Console.WriteLine("Give Assignment's OralMark");
                oralmarkfirst = Console.ReadLine();
            } while (Validation.IsntProperOralMark(oralmarkfirst));           
            oralmark = Convert.ToInt32(oralmarkfirst);

            string totalmarkfirst;
            int totalmark;
            do
            {
                Console.WriteLine("Give Assignment's TotalMark");
                totalmarkfirst = Console.ReadLine();
            } while (Validation.IsntProperTotalMark(totalmarkfirst));        
            totalmark = Convert.ToInt32(totalmarkfirst);

            string subdatetime;
            DateTime sdt;
            do
            {
                Console.WriteLine("Give SubDateTime");
                subdatetime = Console.ReadLine();
            } while (Validation.IsntProperSubDateTime(subdatetime));
            sdt = Convert.ToDateTime(subdatetime);

            Assignment obj = new Assignment()
            {
                Title = title,
                Description = description,
                OralMark = oralmark,
                TotalMark = totalmark,             
                SubDateTime = sdt
            };

            return obj;
        }
    }
}
