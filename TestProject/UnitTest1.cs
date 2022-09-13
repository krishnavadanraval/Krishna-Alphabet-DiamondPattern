using System;
using System.IO;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void ValidInput()
        {
            Console.SetIn(new StringReader("z"));
            //
            string mockConsolInput = Alphabet_DiamondPattern.Program.TakeUserInput();

            Assert.Equal("z", mockConsolInput);
        }

        [Fact]
        public void ValidPatternForInput_d()
        {
            Console.SetIn(new StringReader("d"));
            
            string mockConsolInput = Alphabet_DiamondPattern.Program.TakeUserInput();

            string mockOutputforAlphabet_d = "        a \n      b   b \n    c       c \n  d           d \n    c       c \n      b   b \n        a \n";

            int inputCharIndex = ((int)'d') - 96;
            string patternOutput = Alphabet_DiamondPattern.AlphaDiamondPattern.printPattern(inputCharIndex);
            Assert.Equal(mockOutputforAlphabet_d, patternOutput);
        }

        [Fact]
        public void InValidInputNumber()
        {
            // on readline insert invalid input 
            Console.SetIn(new StringReader("9"));
           
            string methodOutputWhenInvalidInput = Alphabet_DiamondPattern.Program.TakeUserInput();

            // Should throw this error Message 
            string errorMessage = "Invalid Input ";
            
            Assert.Equal(errorMessage, methodOutputWhenInvalidInput);
        }

        [Fact]
        public void InValidInputString()
        {
            // on readline insert invalid input 
            Console.SetIn(new StringReader("Hi hello"));

            string methodOutputWhenInvalidInput = Alphabet_DiamondPattern.Program.TakeUserInput();

            // Should throw this error Message 
            string errorMessage = "Invalid Input ";

            Assert.Equal(errorMessage, methodOutputWhenInvalidInput);
        }

        [Fact]
        public void InValidInputSpecialChar()
        {
            // on readline insert invalid input 
            Console.SetIn(new StringReader("#"));

            string methodOutputWhenInvalidInput = Alphabet_DiamondPattern.Program.TakeUserInput();

            // Should throw this error Message 
            string errorMessage = "Invalid Input ";

            Assert.Equal(errorMessage, methodOutputWhenInvalidInput);
        }

        [Fact]
        public void InValidInputEmptySpace()
        {
            // on readline insert invalid input 
            Console.SetIn(new StringReader(" "));

            string methodOutputWhenInvalidInput = Alphabet_DiamondPattern.Program.TakeUserInput();

            // Should throw this error Message 
            string errorMessage = "Invalid Input ";

            Assert.Equal(errorMessage, methodOutputWhenInvalidInput);
        }

    }
}
