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
            TestInputBinary();
            Console.ReadKey();
        }



        private static void TestInputBinary()
        {
            NumberBaseChoice choice = NumberBaseChoice.BASE_TWO;
            
            string testInput = "";
            string expectedResult = "0";
            BinOctHexWrapper input = new BinOctHexWrapper(choice, 8, testInput);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nTest Input is: {4}\n Expected result is: {1}\n Result is: {2}\n" +
            "testInput length is: {5}\ninput length is {6} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedNumberOfBits, testInput, testInput.Length, input.storedInput.Length);

            testInput = "00000000";
            expectedResult = "00000000";
            input = new BinOctHexWrapper(choice, 8, testInput);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nTest Input is: {4}\n Expected result is: {1}\n Result is: {2}\n" +
            "testInput length is: {5}\ninput length is {6} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedNumberOfBits, testInput, testInput.Length, input.storedInput.Length);

            testInput = "11111111";
            expectedResult = "11111111";
            input = new BinOctHexWrapper(choice, 8, testInput);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nTest Input is: {4}\n Expected result is: {1}\n Result is: {2}\n" +
            "testInput length is: {5}\ninput length is {6} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedNumberOfBits, testInput, testInput.Length, input.storedInput.Length);

            testInput = "10101010";
            expectedResult = "10101010";
            input = new BinOctHexWrapper(choice, 8, testInput);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nTest Input is: {4}\n Expected result is: {1}\n Result is: {2}\n" +
            "testInput length is: {5}\ninput length is {6} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedNumberOfBits, testInput, testInput.Length, input.storedInput.Length);

            testInput = "23";
            expectedResult = "0";
            input = new BinOctHexWrapper(choice, 8, testInput);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nTest Input is: {4}\n Expected result is: {1}\n Result is: {2}\n" +
            "testInput length is: {5}\ninput length is {6} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedNumberOfBits,testInput,testInput.Length,input.storedInput.Length);

            testInput = "010101010";
            expectedResult = "0";
            input = new BinOctHexWrapper(choice, 8, testInput);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nTest Input is: {4}\n Expected result is: {1}\n Result is: {2}\n" +
            "testInput length is: {5}\ninput length is {6} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedNumberOfBits, testInput, testInput.Length, input.storedInput.Length);

            testInput = "1111";
            input = new BinOctHexWrapper(choice, 8, testInput);
            

            expectedResult = "1111";
            char charAdded = 'a';
            input.AddChar(charAdded);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nChar added is: {5}\n Expected result is: {1}\n Result is: {2}\n" +
            "input length is {4} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedNumberOfBits, input.storedInput.Length,charAdded);

            expectedResult = "11110";
            charAdded = '0';
            input.AddChar(charAdded);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nChar added is: {5}\n Expected result is: {1}\n Result is: {2}\n" +
            "input length is {4} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedNumberOfBits, input.storedInput.Length, charAdded);

            expectedResult = "1111";
            input.deleteChar();
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\n Expected result is: {1}\n Result is: {2}\n" +
            "input length is {4} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedNumberOfBits, input.storedInput.Length);
        }

        

        private static void TestDecimalIntInput()
        {
            DecWrapper a = new DecWrapper();

            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:"+ 
            "{1}\nstoredInput should be 0 and is: {2}\nstoreNumber should be 0 and is: {3}\n\n\n"
                , a.bitNumber,a.maxSize,a.storedInput,a.storedNumber);

            string testNumber = "127";
            string expectedStoredInput = "127";
            long expectedStoredNumber = 127;
            a = new DecWrapper(8,testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber,testNumber,expectedStoredInput,expectedStoredNumber );

            testNumber = "256";
            expectedStoredInput = "0";
            expectedStoredNumber = 0;
            a = new DecWrapper(8, testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testNumber, expectedStoredInput, expectedStoredNumber);

            testNumber = "-1";
            expectedStoredInput = "0";
            expectedStoredNumber = 0;
            a = new DecWrapper(8, testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testNumber, expectedStoredInput, expectedStoredNumber);

            testNumber = "2";
            expectedStoredInput = "2";
            expectedStoredNumber = 2;
            a = new DecWrapper(8, testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testNumber, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();

            char testChar = '5';
            expectedStoredInput = "25";
            expectedStoredNumber = 25;
            a.AddChar(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();

            testChar = '6';
            expectedStoredInput = "25";
            expectedStoredNumber = 25;
            a.AddChar(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();

            testChar = '1';
            expectedStoredInput = "251";
            expectedStoredNumber = 251;
            a.AddChar(testChar);
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
            a.AddChar(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();


            a.deleteChar();
            testChar = 'z';
            expectedStoredInput = "25";
            expectedStoredNumber = 25;
            a.AddChar(testChar);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testChar, expectedStoredInput, expectedStoredNumber);
            Console.ReadKey();
        }


    }
}
