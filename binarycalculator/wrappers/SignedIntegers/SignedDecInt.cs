using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.Utilities;
using binary_calculator.EnumsAndConstants;

namespace binary_calculator.Wrappers.SignedIntegers
{
    public class SignedDecInt
    {
        #region "properties"
        private UnfixedDecInteger _unfixedDec;
        private int _maxSize;
        private int _minSize;
        private bool _signBit;
        private string _frontChar;

        private string FrontChar
        {
            get { return _frontChar; }
            set { _frontChar = value; }
        }

        private bool SignBit
        {
            get { return _signBit; }
            set { _signBit = value; }
        }

        
        private int _allowedNumberOfBits;

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

                MaxSize = (int)Math.Pow(2, allowedNumberOfBits - Constants.NECESSARY_EXPONENT_ADJUSTMENT) - Constants.NECESSARY_RANGE_ADJUSTMENT;
                MinSize = (int)Math.Pow(2, allowedNumberOfBits - Constants.NECESSARY_EXPONENT_ADJUSTMENT);
                StoredNumber = 0;
            }
        }

        public int MaxSize
        {
            get { return _maxSize; }
            private set { _maxSize = value; }
        }

        public int MinSize
        {
            get { return _minSize; }
            private set { _minSize = value; }
        }

        private UnfixedDecInteger UnfixedDec
        {
            get 
            {
                if (_unfixedDec == null) _unfixedDec = new UnfixedDecInteger(0);
                return _unfixedDec; 
            }
            set { _unfixedDec = value; }
        }

        public string StoredInput
        {
            get
            {
                string toBeReturned = "";
                if (UnfixedDec.StoredInput != "0"&&SignBit)
                {
                    toBeReturned = String.Concat("-", UnfixedDec.StoredInput);
                }
                else
                {
                    toBeReturned = UnfixedDec.StoredInput;
                }

                return toBeReturned;
            }
            set
            {
                uint temp;
                bool hasSignChanged = false;

                bool isValid = DecUtilities.VerifyInput(value, UnfixedDec.StoredNumber, out temp, UnfixedDec.StoredInput == null);
                if (isValid)
                {
                    if ((value.IndexOf('-') == Constants.BEGINING_OF_STRING ) != SignBit)
                    {
                        ReverseSign();
                        hasSignChanged = true;
                    }
                }
                bool isStored = UpdateNumber(temp, SignBit);

                if (!isStored&&isValid&&hasSignChanged) ReverseSign();
                

            }
        }

        private uint StoredNumber
        {
            get
            {
                return UnfixedDec.StoredNumber;
            }
            set
            {
                UpdateNumber(value, SignBit);
            }
        }
        #endregion

        #region "contructors"
        public SignedDecInt(uint input = 0,int allowedNumberOfBits = 8, bool sign = false)
        {
            this.SignBit = sign;
            this.allowedNumberOfBits = allowedNumberOfBits;
            this.StoredNumber = input;
            
        }

        public SignedDecInt(string input = "", int allowedNumberOfBits = 8)
        {
            this.allowedNumberOfBits = allowedNumberOfBits;
            this.StoredInput = input;
            
        }
        #endregion

        #region "public methods"

        public void AddChar(char digit)
        {
            this.StoredInput = string.Concat(FrontChar,UnfixedDec.StoredInput, digit.ToString());
        }

        public void DeleteChar()
        {
            UnfixedDec.DeleteCharFromBack();
        }

        public void ClearInput()
        {
            UnfixedDec.ClearInput();
        }

        public void ReverseSign()
        {
            SignBit = !SignBit;
            FrontChar = SignBit ? "-" : "";
        }

        public uint GetUnsignedNumber()
        {
            return UnfixedDec.StoredNumber;
        }
        #endregion

        #region "private methods"
        private bool TestAgainstSize(long value,bool isNegative)
        {
            int size;
            if (isNegative) size = MinSize;
            else size = MaxSize;

            return (value <= size) && (value >= 0);
        }

        private bool TestAgainstSize(long value)
        {
            return TestAgainstSize(value, SignBit);
        }

        private bool UpdateNumber(uint input, bool isNegative)
        {
            if (TestAgainstSize(input, isNegative))
            {
                UnfixedDec.StoredNumber = input;
                return true;
            }
            else return false;
        }
        #endregion
    }
}
