using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;

namespace Libraries.Views
{
    public class AssignmentRecordsView
    {
        private Assignments _assignments;
        public AssignmentRecordsView(Assignments assignments)
        {
            _assignments = assignments;
        }
        public void RunRecordsView()
        {
            Console.WriteLine(AssignmentCommonOutputText.GetColumnHeadings());

            foreach (Assignment a in _assignments)
            {
                Console.WriteLine(a.GetAssignmentInformation());
            }
        }
    }
}
