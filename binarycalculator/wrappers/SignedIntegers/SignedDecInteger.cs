using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.Integers;
using binary_calculator.EnumsAndConstants;

namespace binary_calculator.Wrappers.SignedIntegers
{
    public class SignedDecInteger: UndefinedIntegerWrapper 
    {
        

        #region "constants for whole class"

        #endregion

        #region "Properties"
        private long _storedNumber;
        private int _maxSize;



        public long StoredNumber
        {
            get { return _storedNumber; }
            set { _storedNumber = value; }
        }

        public override string storedInput
        {
            get { return base.storedInput; }
            set
            {
                long temp;
                if (value.Length == 0) value = "0";
                bool validLong = (long.TryParse(value, out temp));
                if (TestAgainstSize(temp) && validLong)
                {
                    base.storedInput = value;
                    StoredNumber = temp;
                }

            }
        }

        public override int allowedNumberOfBits
        {
            get { return base.allowedNumberOfBits; }
            set
            {
                if (value < 0)
                {
                    base.allowedNumberOfBits = 1;
                }
                else
                {
                    base.allowedNumberOfBits = value;
                }

                MaxSize = (int)Math.Pow(2, allowedNumberOfBits - Constants.NECESSARY_EXPONENT_ADJUSTMENT) -Constants.NECESSARY_RANGE_ADJUSTMENT;
                MinSize = -(int)Math.Pow(2, allowedNumberOfBits - Constants.NECESSARY_EXPONENT_ADJUSTMENT);
                storedInput = "0";

            }
        }

        public int MaxSize
        {
            get { return _maxSize; }
            private set { _maxSize = value; }
        }

        private int _minSize;

        public int MinSize
        {
            get { return _minSize; }
            private set { _minSize = value; }
        }


        #endregion

        #region "Public Methods"
        /// <summary>
        /// The 
        /// </summary>
        /// <param name="bitNumber"></param>
        /// <param name="input">The Reason that this is a string is because of I want to take advantage of the AddChar method</param>
        public SignedDecInteger(int bitNumber = 8, string input = "") 
        {
            this.allowedNumberOfBits = bitNumber;
            storedInput = input;
        }

        public SignedDecInteger(int bitNumber = 8, long input = 0)
        {
            this.allowedNumberOfBits = bitNumber;
            storedInput = input.ToString();
        }
        #endregion

        #region "Private Methods"
        private bool TestAgainstSize(long value)
        {
            return (value < MaxSize) && (value >= MinSize);
        }
        #endregion
    }
}
