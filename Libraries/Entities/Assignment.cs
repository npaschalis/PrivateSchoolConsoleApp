using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Entities
{
    public class Assignment
    {
        private static int _nextId = 0;
        private int _id = 0;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }

        public Assignment()
        {
            _nextId++;
            _id = _nextId;
        }

        public string GetAssignmentInformation()
        {
            string assignmentInformation = $"{Id.ToString().PadRight(6)}\t{Title.PadRight(25)}\t{SubDateTime.ToString("dd.MM.yyyy").PadRight(15)}\t{OralMark.ToString().PadRight(6)}\t{TotalMark.ToString().PadRight(6)}";
            return assignmentInformation;
        }
    }
}
