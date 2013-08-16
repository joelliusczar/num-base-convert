using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.Integers;

namespace binary_calculator.Converters.Integers
{
    public class ConverterToDec
    {
        #region "constants for whole class"
        
        #endregion

        #region "Properties"

        
        
        #endregion

        #region "Public Methods"

        public DecWrapper ToDecFromBinIntPos(BinWrapper input)
        {
            int size = input.allowedNumberOfBits;
            int convertFromBase = 2;
            string toBeConverted = input.storedInput;
            long result = Convert(toBeConverted,convertFromBase);
            DecWrapper output = new DecWrapper(size, result.ToString());

            return output;
        }

        #endregion

        #region "Private Methods"
        private long Convert(string input,int convertFromBase)
        {
            long result = 0;

            dictionaries.DictionaryForDecimals decDictionary = new dictionaries.DictionaryForDecimals();
            char[] inputAsArray = input.ToCharArray();
            //make input backwards so that converts in the correct order
            Array.Reverse(inputAsArray);

            int exponent = 0;
            foreach (char digit in inputAsArray)
            {
                long temp = long.Parse(decDictionary.GetDecimalEquivalent(digit));

                result = result + (long)(temp * Math.Pow(convertFromBase, exponent)); 
                exponent++;
            }

            return result;
        }
        #endregion
    }
}
