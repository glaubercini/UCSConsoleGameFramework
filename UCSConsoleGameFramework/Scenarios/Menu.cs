using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSConsoleGameFramework.Base;

namespace UCSConsoleGameFramework.Scenarios
{
    internal class Menu : Scene
    {
        public Menu()
        {
            Add("1) Jogar");
            Add("2) Sair");
        }

        public override void ProcessOption(string playerOption)
        {
            if (playerOption == "1")
            {
                Move(new PlayerCreation());
            }
            else
            {
                Console.WriteLine("Você escolheu sair");
                Environment.Exit(0);
            }
        }
    }
}
