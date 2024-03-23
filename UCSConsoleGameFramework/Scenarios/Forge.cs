using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSConsoleGameFramework.Base;

namespace UCSConsoleGameFramework.Scenarios
{
    internal class Forge : Scene
    {
        public Forge()
        {
            Add("Você está no ferreiro");

            Add("");
            Add("               /\\_[]_/\\       Possuimos diversas  ");
            Add("              |] _||_ [|        Espadas, Machados,  ");
            Add("       ___     \\/ || \\/       Arcos e Flechas!!!  ");
            Add("      /___\\       ||                               ");
            Add("     (|0 0|)      ||                                ");
            Add("   __/{\\U/}\\_ ___/vvv                             ");
            Add("  / \\  {~}   / _|_P|                               ");
            Add("  | /\\  ~   /_/   []                               ");
            Add("  |_| (____)                                        ");
            Add("  \\_]/______\\                                     ");
            Add("    _\\_||_/_                                       ");
            Add("    (_,_||_,_)                                      ");

            Add("");

            Add("voce deseja ir para  cidadde? 2)");
            Add("voce deseja ir para castelo? 3)");
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
                Florest f = new Florest();
                Move(f);
            }
            else
            {
                Console.WriteLine("Opção invalida");
            }
        }

    }
}
