using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSConsoleGameFramework.Base
{
    internal class World
    {
        public int Lines;

        public int Columns;

        private string[,] Map;

        public World(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;

            Map = new string[Lines, Columns];
        }

        public void Fill()
        {
            for (int l = 0; l < Lines; l++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    if (l == 0 && c == 0)
                    {
                        Map[l,c] = "╔";
                    }
                    else if(c == 0 && l == (Lines - 1) )
                    {
                        Map[l, c] = "╚";
                    }
                    else if(l == 0 && c == (Columns - 1) )
                    {
                        Map[l, c] = "╗";
                    }
                    else if(l == (Lines - 1) && c == (Columns - 1))
                    {
                        Map[l, c] = "╝";
                    }
                    else if(c == 0 || c == (Columns - 1))
                    {
                        Map[l, c] = "║";
                    }
                    else if (l == 0 || l == (Lines - 1))
                    {
                        Map[l, c] = "═";
                    }
                    else
                    {
                        Map[l, c] = " ";
                    }
                }
            }
        }

        public int Draw(int line, int column, string phrase)
        {
            string newPhrase = phrase.Replace("\r\n", "\n");
            newPhrase = newPhrase.Replace("\r", "\n");
            newPhrase = newPhrase.Trim('\n').Trim('\t');

            int total_lines = 1;

            for (int col = column, pos = 0; pos < newPhrase.Length; col++, pos++)
            {
                char symbol = newPhrase[pos];
                if (symbol == '\n')
                {
                    line++;
                    col = column - 1;
                    total_lines++;
                }
                else
                {
                    Map[line, col] = symbol.ToString();
                }
            }

            return total_lines;
        }

        public void Print()
        {
            for (int l = 0; l < Lines; l++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    Console.Write(Map[l, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
