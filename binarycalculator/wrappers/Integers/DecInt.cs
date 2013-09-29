using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.Utilities;

namespace binary_calculator.Wrappers.Integers
{
    public class DecInt
    {
        

        #region "properties"
        private UnfixedDecInteger _unfixedDec;

        private UnfixedDecInteger UnfixedDec
        {
            get 
            {
                if (_unfixedDec == null) _unfixedDec = new UnfixedDecInteger(0);
                return _unfixedDec; 
            }
            set { _unfixedDec = value; }
        }
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
                    if (_allowedNumberOfBits < 1) _allowedNumberOfBits = 1;
                    
                }
                else
                {
                    _allowedNumberOfBits = value;
                }

                maxSize = (int)Math.Pow(2, allowedNumberOfBits);
                StoredNumber = 0;
            }
        }

        public string StoredInput
        {
            get
            {
                

                return UnfixedDec.StoredInput;
            }
            set
            {
                uint temp;

                DecUtilities.VerifyInput(value, UnfixedDec.StoredNumber, out temp, UnfixedDec.StoredInput == null);
                this.StoredNumber = temp;

            }
        }

        public uint StoredNumber
        {
            get
            {
                return UnfixedDec.StoredNumber;
            }
            set
            {
                if (TestAgainstSize(value))
                {
                    UnfixedDec.StoredNumber = value;
                }
            }
        }
        #endregion

        #region "contructors"
        public DecInt(uint input = 0,int allowedNumberOfBits = 8)
        {
            this.allowedNumberOfBits = allowedNumberOfBits;
            this.StoredNumber = input;
        }

        public DecInt(string input = "",int allowedNumberOfBits = 8)
        {
            this.allowedNumberOfBits = allowedNumberOfBits;
            this.StoredInput = input;
        }

        #endregion

        #region "public methods"
        public void AddChar(char digit)
        {
            this.StoredInput = string.Concat(UnfixedDec.StoredInput, digit.ToString());
        }

        public void DeleteChar()
        {
            UnfixedDec.DeleteChar();
        }

        public void ClearInput()
        {
            UnfixedDec.ClearInput();
        }
        #endregion

        #region "private methods"
        private bool TestAgainstSize(long value)
        {
            return (value < maxSize) && (value >= 0);
        }
        #endregion
    }
}
