using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.NumberTypes;
using binary_calculator.Inputs;

namespace TestBinCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBinaryInt();
            Console.ReadKey();
        }

        private static void TestBinaryInt()
        {
            InputIntDecimal input = new InputIntDecimal(8, "4");

            BinaryInt bin = new BinaryInt(input);
            Console.WriteLine(bin);

        }

        private static void TestDecimalIntInput()
        {
            InputIntDecimal a = new InputIntDecimal();

            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:"+ 
            "{1}\nstoredInput should be blank and is: {2}\nstoreNumber should be 0 and is: {3}\n\n\n"
                , a.bitNumber,a.maxSize,a.storedInput,a.storedNumber);

            string testNumber = "127";
            string expectedStoredInput = "127";
            long expectedStoredNumber = 127;
            a = new InputIntDecimal(8,testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber,testNumber,expectedStoredInput,expectedStoredNumber );

            testNumber = "256";
            expectedStoredInput = "blank";
            expectedStoredNumber = 0;
            a = new InputIntDecimal(8, testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testNumber, expectedStoredInput, expectedStoredNumber);

            testNumber = "2";
            expectedStoredInput = "2";
            expectedStoredNumber = 2;
            a = new InputIntDecimal(8, testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testNumber, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();

            char testChar = '5';
            expectedStoredInput = "25";
            expectedStoredNumber = 25;
            a.Add(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();

            testChar = '6';
            expectedStoredInput = "25";
            expectedStoredNumber = 25;
            a.Add(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();

            testChar = '1';
            expectedStoredInput = "251";
            expectedStoredNumber = 251;
            a.Add(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();


            expectedStoredInput = "25";
            expectedStoredNumber = 25;
            a.deleteChar();
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();

            testChar = '5';
            expectedStoredInput = "255";
            expectedStoredNumber = 255;
            a.Add(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();


            a.deleteChar();
            testChar = 'z';
            expectedStoredInput = "25";
            expectedStoredNumber = 25;
            a.Add(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();
        }


    }
}
