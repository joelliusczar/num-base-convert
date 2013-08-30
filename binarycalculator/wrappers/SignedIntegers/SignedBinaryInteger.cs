using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.Integers;

namespace binary_calculator.Wrappers.SignedIntegers
{
    public class SignedBinaryInteger: BinInteger
    {
        public SignedBinaryInteger(string input = "", int size = 8) : base(size, input) { }

        protected override string FillOutWithSelectChar(string input)
        {
            string result = "";
            int numberOfFillerCharsNeeded = allowedNumberOfBits - input.Length;
            string filler = new string(binary_calculator.EnumsAndConstants.Constants.FILL_STRING_WITH_THIS_CHAR__ONE, numberOfFillerCharsNeeded);
            result = string.Concat(filler, input);

            return result;
        }



    }
}
