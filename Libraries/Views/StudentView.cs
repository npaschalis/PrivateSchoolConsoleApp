using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class StudentView
    {
        private Students _students;

        public StudentView(Students students)
        {
            _students = students;
        }

        public void RunView()
        {
            Console.Clear();
            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());
            StudentRecordsView studentRecordsView = StudentFactory.StudentRecordsViewObject(_students);
            studentRecordsView.RunRecordsView();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press:\n[A] to Add a new Student\n[U] to Update a Student's data\n[D] to Delete a Student\nor any other key to return to main menu");

            ConsoleKey instructionKey = Console.ReadKey().Key;

            switch (instructionKey)
            {
                case ConsoleKey.A:
                    StudentCreateView studentCreateView = StudentFactory.StudentCreateViewObject(_students);
                    studentCreateView.RunCreateView();
                    break;
                case ConsoleKey.U:
                    StudentUpdateView studentUpdateView = StudentFactory.StudentUpdateViewObject(_students);
                    studentUpdateView.RunUpdateView();
                    break;
                case ConsoleKey.D:
                    StudentDeleteView studentDeleteView = StudentFactory.StudentDeleteViewObject(_students);
                    studentDeleteView.RunDeleteView();
                    break;
                default:
                    break;

            }
        }
    }
}
