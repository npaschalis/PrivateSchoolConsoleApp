using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class AssignmentCreateView
    {
        private Assignments _assignments;
        public AssignmentCreateView(Assignments assignments)
        {
            _assignments = assignments;
        }

        public void RunCreateView()
        {
            string title;
            string description;
            int day;
            int month;
            int year;
            DateTime subDateTime;
            int oralMark;
            int totalMark;

            Console.Clear();
            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());

            Console.WriteLine();
            Console.WriteLine(AssignmentCommonOutputText.GetCreateHeading());

            Console.Write("Title: ");
            title = Console.ReadLine();

            Console.Write("Description: ");
            description = Console.ReadLine();

            Console.Write("Day of Submission (1-31): ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Month of Submission (1-12): ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Year of Submission: ");
            year = Convert.ToInt32(Console.ReadLine());

            subDateTime = new DateTime(year, month, day);

            Console.Write("Best Oral Mark: ");
            oralMark = Convert.ToInt32(Console.ReadLine());

            Console.Write("Best Total Mark: ");
            totalMark = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please press [S] key to save the new student record or any other key to cancel");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.S)
            {
                _assignments.Add(AssignmentFactory.CreateNewAssignmentObject(title, description, subDateTime, oralMark, totalMark));
            }

            AssignmentView assignmentView = AssignmentFactory.AssignmentViewObject(_assignments);
            assignmentView.RunView();
        }
    }
}
