using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.UnfixedSize;

namespace binary_calculator.Wrappers.Integers
{
    public class DecInt
    {
        

        #region "properties"
        private UnfixedDecInteger _unfixedDec;
        private int _maxSize;
        private int _allowedNumberOfBits;

        public int maxSize
        {
            get { return _maxSize; }
            private set { _maxSize = value; }
        }

        public int allowedNumberOfBits
        {
            get { return _allowedNumberOfBits; }
            set
            {
                if (value < 0)
                {
                    _allowedNumberOfBits = 1;
                }
                else
                {
                    _allowedNumberOfBits = value;
                }

                maxSize = (int)Math.Pow(2, allowedNumberOfBits);
                StoredInput = "0";
            }
        }

        public string StoredInput
        {
            get
            {
                if (_unfixedDec == null) _unfixedDec = new UnfixedDecInteger(0);

                return _unfixedDec.StoredInput;
            }
            set
            {
            }
        }
        #endregion

        #region "contructors"
        #endregion

        #region "public methods"
        #endregion

        #region "private methods"
        private bool TestAgainstSize(long value)
        {
            return (value < maxSize) && (value >= 0);
        }
        #endregion
    }
}
