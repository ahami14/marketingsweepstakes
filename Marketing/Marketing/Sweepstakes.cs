using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    class Sweepstakes
    {
        //member variables
          //dictionary will be in this class

        //constructor
        public Sweepstakes(string name)
        {

        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestant = new Contestant();
            Console.WriteLine("First Name:");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Last Name");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Email:");
            contestant.eMail = Console.ReadLine();
            Console.WriteLine("Address:");
            contestant.address = Console.ReadLine();
            contestant.RandomizeRegNumber();
            //we can call an rng function in here to get a reg key, then log it to the dictionary when that is created
        }

        public Contestant PickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
