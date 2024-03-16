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
            newPhrase = newPhrase.Trim();

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

            //int l = line;
            //int c = column;
            //for (int i = 0; i < symbol.Length; i++)
            //{
            //    string current = symbol[i].ToString();
            //    if (current == "\n")
            //    {
            //        l++;
            //    }
            //}

            //for (int c = column, cont = 0; c < (symbol.Length + column); c++, cont++)
            //{
            //    Map[line, c] = $"{symbol[cont]}";
            //}
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

        public string Print(int rowsNumber, int columnsNumber)
        {
            if (rowsNumber < 2 || columnsNumber < 2)
                throw new Exception($@"Dimensões ({rowsNumber}x{columnsNumber}) inválidas");

            string word = string.Empty;
                for (int i = 0; i < rowsNumber; i++)
                {
                    if (i == 0)
                        word = "╔";
                    else if (i < rowsNumber - 1)
                        word += "\n║";
                    else
                        word += "\n╚";

                    for (int j = 0; j < columnsNumber - 2; j++)
                        if (i == 0 || i == rowsNumber - 1)
                            word += "═";
                        else
                            word += " ";

                    if (i == 0)
                        word += "╗";
                    else if (i < rowsNumber - 1)
                        word += "║";
                    else
                        word += "╝";
                }

                return word;
            }
        }
}
