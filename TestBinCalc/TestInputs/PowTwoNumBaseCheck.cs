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
            NumberBasesPowerOfTwo numberBase = new NumberBasesPowerOfTwo(NumberBasesPowerOfTwo.BaseChoice.BASE_TWO);
            string expectedValue = "BASE_TWO";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase,expectedValue);

            numberBase.setChoice(NumberBasesPowerOfTwo.BaseChoice.BASE_EIGHT);
            expectedValue = "BASE_EIGHT";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);

            numberBase.setChoice(NumberBasesPowerOfTwo.BaseChoice.BASE_SIXTEEN);
            expectedValue = "BASE_SIXTEEN";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);

            numberBase.setChoice(NumberBasesPowerOfTwo.BaseChoice.BASE_TWO);
            expectedValue = "BASE_TWO";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);

            
        }
    }
}
