using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class AssignmentUpdateView
    {

        private Assignments _assignments;

        public AssignmentUpdateView(Assignments assignments)
        {
            _assignments = assignments;
        }

        public void RunUpdateView()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the id of the assignment you wish to edit");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());

            int index = _assignments.Find(id);

            if (index != -1)
            {
                string title;
                string description;
                string day;
                string month;
                string year;
                string oralMark;
                string totalMark;

                int daySubmission;
                int monthSubmission;
                int yearSubmission;

                Assignment assignment = _assignments[index];

                Console.WriteLine(AssignmentCommonOutputText.GetUpdateHeading(assignment));
                Console.WriteLine(AssignmentCommonOutputText.GetUpdateViewAdditionalInstructions());

                Console.Write($"Title ({assignment.Title}): ");
                title = Console.ReadLine();

                Console.Write($"Description ({assignment.Description}): ");
                description = Console.ReadLine();

                Console.Write($"Submission date: Enter Day ({assignment.SubDateTime.Day}): ");
                day = Console.ReadLine();

                Console.Write($"Submission date: Enter Month ({assignment.SubDateTime.Month}): ");
                month = Console.ReadLine();

                Console.Write($"Submission date: Enter Year ({assignment.SubDateTime.Year}): ");
                year = Console.ReadLine();

                Console.Write($"Best Oral Mark ({assignment.OralMark}): ");
                oralMark = Console.ReadLine();

                Console.Write($"Best Total Mark ({assignment.TotalMark}): ");
                totalMark = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(day))
                {
                    daySubmission = assignment.SubDateTime.Day;
                }
                else
                {
                    daySubmission = Convert.ToInt32(day);
                }

                if (String.IsNullOrWhiteSpace(month))
                {
                    monthSubmission = assignment.SubDateTime.Month;
                }
                else
                {
                    monthSubmission = Convert.ToInt32(month);
                }

                if (String.IsNullOrWhiteSpace(year))
                {
                    yearSubmission = assignment.SubDateTime.Year;
                }
                else
                {
                    yearSubmission = Convert.ToInt32(year);
                }

                _assignments.Update(assignment,
                    (String.IsNullOrWhiteSpace(title) ? assignment.Title : title),
                    (String.IsNullOrWhiteSpace(description) ? assignment.Description : description),
                    new DateTime(yearSubmission, monthSubmission, daySubmission),
                    (String.IsNullOrWhiteSpace(oralMark) ? assignment.OralMark : Convert.ToInt32(oralMark)),
                    (String.IsNullOrWhiteSpace(totalMark) ? assignment.TotalMark : Convert.ToInt32(totalMark))
                );
            }
            else
            {
                Console.WriteLine(AssignmentCommonOutputText.GetAssignmentNotFoundMessage(id));
                Console.ReadKey();
            }
            AssignmentView assignmentView = AssignmentFactory.AssignmentViewObject(_assignments);
            assignmentView.RunView();
        }
    }
}
