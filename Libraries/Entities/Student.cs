using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Entities
{
    public class Student
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

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal TuitionFees { get; set; }

        public Student()
        {
            _nextId++;
            _id = _nextId;
        }

        public string GetStudentInformation()
        {
            string studentInformation = $"{Id.ToString().PadRight(6)}\t{FirstName.PadRight(15)}\t{LastName.PadRight(15)}\t{DateOfBirth.ToString("dd.MM.yyyy").PadRight(15)}\t{TuitionFees.ToString().PadRight(7)}";
            return studentInformation;
        }
    }
}
