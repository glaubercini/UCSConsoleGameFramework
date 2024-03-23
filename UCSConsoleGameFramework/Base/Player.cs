using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSConsoleGameFramework.Base
{
    internal class Player
    {
        private static Player instance;

        public static Player Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Player();
                }

                return instance;
            }
        }

        public string Name;

        public int Life;

        public Backpack Backpack;

        public double Money;
        
        private Player()
        {
            Backpack = new Backpack();
        }
    }
}
