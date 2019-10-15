using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    public class Sweepstakes
    {
        //member variables
        //dictionary will be in this class
        public Dictionary<int, Contestant> contestants;

        //constructor
        public Sweepstakes(string name)
        {
            
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            int countOfNewContestants = 1000000;

            for (int i = 0; i < countOfNewContestants; i++)
            {
                Contestant contestan = new Contestant();
                contestant.RandomizeRegNumber();
                contestants.Add(contestant.regNumber, new Contestant());//this will be dictionary, add contestant and key
            }
        }

        public Contestant PickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
