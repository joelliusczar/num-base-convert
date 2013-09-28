using binary_calculator.EnumsAndConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Utilities
{
    public class GlobalUtilities
    {
        public static bool AreAllCharsOfInputLegal(string input, NumberBases baseChoice)
        {
            bool result = true;

            binary_calculator.dictionaries.Filters filter = new binary_calculator.dictionaries.Filters();

            string illegalChars = filter.GetIllegalChars(baseChoice);

            result = CheckIfContains(input, illegalChars);

            return result;
        }

        private static bool CheckIfContains(string input, string illegalChars)
        {
            bool result = false;

            result = input.All(c => !illegalChars.Contains(c)); //this can be fixed to make it quicker

            return result;
        }
    }
}
