using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.EnumsAndConstants;

namespace TestBinCalc.TestObjects
{
    class UnfixedPowOfTwoInterger_TEST: UnfixedPowOfTwoInteger
    {
        public UnfixedPowOfTwoInterger_TEST(PowOfTwoBases choice, string input)
            : base(choice, input)
        {
            Console.Write("UnfixedPowOfTwoInterger_TEST Instantiation!\n\n");
            Console.Write("Parameter Number Base is: {0}\n", choice);
            Console.Write("Stored number base is: {0}\n",this.GetNumberBase());
            Console.Write("Parameter input: {0}\n",input);
            Console.Write("Parameter input length: {0}\n",input.Length);
            Console.Write("Stored input: {0}\n",storedInput);
            Console.Write("Stored input length: {0}\n", storedInput.Length);
        }

        public void AddChar_TEST(char value)
        {
            string potentialResult = string.Concat(this.storedInput, value.ToString());
            string oldStoredInput = this.storedInput;
            this.AddChar(value);
            Console.Write("AddChar _TEST!\n");
            Console.Write("char to add: {0}\n",value);
            Console.Write("Potential Result: {0}\n",potentialResult);
            Console.Write("Potential Result Length: {0}\n",potentialResult.Length);
            Console.Write("Stored number base is: {0}\n", this.GetNumberBase());
            Console.Write("Old storedInput: {0}\n",oldStoredInput);
            Console.Write("Old storedInput length: {0}\n",oldStoredInput.Length);
            Console.Write("Result: {0}\n",this.storedInput);
            Console.Write("Result Length: {0}\n",this.storedInput.Length);
            Console.Write("\n\n");

        }

        public void DeleteChar_TEST()
        {
            string oldStoredInput = this.storedInput;
            this.deleteChar();
            Console.Write("DeleteChar _TEST!\n");
            Console.Write("Stored number base is: {0}\n", this.GetNumberBase());
            Console.Write("Old storedInput: {0}\n",oldStoredInput);
            Console.Write("Old storedInput length: {0}\n",oldStoredInput.Length);
            Console.Write("Result: {0}\n",this.storedInput);
            Console.Write("Result Length: {0}\n",this.storedInput.Length);
            Console.Write("\n\n");

        }

        public void AreAllCharsOfInputLegal_TEST(string input)
        {
            bool result = this.AreAllCharsOfInputLegal(input, NumberBases.BASE_TWO);
            Console.Write("AreAllCharsOfInputLegal_TEST!\n");
            Console.Write("input:{0}\n",input );
            Console.Write("Stored number base is: {0}\n", this.GetNumberBase());
            Console.Write("Is input legal?: {0}\n",result);
            Console.Write("\n\n");
        }

        public void ClearInput_TEST()
        {
            string oldStoredInput = this.storedInput;
            ClearInput();
            Console.Write("ClearInput_TEST!\n");
            Console.Write("old storedInput: {0}\n",oldStoredInput);
            Console.Write("Result: {0}\n",this.storedInput);
            Console.Write("\n\n");
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
            Console.Write("ReplaceStoredInput_TEST!\n");
            Console.Write("input to be: {0}\n",value);
            Console.Write("input length: {0}\n",value.Length);
            Console.Write("Stored number base is: {0}\n", this.GetNumberBase());
            Console.Write("Old storedInput: {0}\n",oldStoredInput);
            Console.Write("Old storedInput length: {0}\n",oldStoredInput.Length);
            Console.Write("Result: {0}\n",this.storedInput);
            Console.Write("Result Length: {0}\n",this.storedInput.Length);
            Console.Write("\n\n");


        }
    }
}
