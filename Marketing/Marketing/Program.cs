﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingFirm marketingFirm = new MarketingFirm();
            marketingFirm.runSweepstakes();

            ManagerFactory manager = new ManagerFactory();
            manager.ChooseManager();
        }
    }
}
