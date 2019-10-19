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
        public string name;
        
        

        //constructor
        public Sweepstakes()
        {
            
        }
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            int countOfNewContestants = 1000;

            for (int i = 0; i < countOfNewContestants; i++)
            {
                Contestant contestan = new Contestant();
                contestant.RandomizeRegNumber();
                contestants.Add(contestant.regNumber, new Contestant());
            }
        }

        public Contestant PickWinner()
        {
            Contestant contestWinner = new Contestant();
            contestRegNumber = rng.Next(1, 1000);
            //if (contestRegNumber == contestants[contestRegNumber])//try to just reference the key
            //{
            //    return contestWinner;//should be new contestant in the dictionary being returned
            //}
            //else
            //{
            //    PickWinner();
            //}
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestRegNumber == contestant.Key)
                {
                    contestWinner = contestant.Value;
                }
            }
            return contestWinner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant);
        }
        //private void NotifyContestants()
        //{
        //    foreach (KeyValuePair<int, Contestant> contestant in contestants)
        //    {
        //        contestant.Notify()
        //    }
        //}

    }
}
