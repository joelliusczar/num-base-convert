using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers;

namespace binary_calculator.NumberTypes
{
    public abstract class NumberGeneric
    {
        #region "constants for whole class"
        protected const char FILL_STRING_WITH_THIS_CHAR__ZERO = '0',
            FILL_STRING_WITH_THIS_CHAR__ONE = '1',
            SEARCH_FOR_THIS_CHAR__ZERO = '0',
            SEARCH_FOR_THIS_CHAR__ONE = '1',
            NEGATIVE_SIGN_BIT = '1',
            POSITIVE_SIGN_BIT = '0',
            IMPLIED_ONE_IN_FRONT = '1';
        protected const int NO_FIXED_SIZE_FOR_INTEGER = -1,
         NECESSARY_EXPONENT_ADJUSTMENT = 1,
         NECESSARY_EXCESS_ADJUSTMENT = 1,
         EXTRA_BIT_FOR_SIGN = 1,
         FIRST_CHAR_LOCATION = 1,
         MAX_BASE = 36,
         NECESSARY_RANGE_ADJUSTMENT = 1;
        #endregion

        #region "Properties"

        private string _representation;

        private WrapperIntDecimal _input;

        public string representationOfNumber
        {
            get { return _representation; }
            set { _representation = value; }
        }
        
        

        public WrapperIntDecimal input
        {
            get { return _input; }
            protected set { _input = value; }
        }

        #endregion

        #region "Public Methods"
        
        #endregion

        #region "Private Methods"


        #endregion

        
    }
}
