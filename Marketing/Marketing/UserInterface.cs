using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing
{
    public static class UserInterface
    {
        public static void RegContestant(Contestant contestant)
        {
            Console.WriteLine("Hello! Please register here! Enter your first name, last name, email, and address.");
            Console.WriteLine("A registration number will be randomly assigned to you.");
            Console.WriteLine("Please enter your first name.");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Please enter your email.");
            contestant.eMail = Console.ReadLine();
            Console.WriteLine("Please enter your address.");
            contestant.address = Console.ReadLine();
        }

        public static void ChooseManager()
        {
            Console.WriteLine("Please choose whether or not you would like a queue manager for your sweepstakes objects or stack manager.");
        }
    }
}
