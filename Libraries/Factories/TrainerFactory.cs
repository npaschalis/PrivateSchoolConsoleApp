using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Views;

namespace Libraries.Factories
{
    public static class TrainerFactory
    {
        private static TrainerView _trainerView;
        private static TrainerCreateView _trainerCreateView;
        private static TrainerUpdateView _trainerUpdateView;
        private static TrainerDeleteView _trainerDeleteView;
        public static Trainer CreateNewTrainerObject(string firstName, string lastName, string subject)
        {
            return new Trainer
            {
                FirstName = firstName,
                LastName = lastName,
                Subject = subject
            };
        }

        public static TrainerRecordsView TrainerRecordsViewObject(Trainers trainers)
        {
            return new TrainerRecordsView(trainers);
        }

        public static TrainerView TrainerViewObject(Trainers trainers)
        {
            if (_trainerView == null)
            {
                _trainerView = new TrainerView(trainers);
            }

            return new TrainerView(trainers);
        }

        public static TrainerCreateView TrainerCreateViewObject(Trainers trainers)
        {
            if (_trainerCreateView == null)
            {
                _trainerCreateView = new TrainerCreateView(trainers);
            }

            return new TrainerCreateView(trainers);
        }

        public static TrainerUpdateView TrainerUpdateViewObject(Trainers trainers)
        {
            if (_trainerUpdateView == null)
            {
                _trainerUpdateView = new TrainerUpdateView(trainers);
            }

            return new TrainerUpdateView(trainers);
        }

        public static TrainerDeleteView TrainerDeleteViewObject(Trainers trainers)
        {
            if (_trainerDeleteView == null)
            {
                _trainerDeleteView = new TrainerDeleteView(trainers);
            }

            return new TrainerDeleteView(trainers);
        }
    }
}
