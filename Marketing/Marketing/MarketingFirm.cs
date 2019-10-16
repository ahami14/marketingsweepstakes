using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    class MarketingFirm//this is like your run game glass
    {
        //member variables
        ManagerFactory manager;
        ISweepstakesManager choiceManager;
        Sweepstakes sweepstakes;
        Contestant contestant;

        //constructor
        public MarketingFirm()
        {
            manager = new ManagerFactory();
            Sweepstakes sweepstakes = new Sweepstakes();
        }

        //member methods
        public void runSweepstakes()
        {
            UserInterface.ChooseManager();
            manager.ChooseManager();
            choiceManager.GetSweepstakes();
            choiceManager.InsertSweepstakes(sweepstakes);
            UserInterface.RegContestant(contestant);
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PickWinner();
        }
    }
}
