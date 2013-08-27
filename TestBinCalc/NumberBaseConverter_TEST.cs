using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Converters;
using binary_calculator.Wrappers.Integers;
using binary_calculator;
using binary_calculator.Enums;
using TestBinCalc.DemoObjects;



namespace TestBinCalc
{
    class NumberBaseConverter_TEST
    {
        static void Main(string[] args)
        {
            BinInteger_TEST();
            Console.ReadKey();
        }

        private static void DecInteger_TEST()
        {
            int testSize = 8;
            string testInput = "AB";
            int testCount = 1;

            Console.Write("Test Number: {0}\n\n", testCount++);
            DecInteger_DEMO dec = new DecInteger_DEMO(testSize, testInput);

        }

        private static void BinInteger_TEST()
        {
            int testSize = 8;
            string testInput = "64";
            int testCount = 1;
            Console.Write("Test Number: {0}\n\n", testCount++);
            BinInteger_DEMO test1 = new BinInteger_DEMO(testSize, testInput);

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.AddChar('a');

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ClearInput();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceStoredInput("111111111");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceStoredInput("");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceStoredInput("11111111");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceStoredInput("11111111");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceAllowedNumberOfBits(4);

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceAllowedNumberOfBits(8);

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceStoredInput("11111111");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceStoredInput("01010101");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceStoredInput("0101");

        }

        private static void NumberBase_TEST()
        {
            PowOfTwoBases numberBase = new PowOfTwoBases(PowOfTwoBases.BASE_TWO);

            Console.WriteLine(numberBase);

            string expectedValue = "BASE_TWO";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);

            numberBase.setChoice(PowOfTwoBases.BASE_EIGHT);
            expectedValue = "BASE_EIGHT";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);

            numberBase.setChoice(PowOfTwoBases.BASE_SIXTEEN);
            expectedValue = "BASE_SIXTEEN";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);

            numberBase.setChoice(PowOfTwoBases.BASE_TWO);
            expectedValue = "BASE_TWO";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);

            PowOfTwoBases numberBase2 = new PowOfTwoBases(numberBase);
            expectedValue = "BASE_TWO";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase2.numberBase, expectedValue);

            numberBase2.setChoice(PowOfTwoBases.BASE_SIXTEEN);
            numberBase.setChoice(numberBase2);
            expectedValue = "BASE_SIXTEEN";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);


        }
     

        

        


    }
}
