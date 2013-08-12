using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.NumberTypes;
using binary_calculator.Wrappers;
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

        private static void TestDecimalInt()
        {
            NumberBaseChoice choice = NumberBaseChoice.BASE_TWO;

            string testInput = "00000000";
            string expectedResult = "0";
            WrapperIntNonDecimal input = new WrapperIntNonDecimal(choice, 8, testInput);
            //DecimalInt dec = new DecimalInt(
        }

        private static void TestInputBinary()
        {
            NumberBaseChoice choice = NumberBaseChoice.BASE_TWO;
            
            string testInput = "";
            string expectedResult = "0";
            WrapperIntNonDecimal input = new WrapperIntNonDecimal(choice, 8, testInput);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nTest Input is: {4}\n Expected result is: {1}\n Result is: {2}\n" +
            "testInput length is: {5}\ninput length is {6} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedLength, testInput, testInput.Length, input.storedInput.Length);

            testInput = "00000000";
            expectedResult = "00000000";
            input = new WrapperIntNonDecimal(choice, 8, testInput);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nTest Input is: {4}\n Expected result is: {1}\n Result is: {2}\n" +
            "testInput length is: {5}\ninput length is {6} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedLength, testInput, testInput.Length, input.storedInput.Length);

            testInput = "11111111";
            expectedResult = "11111111";
            input = new WrapperIntNonDecimal(choice, 8, testInput);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nTest Input is: {4}\n Expected result is: {1}\n Result is: {2}\n" +
            "testInput length is: {5}\ninput length is {6} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedLength, testInput, testInput.Length, input.storedInput.Length);

            testInput = "10101010";
            expectedResult = "10101010";
            input = new WrapperIntNonDecimal(choice, 8, testInput);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nTest Input is: {4}\n Expected result is: {1}\n Result is: {2}\n" +
            "testInput length is: {5}\ninput length is {6} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedLength, testInput, testInput.Length, input.storedInput.Length);

            testInput = "23";
            expectedResult = "0";
            input = new WrapperIntNonDecimal(choice, 8, testInput);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nTest Input is: {4}\n Expected result is: {1}\n Result is: {2}\n" +
            "testInput length is: {5}\ninput length is {6} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedLength,testInput,testInput.Length,input.storedInput.Length);

            testInput = "010101010";
            expectedResult = "0";
            input = new WrapperIntNonDecimal(choice, 8, testInput);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nTest Input is: {4}\n Expected result is: {1}\n Result is: {2}\n" +
            "testInput length is: {5}\ninput length is {6} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedLength, testInput, testInput.Length, input.storedInput.Length);

            testInput = "1111";
            input = new WrapperIntNonDecimal(choice, 8, testInput);
            

            expectedResult = "1111";
            char charAdded = 'a';
            input.AddChar(charAdded);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nChar added is: {5}\n Expected result is: {1}\n Result is: {2}\n" +
            "input length is {4} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedLength, input.storedInput.Length,charAdded);

            expectedResult = "11110";
            charAdded = '0';
            input.AddChar(charAdded);
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\nChar added is: {5}\n Expected result is: {1}\n Result is: {2}\n" +
            "input length is {4} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedLength, input.storedInput.Length, charAdded);

            expectedResult = "1111";
            input.deleteChar();
            Console.Write("Number base is: {0}\nAllowed max length is: {3}\n Expected result is: {1}\n Result is: {2}\n" +
            "input length is {4} \n\n\n",
                choice, expectedResult, input.storedInput, input.allowedLength, input.storedInput.Length);
        }

        private static void TestBinaryInt()
        {
            WrapperIntDecimal input = new WrapperIntDecimal(8, "4");

            BinaryInt bin = new BinaryInt(input);
            string expectedValue = "00000100";
            Console.Write("Expected value is: {1}. Actual value is {0}\n",bin,expectedValue);

            input.deleteChar();
            bin.UpdateNumber(input);
            expectedValue = "00000000";
            Console.Write("Expected value is: {1}. Actual value is {0}\n", bin, expectedValue);

            input.deleteChar();
            bin.UpdateNumber(input);
            expectedValue = "00000000";
            Console.Write("Expected value is: {1}. Actual value is {0}\n", bin, expectedValue);

            input.AddChar('1');
            bin.UpdateNumber(input);
            expectedValue = "00000001";
            Console.Write("Expected value is: {1}. Actual value is {0}\n", bin, expectedValue);

            input.deleteChar();
            input.AddChar('2');
            bin.UpdateNumber(input);
            expectedValue = "00000010";
            Console.Write("Expected value is: {1}. Actual value is {0}\n", bin, expectedValue);

            input.AddChar('5');
            bin.UpdateNumber(input);
            expectedValue = "00011001";
            Console.Write("Expected value is: {1}. Actual value is {0}\n", bin, expectedValue);

            input.AddChar('5');
            bin.UpdateNumber(input);
            expectedValue = "11111111";
            Console.Write("Expected value is: {1}. Actual value is {0}\n", bin, expectedValue);

            input.ClearInput();
            bin.UpdateNumber(input);
            expectedValue = "00000000";
            Console.Write("Expected value is: {1}. Actual value is {0}\n", bin, expectedValue);

            input.AddChar('2');
            input.AddChar('5');
            input.AddChar('6');
            bin.UpdateNumber(input);
            expectedValue = "00011001";
            Console.Write("Expected value is: {1}. Actual value is {0}\n", bin, expectedValue);

        }

        private static void TestDecimalIntInput()
        {
            WrapperIntDecimal a = new WrapperIntDecimal();

            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:"+ 
            "{1}\nstoredInput should be 0 and is: {2}\nstoreNumber should be 0 and is: {3}\n\n\n"
                , a.bitNumber,a.maxSize,a.storedInput,a.storedNumber);

            string testNumber = "127";
            string expectedStoredInput = "127";
            long expectedStoredNumber = 127;
            a = new WrapperIntDecimal(8,testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber,testNumber,expectedStoredInput,expectedStoredNumber );

            testNumber = "256";
            expectedStoredInput = "0";
            expectedStoredNumber = 0;
            a = new WrapperIntDecimal(8, testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testNumber, expectedStoredInput, expectedStoredNumber);

            testNumber = "-1";
            expectedStoredInput = "0";
            expectedStoredNumber = 0;
            a = new WrapperIntDecimal(8, testNumber);
            Console.Write("bitNumber should be 8 and is: {0}.\nmaxSize should be 256 and is:{1}\n" +
            "storedInput should be {5} and is: {2}\nstoreNumber should be {6} and is: {3}\ntestNumber is: {4}\n\n\n"
                , a.bitNumber, a.maxSize, a.storedInput, a.storedNumber, testNumber, expectedStoredInput, expectedStoredNumber);

            testNumber = "2";
            expectedStoredInput = "2";
            expectedStoredNumber = 2;
            a = new WrapperIntDecimal(8, testNumber);
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
