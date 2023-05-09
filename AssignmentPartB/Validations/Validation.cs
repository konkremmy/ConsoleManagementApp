using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssignmentPartB.Validations
{
    public static class Validation
    {
        public static bool IsntProperFirstName(string firstname)
        {
            return string.IsNullOrEmpty(firstname) || !firstname.All(Char.IsLetter) || firstname.Length >= 20;
        }
        public static bool IsntProperLastName(string lastname)
        {
            return string.IsNullOrEmpty(lastname) || !lastname.All(Char.IsLetter) || lastname.Length >= 25;
        }
        public static bool IsntProperFees(string feesfirst)
        {
            return string.IsNullOrEmpty(feesfirst) || !feesfirst.All(Char.IsNumber) || feesfirst.Length >= 10;
        }
        public static bool IsntProperDateOfBirth(string dobfirst)
        {
            DateTime dob;
            return string.IsNullOrEmpty(dobfirst) || !DateTime.TryParse(dobfirst, out dob) || dob >= DateTime.Now || dob <= new DateTime(1920, 3, 3);
        }
        public static bool IsntProperSubject(string subject)
        {
            return string.IsNullOrEmpty(subject) || !subject.All(Char.IsLetter) || subject.Length >= 20;
        }
        public static bool IsntProperTitle(string title)
        {
            return string.IsNullOrEmpty(title) || !title.All(Char.IsLetter) || title.Length >= 20;
        }
        public static bool IsntProperType(string type)
        {        
            return string.IsNullOrEmpty(type) || (type != "1" && type != "2");
        }
        public static bool IsntProperStream(string stream)
        {
            return string.IsNullOrEmpty(stream) || !stream.All(Char.IsLetter) || stream.Length >= 20;
        }
        public static bool IsntProperStartDate(string startdate)
        {
            DateTime sd;
            return string.IsNullOrEmpty(startdate) || !DateTime.TryParse(startdate, out sd) || sd >= DateTime.Now || sd <= new DateTime(2022, 1, 1);
        }
        public static bool IsntProperEndDate(string enddate)
        {
            DateTime ed;
            return string.IsNullOrEmpty(enddate) || !DateTime.TryParse(enddate, out ed) || ed >= DateTime.Now || ed >= new DateTime(2022, 12, 12) || ed <= new DateTime(2022, 1, 1);
        }
        public static bool IsntProperDescription(string description)
        {
            return string.IsNullOrEmpty(description) || !description.All(Char.IsLetter) || description.Length >= 20;
        }
        public static bool IsntProperOralMark(string oralmarkfirst)
        {
            return string.IsNullOrEmpty(oralmarkfirst) || !oralmarkfirst.All(Char.IsNumber) || Convert.ToInt32(oralmarkfirst) <= 0 || Convert.ToInt32(oralmarkfirst) >= 50;
        }
        public static bool IsntProperTotalMark(string totalmarkfirst)
        {
            return string.IsNullOrEmpty(totalmarkfirst) || !totalmarkfirst.All(Char.IsNumber) || Convert.ToInt32(totalmarkfirst) <= 0 || Convert.ToInt32(totalmarkfirst) >= 100;
        }
        public static bool IsntProperSubDateTime(string subdatetime)
        {
            DateTime sdt;
            return string.IsNullOrEmpty(subdatetime) || !DateTime.TryParse(subdatetime, out sdt) || sdt >= new DateTime(2022, 12, 12) || sdt <= new DateTime(2022, 6, 6);
        }
        public static bool IsntProperId(string input)
        {
            return string.IsNullOrEmpty(input) || !input.All(Char.IsNumber);
        }
    }
}
