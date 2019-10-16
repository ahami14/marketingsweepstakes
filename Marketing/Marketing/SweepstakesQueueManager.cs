using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //member variables
        private Queue<string> myQueue;

        //constructor 

        //member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myQueue.Enqueue("Win a boat!");
            myQueue.Enqueue("Win up to $100,000!");
            myQueue.Enqueue("Wint a trip to Europe!");
            myQueue.Enqueue("Win a new car!");
            myQueue.Enqueue("Win a new kitchen set!");
        }
       public Sweepstakes GetSweepstakes()
        {
            myQueue.Dequeue();
            //same as stack manager note
        }
    }
}
