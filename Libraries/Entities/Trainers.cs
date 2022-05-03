using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Factories;

namespace Libraries.Entities
{
    public class Trainers
    {
        List<Trainer> _trainerList = new List<Trainer>();
        public Trainers()
        {
            SeedData();
        }

        public Trainer this[int index]
        {
            get
            {
                return (Trainer)_trainerList[index];
            }
        }

        private void SeedData()
        {
            this.Add(TrainerFactory.CreateNewTrainerObject("Chelsea", "Matthews", "C#, JavaScript"));
            this.Add(TrainerFactory.CreateNewTrainerObject("Taylor", "Cain", "SQL, HTML/CSS, JavaScript"));
            this.Add(TrainerFactory.CreateNewTrainerObject("Raymond", "Cross", "Java, Python"));
            this.Add(TrainerFactory.CreateNewTrainerObject("Karl", "Larson", "JavaScript, React, SQL"));
            this.Add(TrainerFactory.CreateNewTrainerObject("Monica", "Parsons", "HTML/CSS, JavaScript, Angular"));
        }

        public void Add(Trainer trainer)
        {
            _trainerList.Add(trainer);
        }

        public void Update(Trainer trainer, string firstName, string lastName, string subject)
        {
            trainer.FirstName = firstName;
            trainer.LastName = lastName;
            trainer.Subject = subject;
        }

        public void Delete(int index)
        {
            _trainerList.RemoveAt(index);
        }

        public int Find(int id)
        {
            int count = 0;
            foreach (Trainer trainer in _trainerList)
            {
                if (trainer.Id == id)
                {
                    return count;
                }
                count++;
            }

            return -1;
        }

        public int Count()
        {
            return _trainerList.Count;
        }


        public IEnumerator<Trainer> GetEnumerator()
        {
            return _trainerList.GetEnumerator();
        }
    }
}
