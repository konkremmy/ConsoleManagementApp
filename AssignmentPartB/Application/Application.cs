using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Controllers;
using AssignmentPartB.MyDatabase;
using AssignmentPartB.Views;

namespace AssignmentPartB.Application
{
    public class Application
    {
        CourseController courseController = new CourseController();
        TrainerController trainerController = new TrainerController();
        StudentController studentController = new StudentController();
        AssignmentController assignmentController = new AssignmentController();
        public void Run()
        {          
            string input;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome To KremmySchool");
            Console.WriteLine("Press C to Create Your Data//Whatever Else to See Our Data");
            input = Console.ReadLine();
           
            if (input == "c" || input == "C")
            {
                do
                {
                    Console.WriteLine("Lets Create Your Student");
                    studentController.CreateStudent();
                    //studentController.PrintStudents();
                    Console.WriteLine("Press f to continue to Courses");
                    input = Console.ReadLine();
                } while (input != "f");
                do
                {
                    Console.WriteLine("Lets Create Your Course");
                    courseController.CreateCourse();
                    //courseController.PrintCourses();
                    Console.WriteLine("Press f to continue to Trainers");
                    input = Console.ReadLine();
                } while (input != "f");
                do
                {
                    Console.WriteLine("Lets Create Your Trainer");
                    trainerController.CreateTrainer();
                    //trainerController.PrintTrainers();
                    Console.WriteLine("Press f to continue to Assignments");
                    input = Console.ReadLine();
                } while (input != "f");
                do
                {
                    Console.WriteLine("Lets Create Your Assignment");
                    assignmentController.CreateAssignment();
                    //assignmentController.PrintAssignments();
                    Console.WriteLine("Press f to finish");
                    input = Console.ReadLine();
                } while (input != "f");
            }
            else
            {
                do
                {
                    ViewMenu.PrintMenu();

                    input = Console.ReadLine();
                    Console.Clear();

                    MainController.Controller(studentController,courseController,trainerController,assignmentController,input);

                } while (input != "E" && input != "e");
            }
        }
        
    }
}

