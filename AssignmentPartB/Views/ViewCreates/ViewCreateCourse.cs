using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Entities;
using AssignmentPartB.Entities.Enums;
using AssignmentPartB.Validations;

namespace AssignmentPartB.Views.ViewCreates
{
    public class ViewCreateCourse
    {
        public Course CreateCourse()
        {
            string title;
            do
            {
                Console.WriteLine("Give Course's Title");
                title= Console.ReadLine();
            } while (Validation.IsntProperTitle(title));

            string type;
            CourseType type2;
            do
            {
                Console.WriteLine("Give Course's Type:Press 1 for FullTime or 2 PartTime");
                type= Console.ReadLine();
            } while (Validation.IsntProperType(type));
            type2 = (CourseType)Enum.Parse(typeof(CourseType),type,true);
           
            string stream;
            do
            {
                Console.WriteLine("Give Course's Stream");
                stream = Console.ReadLine();
            } while (Validation.IsntProperStream(stream));

            string startdate;
            DateTime sd;
            do
            {
                Console.WriteLine("Give StartDate");
                startdate = Console.ReadLine();
            } while (Validation.IsntProperStartDate(startdate));          
            sd = Convert.ToDateTime(startdate);

            string enddate;
            DateTime ed;
            do
            {
                Console.WriteLine("Give EndDate");
                enddate = Console.ReadLine();
            } while (Validation.IsntProperEndDate(enddate));
            ed = Convert.ToDateTime(enddate);

            Course obj = new Course()
            {
                Title = title,              
                StartDate = sd,
                EndDate = ed,
                Type = type2,
                Stream = stream
            };

            return obj;
        }
    }
}

