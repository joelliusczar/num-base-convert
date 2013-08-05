using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.NumberTypes
{
    class Base10Int
    {
        #region "constants for whole class"
        private const char FILL_STRING_WITH_THIS_CHAR__ZERO = '0',
            FILL_STRING_WITH_THIS_CHAR__ONE = '1',
            SEARCH_FOR_THIS_CHAR__ZERO = '0',
            SEARCH_FOR_THIS_CHAR__ONE = '1',
            NEGATIVE_SIGN_BIT = '1',
            POSITIVE_SIGN_BIT = '0',
            IMPLIED_ONE_IN_FRONT = '1';
        private const int NO_FIXED_SIZE_FOR_INTEGER = -1,
         NECESSARY_EXPONENT_ADJUSTMENT = 1,
         NECESSARY_EXCESS_ADJUSTMENT = 1,
         EXTRA_BIT_FOR_SIGN = 1,
         FIRST_CHAR_LOCATION = 1,
         NECESSARY_RANGE_ADJUSTMENT = 1;
        #endregion

        #region "Properties"

        private long _decimalValue;

        public long decimalValue
        {
            get { return _decimalValue; }
            set { _decimalValue = value; }
        }
        
        #endregion

        #region "Public Methods"
        public static Type fromDecIntConversionPos<Type>(long input, int size) where Type: NumberGeneric, new()
        {
            /*note 1
             * this method does not work with negative numbers.*/

            /*Note 2
             *Using -1 as size basically removes size limits and the 0's in front.
            Ex. 8 would be represented as 1000 instead of 00001000 if the size was 8. */
            NumberGeneric convertedBase = new Type();

            return (Type)convertedBase;

        }
        #endregion

        #region "Private Methods"

        #endregion
    }
}
