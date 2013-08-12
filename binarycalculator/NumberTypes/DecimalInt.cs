using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers;

namespace binary_calculator.NumberTypes
{
    public class DecimalInt
    {
        #region "constants for whole class"
        
        #endregion

        #region "Properties"

        private WrapperIntDecimal _decContainer;

        public WrapperIntDecimal decContainer
        {
            get { return _decContainer; }
            set { _decContainer = value; }
        }
        
        
        #endregion

        #region "Public Methods"
        public long toDecIntConversionPos(WrapperIntNonDecimal input)
        {
            long result = 0;

            dictionaries.DictionaryForDecimals decDictionary = new dictionaries.DictionaryForDecimals();
            char[] inputAsArray = input.storedInput.ToCharArray();
            int convertFromBase = (int)input.baseChoice;
            //make input backwards so that converts in the correct order
            Array.Reverse(inputAsArray);

            int exponent = 0;
            foreach(char digit in inputAsArray)
            {
                long temp = long.Parse(decDictionary.GetDecimalEquivalent(digit));

                result = result + (long)(temp * Math.Pow(convertFromBase, exponent));
                exponent++;
            }

            return result;
        }
        #endregion

        #region "Private Methods"

        #endregion
    }
}
