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
            Add(@"   /\                                                        /\   ");
            Add(@"  |  |                                                      |  |  ");
            Add(@" /----\                                                    /----\ ");
            Add(@"[______]                                                  [______]");
            Add(@" |    |         _____                        _____         |    | ");
            Add(@" |[]  |        [     ]                      [     ]        |  []| ");
            Add(@" |    |       [_______][ ][ ][ ][][ ][ ][ ][_______]       |    | ");
            Add(@" |    [ ][ ][ ]|     |  ,----------------,  |     |[ ][ ][ ]    | ");
            Add(@" |             |     |/'    ____..____    '\|     |             | ");
            Add(@"  \  []        |     |    /'    ||    '\    |     |        []  /  ");
            Add(@"   |      []   |     |   |o     ||     o|   |     |  []       |   ");
            Add(@"   |           |  _  |   |     _||_     |   |  _  |           |   ");
            Add(@"   |   []      | (_) |   |    (_||_)    |   | (_) |       []  |   ");
            Add(@"   |           |     |   |     (||)     |   |     |           |   ");
            Add(@"   |           |     |   |      ||      |   |     |           |   ");
            Add(@" /''           |     |   |o     ||     o|   |     |           ''\ ");
            Add(@"[_____________[_______]--'------''------'--[_______]_____________]");
        }

        public override void ProcessOption(string playerOption)
        {
            
        }
    }
}
