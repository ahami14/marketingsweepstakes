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
        public int regNumber;

        //constructor
        public Sweepstakes()
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

        public Contestant PickWinner(int regNumber, Contestant contestant)
        {
            contestant.RandomizeRegNumber();
            regNumber = contestant.regNumber;
            return regNumber;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
        public Sweepstakes(string name)
        {

        }
    }
}
