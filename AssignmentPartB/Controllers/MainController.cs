using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Views;

namespace AssignmentPartB.Controllers
{
    public class MainController
    {
        public static void Controller(StudentController studentController, CourseController courseController, TrainerController trainerController, AssignmentController assignmentController, string input)
        {
            switch (input)
            {
                case "1": studentController.PrintStudents(); break;
                case "2": courseController.PrintCourses(); break;
                case "3": trainerController.PrintTrainers(); break;
                case "4": assignmentController.PrintAssignments(); break;
                case "5": courseController.PrintStudentsPerCourse(); break;
                case "6": courseController.PrintTrainersPerCourse(); break;
                case "7": courseController.PrintAssignmentsPerCourse(); break;
                case "8": studentController.PrintAssignmentsPerCoursePerStudent(); break;
                case "9": Console.ForegroundColor = ConsoleColor.Red; Console.Clear(); Console.WriteLine("All Students Have Only 1 Course"); break;
                case "e": ViewExit.PrintExit(); break;
                case "E": ViewExit.PrintExit(); break;
                default: ViewError.PrintError(); break;
            }
        }
    }
}
