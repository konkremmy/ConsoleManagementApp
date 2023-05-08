using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Entities;
using AssignmentPartB.MyDatabase;
using AssignmentPartB.RepositoryServices;
using AssignmentPartB.Views;
using AssignmentPartB.Views.ViewCreates;
using AssignmentPartB.Views.ViewDeletes;
using AssignmentPartB.Views.ViewEdits;

namespace AssignmentPartB.Controllers
{
    public class StudentController
    {
        private StudentRepository studentRepository;
        private ViewCreateStudent viewCreateStudent;
        private ViewStudent viewStudent;
        private ViewAssignmentsPerCoursePerStudent viewAssignmentsPerCoursePerStudent;
        private ViewStudentsWithMultipleCourse viewStudentsWithMultipleCourses;
        private ViewDeleteStudent viewDeleteStudent;
        private ViewEditStudent viewEditStudent;

        public StudentController()
        {
            studentRepository = new StudentRepository(new ApplicationDbContext());
            viewCreateStudent = new ViewCreateStudent();
            viewStudent = new ViewStudent();
            viewAssignmentsPerCoursePerStudent = new ViewAssignmentsPerCoursePerStudent();
            viewStudentsWithMultipleCourses = new ViewStudentsWithMultipleCourse();
            viewDeleteStudent = new ViewDeleteStudent();
            viewEditStudent = new ViewEditStudent();
        }

        public void PrintAssignmentsPerCoursePerStudent()
        {
            var students = studentRepository.GetAll();
            viewAssignmentsPerCoursePerStudent.ViewAssignmentsPerCoursePerStudents(students);
        }
        public void PrintStudents()
        {
            var students = studentRepository.GetAll();
            viewStudent.ViewStudents(students);
        }
        public void PrintStudentsWithMultipleCourse()
        {
            var students = studentRepository.GetAll();
            students = students.Where(student => student.Courses.Count > 1);
            viewStudentsWithMultipleCourses.ViewStudentsWithMultipleCourses(students);
        }
        public void CreateStudent()
        {
            var student = viewCreateStudent.CreateStudent();
            if (student != null)
            {
                studentRepository.Add(student);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            var students = studentRepository.GetAll();
            viewStudent.ViewStudents(students);
        }
        public void DeleteStudent()
        {
            var students = studentRepository.GetAll();
            viewStudent.ViewStudentsId(students);
            int id = viewDeleteStudent.DeleteStudent();
            if (studentRepository.Get(id) != null)
            {
                studentRepository.Delete(id);
            }
            else
            {
                Console.WriteLine("Wrong Id");               
            }           
        }

        public void EditStudent()
        {
            var students = studentRepository.GetAll();
            viewStudent.ViewStudentsId(students);
            int id=viewEditStudent.EditStudent();
            if (studentRepository.Get(id) != null)
            {
                var studentOld = studentRepository.Get(id);
                var studentNew = viewCreateStudent.CreateStudent();
                studentOld.FirstName = studentNew.FirstName;
                studentOld.LastName = studentNew.LastName;
                studentOld.TuitionFees = studentNew.TuitionFees;
                studentOld.DateOfBirth = studentNew.DateOfBirth;
                studentRepository.Edit(studentOld);
            }
            else
            {
                Console.WriteLine("Wrong Id");
            }                    
        }

    }

}

