using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class StudentDeleteView
    {
        private Students _students;
        public StudentDeleteView(Students students)
        {
            _students = students;
        }

        public void RunDeleteView()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the ID of the student you wish to delete.");

            int id = Convert.ToInt32(Console.ReadLine());

            int index = _students.Find(id);

            if (index != -1)
            {
                Student student = _students[index];
                Console.WriteLine($"Are you sure you wish to delete student with Id ({student.Id})? (y/n)");

                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Y)
                {
                    _students.Delete(index);
                }
            }
            else
            {
                Console.WriteLine(StudentCommonOutputText.GetStudentNotFoundMessage(id));
                Console.ReadKey();
            }

            StudentView studentView = StudentFactory.StudentViewObject(_students);
            studentView.RunView();
        }
    }
}
