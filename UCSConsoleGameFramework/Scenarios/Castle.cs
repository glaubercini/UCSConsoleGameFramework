using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSConsoleGameFramework.Base;

namespace UCSConsoleGameFramework.Scenarios
{
    internal class Castle :Scene
    {
        public Castle()
        {
            Add("Você está no castelo");
        }

        public override void ProcessOption(string playerOption)
        {
            
        }
    }
}
