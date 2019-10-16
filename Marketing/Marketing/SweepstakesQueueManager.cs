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
        private Queue<Sweepstakes> myQueue;

        //constructor 
        public SweepstakesQueueManager()
        {

        }

        //member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myQueue.Enqueue(sweepstakes);
        }
       public Sweepstakes GetSweepstakes()
        { 
            return myQueue.Dequeue();
        }
    }
}
