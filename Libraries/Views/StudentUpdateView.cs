using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class StudentUpdateView
    {
        private Students _students;

        public StudentUpdateView(Students students)
        {
            _students = students;
        }

        public void RunUpdateView()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the id of the student you wish to edit");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());

            int index = _students.Find(id);

            if (index != -1)
            {
                string firstName;
                string lastName;
                string day;
                string month;
                string year;
                string tuitionFees;

                int dayDOB;
                int monthDOB;
                int yearDOB;

                Student student = _students[index];

                Console.WriteLine(StudentCommonOutputText.GetUpdateHeading(student));
                Console.WriteLine(StudentCommonOutputText.GetUpdateViewAdditionalInstructions());

                Console.Write($"First Name ({student.FirstName}): ");
                firstName = Console.ReadLine();

                Console.Write($"Last Name ({student.LastName}): ");
                lastName = Console.ReadLine();

                Console.Write($"Day of Birth ({student.DateOfBirth.Day}): ");
                day = Console.ReadLine();

                Console.Write($"Month of Birth ({student.DateOfBirth.Month}): ");
                month = Console.ReadLine();

                Console.Write($"Year of Birth ({student.DateOfBirth.Year}): ");
                year = Console.ReadLine();

                Console.Write($"Tuition Fees ({student.TuitionFees}): ");
                tuitionFees = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(day))
                {
                    dayDOB = student.DateOfBirth.Day;
                }
                else
                {
                    dayDOB = Convert.ToInt32(day);
                }

                if (String.IsNullOrWhiteSpace(month))
                {
                    monthDOB = student.DateOfBirth.Month;
                }
                else
                {
                    monthDOB = Convert.ToInt32(month);
                }

                if (String.IsNullOrWhiteSpace(year))
                {
                    yearDOB = student.DateOfBirth.Year;
                }
                else
                {
                    yearDOB = Convert.ToInt32(year);
                }

                _students.Update(student,
                    (String.IsNullOrWhiteSpace(firstName) ? student.FirstName : firstName),
                    (String.IsNullOrWhiteSpace(lastName) ? student.LastName : lastName),
                    new DateTime(yearDOB, monthDOB, dayDOB),
                    (String.IsNullOrWhiteSpace(tuitionFees) ? student.TuitionFees : Convert.ToDecimal(tuitionFees))
                );
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
