using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Factories;

namespace Libraries.Entities
{
    public class Students
    {
        List<Student> _studentList = new List<Student>();
        public Students()
        {
            SeedData();
        }

        public Student this[int index]
        {
            get
            {
                return (Student)_studentList[index];
            }
        }

        private void SeedData()
        {
            this.Add(StudentFactory.CreateNewStudentObject("Faith", "Young", new DateTime(1998, 02, 28), 2500));
            this.Add(StudentFactory.CreateNewStudentObject("Ismael", "Farmer", new DateTime(1997, 04, 17), 2250));
            this.Add(StudentFactory.CreateNewStudentObject("Terence", "Mendoza", new DateTime(2001, 12, 5), 2000));
            this.Add(StudentFactory.CreateNewStudentObject("Anthony", "Swanson", new DateTime(2000, 10, 11), 2100));
            this.Add(StudentFactory.CreateNewStudentObject("Madeline", "Aguilar", new DateTime(1990, 11, 20), 1500));
            this.Add(StudentFactory.CreateNewStudentObject("Diane", "Hernandez", new DateTime(1978, 07, 31), 2500));
            this.Add(StudentFactory.CreateNewStudentObject("Nelson", "Benson", new DateTime(2001, 03, 14), 2500));
            this.Add(StudentFactory.CreateNewStudentObject("Lillian", "Webster", new DateTime(1999, 07, 1), 1500));
            this.Add(StudentFactory.CreateNewStudentObject("Lance", "Mckinney", new DateTime(1998, 01, 2), 1750));
            this.Add(StudentFactory.CreateNewStudentObject("Irene", "Zimmerman", new DateTime(1976, 01, 22), 1000));
        }

        public void Add(Student student)
        {
            _studentList.Add(student);
        }

        public void Update(Student student, string firstName, string lastName, DateTime dateOfBirth, decimal tuitionFees)
        {
            student.FirstName = firstName;
            student.LastName = lastName;
            student.DateOfBirth = dateOfBirth;
            student.TuitionFees = tuitionFees;
        }

        public void Delete(int index)
        {
            _studentList.RemoveAt(index);
        }

        public int Find(int id)
        {
            int count = 0;
            foreach (Student student in _studentList)
            {
                if (student.Id == id)
                {
                    return count;
                }
                count++;
            }

            return -1;
        }

        public int Count()
        {
            return _studentList.Count;
        }


        public IEnumerator<Student> GetEnumerator()
        {
            return _studentList.GetEnumerator();
        }
    }
}

