using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.Enums;

namespace TestBinCalc.TestObjects
{
    class UnfixedBinInteger_TEST: UnfixedBinInteger
    {
        public UnfixedBinInteger_TEST(string input)
            : base(input)
        {
            Console.Write("BinInteger instantiation!\n" +
                 "input: {0}\n" +
                 "input length: {1}\n" +
                 "storedInput:{2}\n" +
                 "storedInput length: {3}\n\n\n",
                 input, input.Length, this.storedInput, this.storedInput.Length);
        }

        public void AddChar_TEST(char value)
        {
            string potentialResult = string.Concat(this.storedInput, value.ToString());
            string oldStoredInput = this.storedInput;
            this.AddChar(value);
            Console.Write("AddChar _TEST!\n" +
                "char to add: {0}\n" +
                "Potential Result: {1}\n" +
                "Potential Result Length: {2}\n" +
                "Old storedInput: {5}\n" +
                "Old storedInput length: {6}\n" +
                "Result: {3}\n" +
                "Result Length: {4}\n\n\n",
                value, potentialResult, potentialResult.Length, 
                this.storedInput, this.storedInput.Length, oldStoredInput, oldStoredInput.Length);
        }

        public void DeleteChar_TEST()
        {
            string oldStoredInput = this.storedInput;
            this.deleteChar();
            Console.Write("DeleteChar _TEST!\n" +
                "Old storedInput: {2}\n" +
                "Old storedInput length: {3}\n" +
                "Result: {0}\n" +
                "Result Length: {1}\n\n\n",
                this.storedInput, this.storedInput.Length, oldStoredInput, oldStoredInput.Length);
        }

        public void AreAllCharsOfInputLegal_TEST(string input)
        {
            bool result = this.AreAllCharsOfInputLegal(input, NumberBases.BASE_TWO);
            Console.Write("AreAllCharsOfInputLegal_TEST!\n");
            Console.Write("input:{0}\n", input);
            Console.Write("Is input legal?: {0}\n", result);
            Console.Write("\n\n");
        }

        public void ClearInput_TEST()
        {
            string oldStoredInput = this.storedInput;
            ClearInput();
            Console.Write("ClearInput_TEST!\n" +
                "old storedInput: {0}\n" +
                "Result: {1}\n\n\n",
                oldStoredInput, this.storedInput);
        }

        public void ReplaceProperties_TEST(string input, int size)
        {
            Console.Write("ReplaceProperties_TEST start!\n\n");
            ReplaceStoredInput_TEST(input);
            Console.Write("ReplaceProperties_TEST end!\n\n\n");
        }

        public void ReplaceStoredInput_TEST(string value)
        {
            string oldStoredInput = this.storedInput;
            this.storedInput = value;
            Console.Write("ReplaceStoredInput_TEST!\n" +
                "input to be: {0}\n" +
                "input length: {5}\n" +
                "Old storedInput: {1}\n" +
                "Old storedInput length: {2}\n" +
                "Result: {3}\n" +
                "Result Length: {4}\n\n\n",
                value,
                oldStoredInput, oldStoredInput.Length, this.storedInput, this.storedInput.Length, value.Length);

        }


    }
}
