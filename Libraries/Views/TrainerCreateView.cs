using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class TrainerCreateView
    {
        private Trainers _trainers;
        public TrainerCreateView(Trainers trainers)
        {
            _trainers = trainers;
        }

        public void RunCreateView()
        {
            string firstName;
            string lastName;
            string subject;
            

            Console.Clear();
            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());

            Console.WriteLine();
            Console.WriteLine(TrainerCommonOutputText.GetCreateHeading());

            Console.Write("First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Subject: ");
            subject = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Please press [S] key to save the new student record or any other key to cancel");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.S)
            {
                _trainers.Add(TrainerFactory.CreateNewTrainerObject(firstName, lastName, subject));
            }

            TrainerView trainerView = TrainerFactory.TrainerViewObject(_trainers);
            trainerView.RunView();
        }
    }
}
