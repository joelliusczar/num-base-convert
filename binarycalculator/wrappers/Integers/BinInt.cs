using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.EnumsAndConstants;
using binary_calculator.Utilities;

namespace binary_calculator.Wrappers.Integers
{
    public class BinInt
    {

        #region "properties"
        private UnfixedBinInteger _unfixedBin;

        private UnfixedBinInteger UnfixedBin
        {
            get 
            {
                if (_unfixedBin == null)
                {
                    _unfixedBin = new UnfixedBinInteger("");
                }
                return _unfixedBin; 
            }
            set { _unfixedBin = value; }
        }
        private int _allowedNumberOfBits;

        public int allowedNumberOfBits
        {
            get { return _allowedNumberOfBits; }
            set
            {
                _allowedNumberOfBits = value;
            }
        }

        public string StoredInput
        {
            get
            {
                return BinUtilities.FillOutWithSelectedChar(UnfixedBin.StoredInput, allowedNumberOfBits, '0');

            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    UnfixedBin.StoredInput = "0";
                }
                if (value.Length <= allowedNumberOfBits)
                {
                    UnfixedBin.StoredInput = value;
                }
                
            }
        }
        #endregion

        #region "contructors"
        public BinInt(string input = "", int size = 8)
        {
            this.allowedNumberOfBits = size;
            this.StoredInput = input;
        }
        #endregion

        #region "public methods"


        public void AddChar(char digit)
        {
            //this.StoredInput = UnfixedBin.StoredInput + digit; I may need to revert back to this if my change breaks stuff
            this.UnfixedBin.AddChar(digit);
        }

        public void DeleteChar()
        {
            UnfixedBin.DeleteCharFromBack();
        }

        public void ClearInput()
        {
            UnfixedBin.ClearInput();
        }
        #endregion

        #region "private methods"
        

        
        #endregion

    }
}
