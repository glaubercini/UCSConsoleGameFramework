using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSConsoleGameFramework.Scenarios;

namespace UCSConsoleGameFramework.Base
{
    internal class Potions : Scene
    {
        public Potions(string playerOption)
        {
            if (playerOption == "1")
            {
                Add("This will cost 10 gold");
                Add("It is that all stranger?");
                Add("1) Yes");
                Add("2) No");
            }
            else if (playerOption == "2")
            {
                Add("This will cost 12 gold");
                Add("It is that all stranger?");
                Add("1) Yes");
                Add("2) No");
            }
            else if (playerOption == "3")
            {
                Add("This will cost 8 gold");
                Add("It is that all stranger?");
                Add("1) Yes");
                Add("2) No");
            }
            else if (playerOption == "4")
            {
                Add("This will cost 15 gold");
                Add("It is that all stranger?");
                Add("1) Yes");
                Add("2) No");
            }
            else if (playerOption == "5")
            {
                Add("This will cost 20 gold");
                Add("It is that all stranger?");
                Add("1) Yes");
                Add("2) No");
            }
        }

        public override void ProcessOption(string playerOption)
        {
            if (playerOption == "1")
            {
                City c = new City();
                Move(c);
            }
            else if (playerOption == "2")
            {
                Shop shop = new Shop();
                Move(shop);
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}
