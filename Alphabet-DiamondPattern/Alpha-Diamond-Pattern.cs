using System;
using System.Collections.Generic;
using System.Text;

namespace Alphabet_DiamondPattern
{
    public class AlphaDiamondPattern
    {
        public static string PrintSpace(int n)
        {
            string spaceString = "";
            for (int i = 0; i < n; ++i)
            {
                //Console.Write(" ");
                spaceString += " "; 
            }

            return spaceString;
        }
        public static string printPattern(int n)
        {
            Console.WriteLine("\n Given Alphabet Character : " + (char)(n + 96));
            string patternString = ""; 
            // Top Section
            for (int i = 0; i < n; ++i)
            {
                // convert print character incremental order
                char printChar = (char)(i + 97);

                // first of all print all empty space then print first and last element of row index. 
                // space logic will e differnt for incremental order - top section and bottom section
                // Top section logic - top section iterate till total number of input.
                patternString += AlphaDiamondPattern.PrintSpace((n - i) * 2);
                for (int j = 0; j <= i * 2; ++j)
                {
                    if (j == 0 || j == i * 2)
                    {
                        //Console.Write(printChar + " ");
                        patternString += printChar + " ";
                    }
                    else
                    {
                        //Console.Write("  ");
                        patternString += "  ";
                    }
                }
                // Add new line
                //Console.WriteLine();
                patternString += "\n";
            }
            // Bottom Section
            // bottom section start iterate from skipping first element and print it reverse order
            // space will print in increasing order
            for (int i = 2; i <= n; ++i)
            {
                // convert print character in reverse order
                char printChar = (char)((n - i) + 97);
                patternString += AlphaDiamondPattern.PrintSpace(i * 2);
                for (int j = 0; j <= (n - i) * 2; ++j)
                {
                    if (j == 0 || j == (n - i) * 2)
                    {
                        //Console.Write(printChar + " ");
                        patternString += printChar + " ";
                    }
                    else
                    {
                        //Console.Write("  ");
                        patternString += "  ";
                    }
                }
                // Add new line
                //Console.WriteLine(); 
                patternString += "\n";
            }

            return patternString;
        }
    }
}
