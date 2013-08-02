using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.NumberTypes;

namespace TestBinCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            TestNoFixedSizeUnsignedInt();
            Console.ReadKey();
        }

        private static void TestNoFixedSizeUnsignedInt()
        {
            long testInput = 627732894;
            int testBase = 30;
            string expectedValue = "potato";

            NoFixedSizeUnsignedInt number1 = new NoFixedSizeUnsignedInt(testInput, testBase); //should display 'potato'
            Console.WriteLine("Expected value for {0} when the base is: {1}  is: {2}. Result is: {3}"
                ,testInput,testBase,expectedValue, number1.representationOfNumber);

            testBase = 43;
            number1.numberBase = testBase;
            Console.WriteLine("Attempt to set base as: {0}. Actual base is: {1}",testBase,number1.numberBase);

            testBase = 2;

            testInput = 1;
            expectedValue = "1";

            number1.numberBase = testBase;
            number1.UpdateNumber(testInput);
            Console.WriteLine("Expected value for {0} when the base is: {1}  is: {2}. Result is: {3}"
                , testInput, testBase, expectedValue, number1.representationOfNumber);

            testInput = 2;
            expectedValue = "10";
            number1.UpdateNumber(testInput);
            Console.WriteLine("Expected value for {0} when the base is: {1}  is: {2}. Result is: {3}"
                , testInput, testBase, expectedValue, number1.representationOfNumber);

            testInput = 3;
            expectedValue = "11";
            number1.UpdateNumber(testInput);
            Console.WriteLine("Expected value for {0} when the base is: {1}  is: {2}. Result is: {3}"
                , testInput, testBase, expectedValue, number1.representationOfNumber);

            testInput = 4;
            expectedValue = "100";
            number1.UpdateNumber(testInput);
            Console.WriteLine("Expected value for {0} when the base is: {1}  is: {2}. Result is: {3}"
                , testInput, testBase, expectedValue, number1.representationOfNumber);

            testInput = 7;
            expectedValue = "111";
            number1.UpdateNumber(testInput);
            Console.WriteLine("Expected value for {0} when the base is: {1}  is: {2}. Result is: {3}"
                , testInput, testBase, expectedValue, number1.representationOfNumber);

            testInput = 32;
            expectedValue = "100000";
            number1.UpdateNumber(testInput);
            Console.WriteLine("Expected value for {0} when the base is: {1}  is: {2}. Result is: {3}"
                , testInput, testBase, expectedValue, number1.representationOfNumber);
            
        }
    }
}
