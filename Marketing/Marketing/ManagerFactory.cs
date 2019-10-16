using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    public class ManagerFactory 
    {
        //member variables
        SweepstakesQueueManager sweepstakesQueueManager;
        SweepstakesStackManager sweepstakesStackManager;
        public string userInput;

        //constructor

        //member methods
        public void ChooseManager()
        {
            Console.WriteLine("Please input stack manager or queue manager:");
            userInput = Console.ReadLine();
            if(userInput == "stack manager")
            {
                SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
            }
            else
            {
                SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
            }

        }
        //public void InsertSweepstakes(Sweepstakes sweepstakes)
        //{

        //}
        //public Sweepstakes GetSweepstakes()
        //{

        //}
    }
}
