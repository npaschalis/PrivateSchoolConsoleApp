using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class CourseUpdateView
    {
        private Courses _courses;
        private Students _students;
        private Trainers _trainers;
        private Assignments _assignments;

        public CourseUpdateView(Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            _courses = courses;
            _students = students;
            _trainers = trainers;
            _assignments = assignments;
        }

        public void RunUpdateView()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the id of the course you wish to edit");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());

            int index = _courses.Find(id);

            if (index != -1)
            {
                string title;
                string stream;
                string type;
                string sday;
                string smonth;
                string syear;
                string eday;
                string emonth;
                string eyear;

                int dayStart;
                int monthStart;
                int yearStart;

                int dayEnd;
                int monthEnd;
                int yearEnd;

                Course course = _courses[index];

                Console.WriteLine(CourseCommonOutputText.GetUpdateHeading(course));
                Console.WriteLine(CourseCommonOutputText.GetUpdateViewAdditionalInstructions());

                Console.Write($"Title ({course.Title}): ");
                title = Console.ReadLine();

                Console.Write($"Stream ({course.Stream}): ");
                stream = Console.ReadLine();

                Console.Write($"Type ({course.Type}): ");
                type = Console.ReadLine();

                Console.Write($"Day of Start Date ({course.StartDate.Day}): ");
                sday = Console.ReadLine();

                Console.Write($"Month of Start Date ({course.StartDate.Month}): ");
                smonth = Console.ReadLine();

                Console.Write($"Year of Start Date ({course.StartDate.Year}): ");
                syear = Console.ReadLine();

                Console.Write($"Day of End Date ({course.EndDate.Day}): ");
                eday = Console.ReadLine();

                Console.Write($"Month of End Date ({course.EndDate.Month}): ");
                emonth = Console.ReadLine();

                Console.Write($"Year of End Date ({course.EndDate.Year}): ");
                eyear = Console.ReadLine();


                if (String.IsNullOrWhiteSpace(sday))
                {
                    dayStart = course.StartDate.Day;
                }
                else
                {
                    dayStart = Convert.ToInt32(sday);
                }

                if (String.IsNullOrWhiteSpace(smonth))
                {
                    monthStart = course.StartDate.Month;
                }
                else
                {
                    monthStart = Convert.ToInt32(smonth);
                }

                if (String.IsNullOrWhiteSpace(syear))
                {
                    yearStart = course.StartDate.Year;
                }
                else
                {
                    yearStart = Convert.ToInt32(syear);
                }


                if (String.IsNullOrWhiteSpace(eday))
                {
                    dayEnd = course.EndDate.Day;
                }
                else
                {
                    dayEnd = Convert.ToInt32(eday);
                }

                if (String.IsNullOrWhiteSpace(emonth))
                {
                    monthEnd = course.EndDate.Month;
                }
                else
                {
                    monthEnd = Convert.ToInt32(emonth);
                }

                if (String.IsNullOrWhiteSpace(eyear))
                {
                    yearEnd = course.EndDate.Year;
                }
                else
                {
                    yearEnd = Convert.ToInt32(eyear);
                }

                _courses.Update(course,
                    (String.IsNullOrWhiteSpace(title) ? course.Title : title),
                    (String.IsNullOrWhiteSpace(stream) ? course.Stream : stream),
                    (String.IsNullOrWhiteSpace(type) ? course.Type : type),
                    new DateTime(yearStart, monthStart, dayStart),
                    new DateTime(yearEnd, monthEnd, dayEnd)
                );
            }
            else
            {
                Console.WriteLine(CourseCommonOutputText.GetCourseNotFoundMessage(id));
                Console.ReadKey();
            }
            CourseView courseView = CourseFactory.CourseViewObject(_courses, _students, _trainers, _assignments);
            courseView.RunView();
        }
    }
}
