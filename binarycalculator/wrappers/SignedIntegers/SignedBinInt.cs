using binary_calculator.EnumsAndConstants;
using binary_calculator.Utilities;
using binary_calculator.Wrappers.UnfixedSize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Wrappers.SignedIntegers
{
    public class SignedBinInt
    {
        #region "constants for whole class"

        #endregion

        #region "Properties"
        private int _allowedNumberOfBits;
        private bool _signBit;
        private UnfixedBinInteger _unfixedBin;
        private char _insignificantDigit;
        private bool _isValid;

        public bool IsValid
        {
            get { return _isValid && this.UnfixedBin.IsValid; }
            private set { _isValid = value; }
        }

        private char InsignificantDigit
        {
            get { return _insignificantDigit; }
            set { _insignificantDigit = value; }
        }

        private bool SignBit
        {
            get 
            {
                return _signBit;
            }
            set
            {
                _signBit = value;
                if (value) this.InsignificantDigit = '1';
                else this.InsignificantDigit = '0';
            }
        }

        private char SignDigit
        {
            get
            {
                if (SignBit)
                {
                    return '1';
                }
                else
                {
                    return '0';
                }
            }
        }

        public int Length
        {
            get
            {
                return this.UnfixedBin.Length;
            }
        }

        public int allowedNumberOfBits
        {
            get { return _allowedNumberOfBits; }
            set
            {
                _allowedNumberOfBits = value;
            }
        }

        private int BitNumberAdjustedForSignBit
        {
            get
            {
                return allowedNumberOfBits - Constants.SIGN_BIT_LENGTH;
            }
        }

        private UnfixedBinInteger UnfixedBin
        {
            get
            {
                if (_unfixedBin == null) _unfixedBin = new UnfixedBinInteger();
                return _unfixedBin;
            }
            set {
                _unfixedBin = value; 
            
            }
        }

        public string StoredInput
        {
            get 
            {
                int insignificantDigitFillerSize;
                string fillerDigits = "";
                if ((insignificantDigitFillerSize = (UnfixedBin.Length + Constants.SIGN_BIT_LENGTH - this.allowedNumberOfBits)) > 0)
                {
                    fillerDigits = new String(this.InsignificantDigit, insignificantDigitFillerSize);
                }
                return SignDigit + fillerDigits + SignificantBits;
            }
            set
            {
                UnfixedBinInteger bin = new UnfixedBinInteger(value);
                this.allowedNumberOfBits = value.Length;
                this.SignBit = BinUtilities.GetSignBitValue(value);
                this.UnfixedBin = bin;
                this.UnfixedBin.DeleteCharFromFront();
            }
        }

        private string SignificantBits
        {
            get
            {
                return UnfixedBin.StoredInput;
            }
            set
            {

                if (value.Length <= this.BitNumberAdjustedForSignBit)
                {
                    this.UnfixedBin.StoredInput = value;
                }
                else
                {
                    this.IsValid = false; 
                }
            }
        } 

        #endregion

        #region "constructors"

        public SignedBinInt(bool sign, string input, int size = 8)
        {
            if(!string.IsNullOrEmpty(input))
            {
                this.SignBit = sign;
                this.allowedNumberOfBits = size;
                this.SignificantBits = input;
            }
            else
            {

            }

        }

        public SignedBinInt(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                this.StoredInput = input;
            }
            else
            {
                this.SignBit = false;
                this.allowedNumberOfBits = 8;
                this.SignificantBits = "0";
            }
        }

        #endregion

        #region "Public Methods"
        #endregion

        #region "Private Methods"
        

        #endregion

    }
}
