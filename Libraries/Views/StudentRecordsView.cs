using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;

namespace Libraries.Views
{
    public class StudentRecordsView
    {
        private Students _students;
        public StudentRecordsView(Students students)
        {
            _students = students;
        }
        public void RunRecordsView()
        {
            Console.WriteLine(StudentCommonOutputText.GetColumnHeadings());

            foreach (Student stu in _students)
            {
                Console.WriteLine(stu.GetStudentInformation());
            }
        }
    }
}
