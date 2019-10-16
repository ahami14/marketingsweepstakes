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
        private Stack<string> myStack;

        //constructor
        public SweepstakesStackManager()
        {
            
        }

        //member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)//start with 3 idk what we are doin
        {
            myStack.Push("Win a boat!");
            myStack.Push("Win up to $100,000!");
            myStack.Push("Wint a trip to Europe!");
            myStack.Push("Win a new car!");
            myStack.Push("Win a new kitchen set!");
        }
        public Sweepstakes GetSweepstakes()
        {
            string firstSweepstake = myStack.Pop();
            return firstSweepstake;
            //may potentially have a loop here so we can pop a new one everytime, needs a return
        }
    }
}
