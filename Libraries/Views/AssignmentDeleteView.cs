using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class AssignmentDeleteView
    {
        private Assignments _assignments;
        public AssignmentDeleteView(Assignments assignments)
        {
            _assignments = assignments;
        }

        public void RunDeleteView()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the ID of the assignment you wish to delete.");

            int id = Convert.ToInt32(Console.ReadLine());

            int index = _assignments.Find(id);

            if (index != -1)
            {
                Assignment assignment = _assignments[index];
                Console.WriteLine($"Are you sure you wish to delete assignment with Id ({assignment.Id})? (y/n)");

                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Y)
                {
                    _assignments.Delete(index);
                }
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
