using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSConsoleGameFramework.Base
{
    internal abstract class Scene
    {
        private World World;

        private int Top;

        public Scene()
        {
            World = new World(20, 80);
            World.Fill();

            Top = 1;
        }

        public void Add(string text)
        {
            Top += World.Draw(Top, 1, text);
        }

        public string RequestUserOption()
        {
            Console.WriteLine("Qual a sua escolha?");
            string option = Console.ReadLine();

            return option;
        }

        public void Show()
        {
            World.Print();

            string playerOption = RequestUserOption();

            ProcessOption(playerOption);
        }

        public abstract void ProcessOption(string playerOption);

        public void Move(Scene scene)
        {
            Console.Clear();
            scene.Show();
        }
    }
}
