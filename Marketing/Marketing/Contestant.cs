using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    class Contestant
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
    }
}
