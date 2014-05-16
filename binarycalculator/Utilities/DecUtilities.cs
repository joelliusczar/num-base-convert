using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.EnumsAndConstants;
using binary_calculator.Wrappers.UnfixedSize;

namespace binary_calculator.Utilities
{
    public static class DecUtilities
    {

        public static Tuple<uint, bool> VerifyInput(string input, UnfixedDecInteger dec)
        {
            return VerifyInput(input, dec.StoredNumber, dec.StoredInput == null);
        }

        public static Tuple<uint,bool> VerifyInput(string input, uint prevInputNumber, bool isUninitialized)
        {
            uint temp;

            input = input.TrimStart('0');
            if (string.IsNullOrEmpty(input))
            {
                input = "0";
            }
            input =  input[Constants.BEGINING_OF_STRING] != '-' ? input: input.Substring(1); 
            bool validUint = (uint.TryParse(input, out temp));
            if (validUint)
            {
                return new Tuple<uint, bool>(temp, validUint);
            }
            else if (isUninitialized)
            {
                return new Tuple<uint, bool>(0, validUint);
            }
            return new Tuple<uint, bool>(prevInputNumber, validUint);


        }
    }
}
