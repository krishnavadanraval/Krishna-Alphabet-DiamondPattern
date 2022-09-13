using System;

namespace Alphabet_DiamondPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput = TakeUserInput();
            string patternOutput = "";
            //Console.WriteLine(userInput);
            if (userInput.Length == 1 && userInput != "Invalid Input ")
            {
                int rowIndex = (((int)userInput[0]) - 96);
                patternOutput = AlphaDiamondPattern.printPattern(rowIndex);
            }
            else { 
                Main(args);
            }

            Console.WriteLine(patternOutput);

            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }


       public static string TakeUserInput()
        {
            Console.WriteLine("Input any Alphabet : ");
            string alphabets = "abcdefghijklmnopqrstuvwxyz";

            var input = Console.ReadLine().ToLower();
            string inputChar = " ";
            if (alphabets.Contains(input) && input.Length == 1)
            {
                inputChar = input;
            }
            else
            {
                Console.WriteLine("Invalid Input ");
                return inputChar = "Invalid Input ";
                //inputChar = TakeUserInput();
            }
            return inputChar;
        }
    }
}
