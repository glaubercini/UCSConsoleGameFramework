using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSConsoleGameFramework.Base;

namespace UCSConsoleGameFramework.Scenarios
{
    internal class PlayerCreation : Scene
    {
        public PlayerCreation()
        {
            Add("Você está na tela de criação do personagem.");

            UserOptionMessage = "Por favor, digite o nome abaixo:";
        }

        public override void ProcessOption(string playerOption)
        {
            if (string.IsNullOrWhiteSpace(playerOption))
            {
                Move(new PlayerCreation());
            }
            else
            {
                Player.Instance.Name = playerOption;
                Player.Instance.Life = 100;
                Player.Instance.Money = 200;

                Move(new City());
            }
        }
    }
}
