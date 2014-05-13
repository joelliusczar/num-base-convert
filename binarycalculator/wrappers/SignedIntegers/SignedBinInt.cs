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
                return allowedNumberOfBits - Constants.SIZE_ADJUSTER_FOR_SIGN_BIT;
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
            set
            {
                UnfixedBinInteger bin = new UnfixedBinInteger(value);
                this.allowedNumberOfBits = value.Length;
                this.SignBit = BinUtilities.GetSignBitValue(value);
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
                if (string.IsNullOrEmpty(value))
                {
                    //investigate this part
                    this.UnfixedBin.StoredInput = "0";
                    this.IsValid = true;
                    return;
                }
                if (value.Length <= this.allowedNumberOfBits)
                {
                    UnfixedBin.StoredInput = value;
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

        }

        public SignedBinInt(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                UnfixedBinInteger bin = new UnfixedBinInteger(input);
                this.allowedNumberOfBits = input.Length;
                this.SignBit = BinUtilities.GetSignBitValue(input);
                this.UnfixedBin.DeleteCharFromFront();
            }
            else
            {
                this.SignBit = false;
                this.allowedNumberOfBits = 8;
                this.SignificantBits = "";
            }
        }

        #endregion

        #region "Public Methods"
        #endregion

        #region "Private Methods"
        

        #endregion

    }
}
