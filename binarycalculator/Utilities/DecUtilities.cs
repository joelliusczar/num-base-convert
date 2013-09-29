using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Utilities
{
    public static class DecUtilities
    {

        public static bool VerifyInput(string input, uint prevInputNumber, out uint outputNumber, bool isUninitialized)
        {
            uint temp;

            input = input.TrimStart('0');
            if (input.Length == 0)
            {
                input = "0";
            }
            input = input.Replace("-", "");
            bool validUint = (uint.TryParse(input, out temp));
            if (validUint)
            {
                outputNumber = temp;
                return true;
            }
            else if (isUninitialized)
            {
                outputNumber = 0;
                return false;
            }
            else
            {
                outputNumber = prevInputNumber;
                return false;
            }

        }
    }
}
