using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Converters;
using binary_calculator.Wrappers.Integers;
using binary_calculator;
using binary_calculator.Enums;
using TestBinCalc.TestObjects;



namespace TestBinCalc
{
    class TestNumberBaseConverter
    {
        static void Main(string[] args)
        {
            BinInteger_TEST();
            Console.ReadKey();
        }

        private static void BinInteger_TEST()
        {
            int testSize = 8;
            string testInput = "64";
            BinInteger_TEST test1 = new BinInteger_TEST(testSize, testInput);

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
