using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;
using Libraries.Views;

namespace PrivateSchoolConsoleApp
{
    class Program
    {
        static void Main()
        {
            bool programEnd = false;
            Students students = new Students();
            Courses courses = new Courses();
            Assignments assignments = new Assignments();
            Trainers trainers = new Trainers();
            courses[0].Students.Add(students[0]);
            courses[0].Trainers.Add(trainers[0]);
            courses[0].Trainers.Add(trainers[1]);
            courses[0].Assignments.Add(assignments[0]);
            courses[0].Assignments.Add(assignments[1]);
            courses[0].Assignments.Add(assignments[2]);

            while (!programEnd)
            {
                Console.Clear();
                Console.WriteLine(AppCommonOutputText.GetApplicationHeading());
                Console.WriteLine(AppCommonOutputText.GetInstructions());

                ConsoleKey instructionKey = Console.ReadKey().Key;

                switch (instructionKey)
                {
                    case ConsoleKey.C:
                        CourseView courseView = CourseFactory.CourseViewObject(courses, students, trainers, assignments);
                        courseView.RunView();
                        break;
                    case ConsoleKey.A:
                        AssignmentView assignmentView = AssignmentFactory.AssignmentViewObject(assignments);
                        assignmentView.RunView();
                        break;
                    case ConsoleKey.S:
                        StudentView studentView = StudentFactory.StudentViewObject(students);
                        studentView.RunView();
                        break;
                    case ConsoleKey.T:
                        TrainerView trainerView = TrainerFactory.TrainerViewObject(trainers);
                        trainerView.RunView();
                        break;
                    default:
                        programEnd = true;
                        break;
                }
            }
        }
    }
}
