using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSConsoleGameFramework.Base;

namespace UCSConsoleGameFramework.Scenarios
{
    internal class City : Scene
    {
        public City()
        {
            Add("Você está na cidade, ela é fria como o gelo.");
            Add("-----------------");
            Add("---            --");
            Add("---            --");
            Add("---            --");
            Add("---     ___    --");
            Add("---    |   |   --");
            Add("1) Você deseja entrar no castelo?");
            Add("2) Você deseja ir para a floresta?");
        }

        public override void ProcessOption(string playerOption)
        {
            if (playerOption == "1")
            {
                Castle c = new Castle();
                Move(c);
            }
            else if (playerOption == "2")
            {
                Florest f = new Florest();
                Move(f);
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
