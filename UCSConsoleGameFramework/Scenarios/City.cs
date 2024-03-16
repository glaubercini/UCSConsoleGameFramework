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
            Add(@"   ^    / \:/ \      ^               +                        |>");
            Add(@"  / \      ^        / \        *    / \    *              |>  |");
            Add(@" /   \             /   \      OnO  :xxx:  OnO             |  III     |>");
            Add(@"(_____)           (_____)     I I   I I   I I           /-|\ III i>  |");
            Add(@" |   |  _   _   _  |   |      I I   I I   I I         _|__|__III i   ^");
            Add(@" | O |_| |_| |_| |_| O |     O_O_O_O_O_O_O_O_O     |>\______/III i  ^^^");
            Add(@" |   |   - _^_     |   |     \_______________/     |   !__!__III/\ ^^^^^");
            Add(@" |  _|    //|\\  - |   |      I     ___     I     /\\ ////|====IIII ===");
            Add(@" |   |   ///|\\\   |  -|      I    / i \    I    /\\\/////|====IIII ===");
            Add(@" |-  |_  |||||||   |   |      I   I: i :I   I    | | ||||::::::IIII ===");
            Add(@" |   |   |||||||   |-  |      I___I:_i_:I___I    | | ||||      IIII ===");
            Add(@" |___|___|||||||___|___|                         -----------------------");
            Add(@"         (      (");
            Add(@"          \      \            . o       c ,              0   \0");
            Add(@"           )      )           `'#v-- --v#`'             /0--- :\");
            Add(@"           |      |            /'>     <`\              / >  / >");
            Add(@"           (      )");
            Add(@"            \      \");
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
