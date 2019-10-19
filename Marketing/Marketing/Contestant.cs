using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    public class Contestant//you need to do this like lemonade stand so you generate contestants, but you also need user input when it comes to their info
    {
        //member variables
        public string firstName;
        public string lastName;
        public string eMail;
        public string address;
        public int regNumber;
        Random rng;

        //constructor
        public Contestant()
        {
            firstName = null;
            lastName = null;
            eMail = null;
            address = null;
            regNumber = 0;
            
        }

        //member methods
        public void RandomizeRegNumber()
        {
            regNumber = rng.Next(1, 1000);
        }
        //public void Notify(Contestant contestant)
        //{
        //    Contestant contestWinner = new Contestant();
        //    Console.WriteLine(contestWinner + " has won the sweepstakes!");
        //}
    }
}
