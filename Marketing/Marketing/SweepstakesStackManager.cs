using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        //member variables
        private Stack<Sweepstakes> myStack;
        

        //constructor
        public SweepstakesStackManager()
        {
            
        }

        //member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myStack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return myStack.Pop();
        }
    }
}
