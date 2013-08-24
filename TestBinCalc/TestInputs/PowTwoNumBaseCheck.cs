using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Enums;

namespace TestBinCalc.TestInputs
{
    public class PowTwoNumBaseCheck
    {
        public static void Test()
        {
            PowOfTwoBases numberBase = new PowOfTwoBases(PowOfTwoBases.BASE_TWO);

            Console.WriteLine(numberBase);

            string expectedValue = "BASE_TWO";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase,expectedValue);

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
