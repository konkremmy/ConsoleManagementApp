using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Views.ViewMenus;
using AssignmentPartB.Views;

namespace AssignmentPartB.Controllers
{
    public class MainControllerTest
    {
        CourseController courseController = new CourseController();
        TrainerController trainerController = new TrainerController();
        StudentController studentController = new StudentController();
        AssignmentController assignmentController = new AssignmentController();

        public void PrintSyntheticData()
        {
            string option;
            do
            {
                ViewInsideMenu.PrintInsideMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose an option from 1 to 9");
                Console.ResetColor();
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (option)
                {
                    case "1": studentController.PrintStudents(); break;
                    case "2": courseController.PrintCourses(); break;
                    case "3": trainerController.PrintTrainers(); break;
                    case "4": assignmentController.PrintAssignments(); break;
                    case "5": courseController.PrintStudentsPerCourse(); break;
                    case "6": courseController.PrintTrainersPerCourse(); break;
                    case "7": courseController.PrintAssignmentsPerCourse(); break;
                    case "8": studentController.PrintAssignmentsPerCoursePerStudent(); break;
                    case "9": Console.ForegroundColor = ConsoleColor.White; Console.Clear(); Console.WriteLine("All Students Have Only 1 Course"); break;
                    case "E": ViewExit.PrintExit(); break;
                    default: ViewError.PrintError(); break;
                }
                Console.WriteLine("\n\n");
            } while (option != "E");
        }
        public void PrintCreationData()
        {
            string option;
            do
            {
                ViewCreateMenu.PrintCreationMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose an option from 1 to 4");
                Console.ResetColor();
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (option)
                {
                    case "1": courseController.CreateCourse(); break;
                    case "2": trainerController.CreateTrainer(); break;
                    case "3": studentController.CreateStudent(); break;
                    case "4": assignmentController.CreateAssignment(); break;
                    case "E": ViewExit.PrintExit(); break;
                    default: ViewError.PrintError(); break;
                }
            } while (option != "E");
            Console.WriteLine("\n\n");
        }
        public void PrintUpdateData()
        {
            string option;
            do
            {
                ViewUpdateMenu.PrintUpdateMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose an option from 1 to 4");
                Console.ResetColor();
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (option)
                {
                    case "1": courseController.EditCourse(); break;
                    case "2": trainerController.EditTrainer(); break;
                    case "3": studentController.EditStudent(); break;
                    case "4": assignmentController.EditAssignment(); break;
                    case "E": ViewError.PrintError(); break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please Enter a Number from 1 to 4"); Console.ResetColor(); break;
                }
                Console.WriteLine("\n\n");
            } while (option != "E");
        }
        public void PrintDeleteData()
        {
            string option;
            do
            {
                ViewDeleteMenu.PrintDeleteMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose an option from 1 to 4");
                Console.ResetColor();
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (option)
                {
                    case "1": courseController.DeleteCourse(); break;
                    case "2": trainerController.DeleteTrainer(); break;
                    case "3": studentController.DeleteStudent(); break;
                    case "4": assignmentController.DeleteAssignment(); break;
                    case "E": ViewError.PrintError(); break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please Enter a Number from 1 to 4"); Console.ResetColor(); break;
                }
                Console.WriteLine("\n\n");
            } while (option != "E");
        }
    }
}

