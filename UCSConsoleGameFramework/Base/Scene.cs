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

        public string UserOptionMessage;

        public Scene()
        {
            World = new World(22, 80);
            World.Fill();

            Top = 1;

            UserOptionMessage = "Qual a sua escolha?";

            if (!string.IsNullOrWhiteSpace(Player.Instance.Name))
            {
                Add($"Jogador: {Player.Instance.Name} | Vida: {Player.Instance.Life} | ${Player.Instance.Money}");
            }
        }

        public void Add(string text)
        {
            Top += World.Draw(Top, 1, text);
        }

        public string RequestUserOption()
        {
            Console.WriteLine(UserOptionMessage);
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
