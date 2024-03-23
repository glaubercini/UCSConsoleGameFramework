using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSConsoleGameFramework.Base
{
    internal class Backpack
    {
        public List<Item> Items;

        public Backpack()
        { 
            Items = new List<Item>();
        }
    }
}
