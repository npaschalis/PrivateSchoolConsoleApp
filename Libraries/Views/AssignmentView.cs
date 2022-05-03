using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class AssignmentView
    {
        private Assignments _assignments;

        public AssignmentView(Assignments assignments)
        {
            _assignments = assignments;
        }

        public void RunView()
        {
            Console.Clear();
            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());
            AssignmentRecordsView assignmentRecordsView = AssignmentFactory.AssignmentRecordsViewObject(_assignments);
            assignmentRecordsView.RunRecordsView();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press:\n[A] to Add a new Assignment\n[U] to Update an Assignment's data\n[D] to Delete an Assignment\nor any other key to return to main menu");

            ConsoleKey instructionKey = Console.ReadKey().Key;

            switch (instructionKey)
            {
                case ConsoleKey.A:
                    AssignmentCreateView assignmentCreateView = AssignmentFactory.AssignmentCreateViewObject(_assignments);
                    assignmentCreateView.RunCreateView();
                    break;
               case ConsoleKey.U:
                     AssignmentUpdateView assignmentUpdateView = AssignmentFactory.AssignmentUpdateViewObject(_assignments);
                     assignmentUpdateView.RunUpdateView();
                     break;
                 case ConsoleKey.D:
                     AssignmentDeleteView assignmentDeleteView = AssignmentFactory.AssignmentDeleteViewObject(_assignments);
                     assignmentDeleteView.RunDeleteView();
                     break;
                default:
                    break;

            }
        }
    }
}
