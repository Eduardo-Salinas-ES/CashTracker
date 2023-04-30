using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };

            Guy bob = new Guy() { Cash = 100, Name = "Bob" };

            while(true)
            {
                int howMuchAsInt;

                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();

                if (howMuch == "") return;
                
                if(int.TryParse(howMuch, out howMuchAsInt))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();

                    if(whichGuy == "Joe")
                    {
                        joe.GiveCash(howMuchAsInt);
                        bob.ReceiveCash(howMuchAsInt);
                    }
                    else if(whichGuy == "Bob")
                    {
                        bob.GiveCash(howMuchAsInt);
                        joe.ReceiveCash(howMuchAsInt);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");

                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }


            }


        }
    }
}
