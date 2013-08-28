using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.Integers;

namespace TestBinCalc.TestObjects
{
    public class DecInteger_TEST: DecInteger
    {
        public DecInteger_TEST(int size, string input)
            : base(size, input)
        {
            Console.Write("DecInteger instantiation!\n" +
                "size: {0}\n" +
                "input: {1}\n" +
                "input length: {4}\n" +
                "allowedNumberOfBits:{2}\n" +
                "storedInput:{3}\n" +
                "storedInput length: {5}\n"+
                "MaxSize: {6}\n"+
                "StoredNumber: {7}\n",
                size, input, this.allowedNumberOfBits, this.storedInput, input.Length, this.storedInput.Length,
                this.maxSize,this.storedNumber);

            
        }

        public void AddChar_TEST(char value)
        {
            string potentialResult = string.Concat(this.storedInput, value.ToString());
            string oldStoredInput = this.storedInput;
            long oldStoredNumber = this.storedNumber;
            this.AddChar(value);
            Console.Write("AddChar _TEST!\n" +
                "char to add: {0}\n" +
                "Potential Result: {1}\n" +
                "Potential Result Length: {2}\n" +
                "AllowedNumberOfBits: {3}\n" +
                "Old storedInput: {6}\n" +
                "Old storedInput length: {7}\n" +
                "old storedNumber: {8}\n"+
                "Result: {4}\n" +
                "Result Length: {5}\n"+
                "Result as long: {10}\n"+
                "maxSize: {9}\n\n\n",
                value, potentialResult, potentialResult.Length, this.allowedNumberOfBits,
                this.storedInput, this.storedInput.Length, oldStoredInput, oldStoredInput.Length,
                oldStoredNumber,this.maxSize,this.storedNumber);
        }

        public void DeleteChar_TEST()
        {
            string oldStoredInput = this.storedInput;
            long oldStoredNumber = this.storedNumber;
            this.deleteChar();
            Console.Write("DeleteChar _TEST!\n" +
                "AllowedNumberOfBits: {0}\n" +
                "MaxSize: {7}\n"+
                "Old storedInput: {3}\n" +
                "Old storedInput length: {4}\n" +
                "Old storedNumber: {5}\n" +
                "Result: {1}\n" +
                "Result Length: {2}\n"+
                "Result as long: {6}\n\n\n",
                 this.allowedNumberOfBits,
                this.storedInput, this.storedInput.Length, oldStoredInput, oldStoredInput.Length,oldStoredNumber,
                this.storedNumber,this.maxSize);
        }

        public void ClearInput_TEST()
        {
            string oldStoredInput = this.storedInput;
            long oldStoredNumber = this.storedNumber;
            ClearInput();
            Console.Write("ClearInput_TEST!\n" +
                "old storedInput: {0}\n" +
                "old storedNumber: {2}\n" +
                "Result: {1}\n"+
                "Result as long: {3}\n\n",
                oldStoredInput, this.storedInput,oldStoredNumber,this.storedNumber);
        }

        public void ReplaceStoredInput_TEST(string value)
        {
            string oldStoredInput = this.storedInput;
            long oldStoredNumber = this.storedNumber;
            this.storedInput = value;
            Console.Write("ReplaceStoredInput_TEST!\n" +
                "input to be: {0}\n" +
                "AllowedNumberOfBits: {1}\n" +
                "MaxSize: {6}\n"+
                "Old storedInput: {2}\n" +
                "Old storedInput length: {3}\n" +
                "old storedNumber: {7}\n"+
                "Result: {4}\n" +
                "Result Length: {5}\n"+
                "Result as long: {8}\n\n",
                value, this.allowedNumberOfBits,
                oldStoredInput, oldStoredInput.Length, this.storedInput, this.storedInput.Length,
                this.maxSize,oldStoredNumber,this.storedNumber);

        }

        public void ReplaceAllowedNumberOfBits_TEST(int value)
        {
            string oldStoredInput = this.storedInput;
            int oldSize = this.allowedNumberOfBits;
            long oldStoredNumber = this.storedNumber;
            int oldMaxSize = this.maxSize;

            this.allowedNumberOfBits = value;
            Console.Write("ReplaceAllowedNumberOfBits_TEST\n" +
                "old storedInput: {0}\n" +
                "old storedInput length: {1}\n" +
                "old storedNumber: {8}\n"+
                "old bit size: {2}\n" +
                "old max Size: {7}\n"+
                "Size to be: {3}\n" +
                "current storedInput: {4}\n" +
                "current storedInput length: {5}\n" +
                "current storedNumber: {9}\n"+
                "new size: {6}\n"+
                "new maxSize:{10}\n\n\n",
            oldStoredInput, oldStoredInput.Length, oldSize, value, this.storedInput, this.storedInput.Length,
            this.allowedNumberOfBits,oldMaxSize,oldStoredNumber,this.storedNumber,this.maxSize);
        }

        public void ReplaceProperties_TEST(string input, int size)
        {
            Console.Write("ReplaceProperties_TEST start!\n\n");
            ReplaceStoredInput_TEST(input);
            ReplaceAllowedNumberOfBits_TEST(size);
            Console.Write("ReplaceProperties_TEST end!\n\n\n");
        }

    }
}
