using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class CourseCreateView
    {
        private Courses _courses;
        private Students _students;
        private Trainers _trainers;
        private Assignments _assignments;
        public CourseCreateView(Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            _courses = courses;
            _students = students;
            _trainers = trainers;
            _assignments = assignments;
        }

        public void RunCreateView()
        {
            string title;
            string stream;
            string type;
            int startDay;
            int startMonth;
            int startYear;
            DateTime startDate;
            int endDay;
            int endMonth;
            int endYear;
            DateTime endDate;

            Console.Clear();
            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());

            Console.WriteLine();
            Console.WriteLine(CourseCommonOutputText.GetCreateHeading());

            Console.Write("Title: ");
            title = Console.ReadLine();

            Console.Write("Stream: ");
            stream = Console.ReadLine();

            Console.Write("Type: ");
            type = Console.ReadLine();

            Console.Write("Start Date: Enter day (1-31): ");
            startDay = Convert.ToInt32(Console.ReadLine());

            Console.Write("Start Date: Enter month (1-12): ");
            startMonth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Start Date: Enter year: ");
            startYear = Convert.ToInt32(Console.ReadLine());

            startDate = new DateTime(startYear, startMonth, startDay);

            Console.Write("End Date: Enter day (1-31): ");
            endDay = Convert.ToInt32(Console.ReadLine());

            Console.Write("End Date: Enter month (1-12): ");
            endMonth = Convert.ToInt32(Console.ReadLine());

            Console.Write("End Date: Enter year: ");
            endYear = Convert.ToInt32(Console.ReadLine());

            endDate = new DateTime(endYear, endMonth, endDay);

            Console.WriteLine();
            Console.WriteLine("Please press [S] key to save the new course record or any other key to cancel");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.S)
            {
                _courses.Add(CourseFactory.CreateNewCourseObject(title, stream, type, startDate, endDate));
            }

            CourseView courseView = CourseFactory.CourseViewObject(_courses, _students, _trainers, _assignments);
            courseView.RunView();
        }
    }
}
