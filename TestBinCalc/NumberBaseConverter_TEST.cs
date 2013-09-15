using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Converters;
using binary_calculator.Wrappers.Integers;
using binary_calculator;
using binary_calculator.EnumsAndConstants;
using TestBinCalc.DemoObjects;



namespace TestBinCalc
{
    class NumberBaseConverter_TEST
    {
        static void Main(string[] args)
        {
            ConverterToDec_TEST1();
            Console.ReadKey();
        }

        

        private static void ConverterToDec_TEST1()
        {
            int testCount = 1;
            ConverterToDec_DEMO test = new ConverterToDec_DEMO(8, PowOfTwoBases.BASE_SIXTEEN);

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("0");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("1");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("10");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("11");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("100");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("111");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("1000");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("1010");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("1111");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("10000");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("11111");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("100000");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("1000000");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("10101010");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("100000000");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertBin("11111111");
        }

        private static void ConverterToBin_TEST1()
        {
            int testCount = 1;
            ConverterToBin_DEMO test = new ConverterToBin_DEMO(8, PowOfTwoBases.BASE_SIXTEEN);

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("0");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("1");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("2");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("3");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("4");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("7");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("8");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("10");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("15");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("16");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("31");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("32");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("64");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("128");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("170");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("255");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertDec("256");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertPowOfTwo("A");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertPowOfTwo("397d");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertPowOfTwo("6a");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ConvertUnfixedPowOfTwo("397d");

            
        }

        private static void UnfixedPowOfTwoInteger_TEST()
        {   
            string testInput = "GJ";
            int testCount = 1;

            Console.Write("Test Number: {0}\n\n", testCount++);
            UnfixedPowOfTwoInteger_DEMO test = new UnfixedPowOfTwoInteger_DEMO(PowOfTwoBases.BASE_SIXTEEN, testInput);

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ReplaceStoredInput("12B");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ClearInput();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ReplaceStoredInput("Abc");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.AddChar('N');

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.DeleteChar();

        }

        private static void UnfixedBinInteger_TEST()
        {
            string testInput = "AB";
            int testCount = 1;
            Console.Write("Test Number: {0}\n\n", testCount++);
            UnfixedBinInteger_DEMO test = new UnfixedBinInteger_DEMO(testInput);

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ReplaceStoredInput("1010");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ReplaceStoredInput("101010101010101010101010101010101010");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ClearInput();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.ReplaceStoredInput("101");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.AddChar('1');

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.AddChar('0');

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.AreAllCharsOfInputLegal("a");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.AreAllCharsOfInputLegal("5");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.AreAllCharsOfInputLegal("b");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test.AddChar('2');
        }

        private static void DecInteger_TEST()
        {
            int testSize = 8;
            string testInput = "AB";
            int testCount = 1;

            Console.Write("Test Number: {0}\n\n", testCount++);
            DecInteger_DEMO dec = new DecInteger_DEMO(testSize, testInput);

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.ReplaceStoredInput("64");

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.ReplaceStoredInput("-1");

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.ReplaceStoredInput("128");

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.ReplaceStoredInput("255");

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.AddChar('b');

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.AddChar('5');

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.AddChar('6');

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.DeleteChar();

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.ReplaceStoredInput("128");

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.ReplaceAllowedNumberOfBits(4);

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.ReplaceStoredInput("64");

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.ReplaceAllowedNumberOfBits(8);

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.ReplaceStoredInput("103");

            Console.Write("Test Number: {0}\n\n", testCount++);
            dec.ClearInput();

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
            test1.ReplaceStoredInput("111111111");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceStoredInput("");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceStoredInput("11111111");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ClearInput();

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceStoredInput("11111111");

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceAllowedNumberOfBits(4);

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceStoredInput("1111");

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

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceAllowedNumberOfBits(4);

            Console.Write("Test Number: {0}\n\n", testCount++);
            test1.ReplaceAllowedNumberOfBits(8);

        }

        private static void NumberBase_TEST()
        {
            PowOfTwoBases numberBase = new PowOfTwoBases(PowOfTwoBases.BASE_TWO);

            Console.WriteLine(numberBase);

            string expectedValue = "BASE_TWO";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);

            numberBase.SetChoice(PowOfTwoBases.BASE_EIGHT);
            expectedValue = "BASE_EIGHT";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);

            numberBase.SetChoice(PowOfTwoBases.BASE_SIXTEEN);
            expectedValue = "BASE_SIXTEEN";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);

            numberBase.SetChoice(PowOfTwoBases.BASE_TWO);
            expectedValue = "BASE_TWO";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);

            PowOfTwoBases numberBase2 = new PowOfTwoBases(numberBase);
            expectedValue = "BASE_TWO";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase2.numberBase, expectedValue);

            numberBase2.SetChoice(PowOfTwoBases.BASE_SIXTEEN);
            numberBase.SetChoice(numberBase2);
            expectedValue = "BASE_SIXTEEN";
            Console.Write("Base choice is expected to be {1} and is: {0}\n\n", numberBase.numberBase, expectedValue);


        }
     
    }
}
