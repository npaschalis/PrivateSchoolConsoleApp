using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class TrainerUpdateView
    {
        private Trainers _trainers;

        public TrainerUpdateView(Trainers trainers)
        {
            _trainers = trainers;
        }

        public void RunUpdateView()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the id of the trainer you wish to edit");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());

            int index = _trainers.Find(id);

            if (index != -1)
            {
                string firstName;
                string lastName;
                string subject;

                Trainer trainer = _trainers[index];

                Console.WriteLine(TrainerCommonOutputText.GetUpdateHeading(trainer));
                Console.WriteLine(TrainerCommonOutputText.GetUpdateViewAdditionalInstructions());

                Console.Write($"First Name ({trainer.FirstName}): ");
                firstName = Console.ReadLine();

                Console.Write($"Last Name ({trainer.LastName}): ");
                lastName = Console.ReadLine();

                Console.Write($"Subject ({trainer.Subject}): ");
                subject = Console.ReadLine();

                _trainers.Update(trainer,
                    (String.IsNullOrWhiteSpace(firstName) ? trainer.FirstName : firstName),
                    (String.IsNullOrWhiteSpace(lastName) ? trainer.LastName : lastName),
                    (String.IsNullOrWhiteSpace(subject) ? trainer.Subject : subject)
                );
            }
            else
            {
                Console.WriteLine(TrainerCommonOutputText.GetTrainerNotFoundMessage(id));
                Console.ReadKey();
            }
            TrainerView trainerView = TrainerFactory.TrainerViewObject(_trainers);
            trainerView.RunView();
        }
    }
}
