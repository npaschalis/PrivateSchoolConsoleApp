using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class StudentCreateView
    {
        private Students _students;
        public StudentCreateView(Students students)
        {
            _students = students;
        }

        public void RunCreateView()
        {
            string firstName;
            string lastName;
            int day;
            int month;
            int year;
            DateTime dateOfBirth;
            decimal tuitionFees;

            Console.Clear();
            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());

            Console.WriteLine();
            Console.WriteLine(StudentCommonOutputText.GetCreateHeading());

            Console.Write("First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Day of Birth (1-31): ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Month of Birth (1-12): ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Year of Birth: ");
            year = Convert.ToInt32(Console.ReadLine());

            dateOfBirth = new DateTime(year, month, day);

            Console.Write("Tuition Fees: ");
            tuitionFees = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please press [S] key to save the new student record or any other key to cancel");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.S)
            {
                _students.Add(StudentFactory.CreateNewStudentObject(firstName, lastName, dateOfBirth, tuitionFees));
            }

            StudentView studentView = StudentFactory.StudentViewObject(_students);
            studentView.RunView();
        }
    }
}
