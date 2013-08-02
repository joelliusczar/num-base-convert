using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.NumberTypes
{
    public abstract class NumberBase
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
         MAX_BASE = 36,
         NECESSARY_RANGE_ADJUSTMENT = 1;
        #endregion

        #region "Properties"

        private string _representation;
        private int _size;
        private int _bitNumber;
        private int _numberBase;

        public string representationOfNumber
        {
            get { return _representation; }
            set { _representation = value; }
        }

        public int bitNumber
        {
            get { return _bitNumber; }
            set 
            {
                if (value < 0) _bitNumber = 1;
                else _bitNumber = value;
            }
        }

        public int numberBase
        {
            get { return _numberBase; }
            set 
            {
                if (value <= MAX_BASE && value > 1) _numberBase = value;
            }
        }


        #endregion

        #region "Public Methods"
        
        #endregion

        #region "Private Methods"

        private double MaxSize()
        {
            return Math.Pow(2, bitNumber);
        }

        #endregion

        
    }
}
