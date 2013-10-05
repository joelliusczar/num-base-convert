using System;
using binary_calculator.Wrappers.Integers;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.Wrappers;
using binary_calculator.EnumsAndConstants;

namespace binary_calculator.Converters.Integers
{
    public class ConverterToDec
    {
        #region "constants for whole class"
        
        #endregion

        #region "Properties"

        
        
        #endregion

        #region "Public Methods"

        public DecInt Convert(BinInt input)
        {
            int size = input.allowedNumberOfBits;
            int convertFromBase = 2;
            string toBeConverted = input.StoredInput;
            uint result = ToDecFromIntPos(toBeConverted, convertFromBase);
            DecInt output = new DecInt(result,size);

            return output;
        }

        public UnfixedDecInteger Convert(UnfixedBinInteger input)
        {
            uint result = SetUpConvert(input, (int)NumberBases.BASE_TWO);

            UnfixedDecInteger output = new UnfixedDecInteger(result);

            return output;
        }

        public UnfixedDecInteger Convert(UnfixedPowOfTwoInteger input)
        {
            int numberBase = (int)input.GetNumberBase();
            uint result = SetUpConvert(input, numberBase);
            UnfixedDecInteger output = new UnfixedDecInteger(result);

            return output;
        }

        #endregion

        #region "Private Methods"
        private uint SetUpConvert(Undefined input,int numBase)
        {
            int convertFromBase = numBase;
            string toBeConverted = input.StoredInput;
            uint result = ToDecFromIntPos(toBeConverted, convertFromBase);
            return result;
        }

        private uint ToDecFromIntPos(string input,int convertFromBase)
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
