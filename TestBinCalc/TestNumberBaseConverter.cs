using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Converters;
using binary_calculator.Wrappers.Integers;
using binary_calculator;

namespace TestBinCalc
{
    class TestNumberBaseConverter
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }



     

        

        private static void TestDecimalIntInput()
        {
            DecWrapper a = new DecWrapper();

            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:"+ 
            "{1}\nstoredInput should be 0 and is: {2}\nstoreNumber should be 0 and is: {3}\n\n\n"
                , a.allowedNumberOfBits,a.maxSize,a.storedInput,a.storedNumber);

            string testNumber = "127";
            string expectedStoredInput = "127";
            long expectedStoredNumber = 127;
            a = new DecWrapper(8,testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.allowedNumberOfBits, a.maxSize, a.storedInput, a.storedNumber,testNumber,expectedStoredInput,expectedStoredNumber );

            testNumber = "256";
            expectedStoredInput = "0";
            expectedStoredNumber = 0;
            a = new DecWrapper(8, testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.allowedNumberOfBits, a.maxSize, a.storedInput, a.storedNumber, testNumber, expectedStoredInput, expectedStoredNumber);

            testNumber = "-1";
            expectedStoredInput = "0";
            expectedStoredNumber = 0;
            a = new DecWrapper(8, testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.allowedNumberOfBits, a.maxSize, a.storedInput, a.storedNumber, testNumber, expectedStoredInput, expectedStoredNumber);

            testNumber = "2";
            expectedStoredInput = "2";
            expectedStoredNumber = 2;
            a = new DecWrapper(8, testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.allowedNumberOfBits, a.maxSize, a.storedInput, a.storedNumber, testNumber, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();

            char testChar = '5';
            expectedStoredInput = "25";
            expectedStoredNumber = 25;
            a.AddChar(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.allowedNumberOfBits, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();

            testChar = '6';
            expectedStoredInput = "25";
            expectedStoredNumber = 25;
            a.AddChar(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.allowedNumberOfBits, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();

            testChar = '1';
            expectedStoredInput = "251";
            expectedStoredNumber = 251;
            a.AddChar(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.allowedNumberOfBits, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();


            expectedStoredInput = "25";
            expectedStoredNumber = 25;
            a.deleteChar();
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.allowedNumberOfBits, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();

            testChar = '5';
            expectedStoredInput = "255";
            expectedStoredNumber = 255;
            a.AddChar(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.allowedNumberOfBits, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();


            a.deleteChar();
            testChar = 'z';
            expectedStoredInput = "25";
            expectedStoredNumber = 25;
            a.AddChar(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.allowedNumberOfBits, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();
        }


    }
}
