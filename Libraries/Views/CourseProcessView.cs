using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class CourseProcessView
    {
        private Course _course;
        private Courses _courses;
        private Students _students;
        private Trainers _trainers;
        private Assignments _assignments;

        public CourseProcessView(Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            _course = course;
            _courses = courses;
            _students = students;
            _trainers = trainers;
            _assignments = assignments;
        }

        public void RunProcessView()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the id of the course you wish to update");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());

            int index = _courses.Find(id);

            if (index != -1)
            {
                Course course = _courses[index];

                Console.WriteLine(CourseCommonOutputText.GetUpdateHeading(course));

                Console.WriteLine();
                Console.WriteLine("TRAINERS:");
                Console.WriteLine("---------");
                Console.WriteLine(TrainerCommonOutputText.GetColumnHeadings());
                foreach (Trainer t in course.Trainers)
                {
                    Console.WriteLine(t.GetTrainerInformation());
                }

                Console.WriteLine();
                Console.WriteLine("STUDENTS:");
                Console.WriteLine("---------");
                Console.WriteLine(StudentCommonOutputText.GetColumnHeadings());
                foreach (Student stu in course.Students)
                {
                    Console.WriteLine(stu.GetStudentInformation());
                }

                Console.WriteLine();
                Console.WriteLine("ASSIGNMENTS:");
                Console.WriteLine("------------");
                Console.WriteLine(AssignmentCommonOutputText.GetColumnHeadings());
                foreach (Assignment a in course.Assignments)
                {
                    Console.WriteLine(a.GetAssignmentInformation());
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Press:\n[A] to add a student to the course");
                Console.WriteLine("[B] to remove a student from the course");
                Console.WriteLine("[C] to add a trainer to the course");
                Console.WriteLine("[D] to remove a trainer from the course");
                Console.WriteLine("[E] to add an assignment to the course");
                Console.WriteLine("[F] to remove an assignment from the course");
                Console.WriteLine("or any other key to return to courses menu");

                ConsoleKey instructionKey = Console.ReadKey().Key;

                switch (instructionKey)
                {
                    case ConsoleKey.A:
                        AddStudentToCourseView addStudentToCourseView = CourseFactory.AddStudentToCourseViewObject(course, _courses, _students, _trainers, _assignments);
                        addStudentToCourseView.RunView();
                        break;
                    case ConsoleKey.B:
                        RemoveStudentFromCourseView removeStudentFromCourseView = CourseFactory.RemoveStudentFromCourseViewObject(course, _courses, _students, _trainers, _assignments);
                        removeStudentFromCourseView.RunView();
                        break;
                    case ConsoleKey.C:
                        AddTrainerToCourseView addTrainerToCourseView = CourseFactory.AddTrainerToCourseViewObject(course, _courses, _students, _trainers, _assignments);
                        addTrainerToCourseView.RunView();
                        break;
                    case ConsoleKey.D:
                        RemoveTrainerFromCourseView removeTrainerFromCourseView = CourseFactory.RemoveTrainerFromCourseViewObject(course, _courses,_students, _trainers, _assignments);
                        removeTrainerFromCourseView.RunView();
                        break;

                    case ConsoleKey.E:
                        AddAssignmentToCourseView addAssignmentToCourseView = CourseFactory.AddAssignmentToCourseViewObject(course, _courses, _students, _trainers, _assignments);
                        addAssignmentToCourseView.RunView();
                        break;
                    case ConsoleKey.F:
                        RemoveAssignmentFromCourseView removeAssignmentFromCourseView = CourseFactory.RemoveAssignmentFromCourseViewObject(course, _courses, _students, _trainers, _assignments);
                        removeAssignmentFromCourseView.RunView();
                        break;
                    default:
                        
                        break;
                }
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
