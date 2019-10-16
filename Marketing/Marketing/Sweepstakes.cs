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
        private Dictionary<int, Contestant> contestants;
        Random rng;
        public int contestRegNumber;
        public Contestant contestWinner;
        
        

        //constructor
        public Sweepstakes()
        {
            
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            int countOfNewContestants = 1000;

            for (int i = 0; i < countOfNewContestants; i++)
            {
                Contestant contestan = new Contestant();
                contestant.RandomizeRegNumber();
                contestants.Add(contestant.regNumber, new Contestant());//this will be dictionary, add contestant and key
            }
        }

        public Contestant PickWinner(Contestant contestant)
        {
            contestWinner = contestants[new Contestant()];
            contestRegNumber = rng.Next(1, 1000);
            if (contestRegNumber = contestants[contestRegNumber])//try to just reference the key
            {
                return contestWinner;//should be new contestant in the dictionary being returned
            }
            else
            {
                PickWinner(contestant);
            }
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
        public Sweepstakes(string name)
        {

        }
    }
}
