using System;
using binary_calculator.Wrappers.Integers;
using binary_calculator.Wrappers.UnfixedSize;

namespace binary_calculator.Converters.Integers
{
    public class ConverterToDec
    {
        #region "constants for whole class"
        
        #endregion

        #region "Properties"

        
        
        #endregion

        #region "Public Methods"

        public DecInteger Convert(BinInteger input)
        {
            int size = input.allowedNumberOfBits;
            int convertFromBase = 2;
            string toBeConverted = input.storedInput;
            long result = ToDecFromBinIntPos(toBeConverted,convertFromBase);
            DecInteger output = new DecInteger(size, result);

            return output;
        }

        public UnfixedDecInteger Convert(UnfixedBinInteger input)
        {
            int convertFromBase = 2;
            string toBeConverted = input.StoredInput;
            uint result = ToDecFromBinIntPos(toBeConverted, convertFromBase);

            UnfixedDecInteger output = new UnfixedDecInteger(result);

            return output;
        }

        #endregion

        #region "Private Methods"
        private uint ToDecFromBinIntPos(string input,int convertFromBase)
        {
            uint result = 0;

            dictionaries.DictionaryForDecimals decDictionary = new dictionaries.DictionaryForDecimals();
            char[] inputAsArray = input.ToCharArray();
            //make input backwards so that converts in the correct order
            Array.Reverse(inputAsArray);

            int exponent = 0;
            foreach (char digit in inputAsArray)
            {
                long temp = long.Parse(decDictionary.GetDecimalEquivalent(digit));

                result = result + (uint)(temp * Math.Pow(convertFromBase, exponent)); 
                exponent++;
            }

            return result;
        }
        #endregion
    }
}
