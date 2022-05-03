using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Factories;

namespace Libraries.Entities
{
    public class Assignments
    {
        List<Assignment> _assignmentList = new List<Assignment>();
        public Assignments()
        {
            SeedData();
        }

        public Assignment this[int index]
        {
            get
            {
                return (Assignment)_assignmentList[index];
            }
        }

        private void SeedData()
        {
            this.Add(AssignmentFactory.CreateNewAssignmentObject("Assignment 1 full-time", "Create a simple timer. To make it more unique, you can build a countdown timer that stops at a user-specified value.", new DateTime(2022, 01, 15), 25, 100));
            this.Add(AssignmentFactory.CreateNewAssignmentObject("Assignment 2 full-time", "Build a simple to-do list application. Using event handlers, you'll instantiate forms for entering every task and display them on submission.", new DateTime(2022, 01, 31), 25, 100));
            this.Add(AssignmentFactory.CreateNewAssignmentObject("Assignment 3 full-time", "Build a budgeting application. While writing your code, you'll collect form inputs and subtract expenses from your budget...", new DateTime(2022, 02, 15), 25, 100));
            this.Add(AssignmentFactory.CreateNewAssignmentObject("Assignment 1 part-time", "Create a simple timer. To make it more unique, you can build a countdown timer that stops at a user-specified value.", new DateTime(2022, 01, 30), 25, 100));
            this.Add(AssignmentFactory.CreateNewAssignmentObject("Assignment 2 part-time", "Build a simple to-do list application. Using event handlers, you'll instantiate forms for entering every task and display them on submission.", new DateTime(2022, 02, 28), 25, 100));
            this.Add(AssignmentFactory.CreateNewAssignmentObject("Assignment 3 part-time", "Build a budgeting application. While writing your code, you'll collect form inputs and subtract expenses from your budget...", new DateTime(2022, 03, 31), 25, 100));
        }

        public void Add(Assignment assignment)
        {
            _assignmentList.Add(assignment);
        }

        public void Update(Assignment assignment, string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
            assignment.Title = title;
            assignment.Description = description;
            assignment.SubDateTime = subDateTime;
            assignment.OralMark = oralMark;
            assignment.TotalMark = totalMark;
        }

        public void Delete(int index)
        {
            _assignmentList.RemoveAt(index);
        }

        public int Find(int id)
        {
            int count = 0;
            foreach (Assignment assignment in _assignmentList)
            {
                if (assignment.Id == id)
                {
                    return count;
                }
                count++;
            }

            return -1;
        }

        public int Count()
        {
            return _assignmentList.Count;
        }


        public IEnumerator<Assignment> GetEnumerator()
        {
            return _assignmentList.GetEnumerator();
        }
    }
}
