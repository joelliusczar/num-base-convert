//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using binary_calculator.Wrappers.UnfixedSize;
//using binary_calculator.EnumsAndConstants;
//using binary_calculator.Utilities;

//namespace binary_calculator.Wrappers.SignedIntegers
//{

//    //I think I'm gonna deprecate this class also
//    public class SignedBinInt: Undefined
//    {
//        #region "properties"
//        private int _allowedNumberOfBits;
//        private bool _signBit;
//        private string _storedInput;

//        private char _insignificantDigit;

//        private char InsignificantDigit
//        {
//            get { return _insignificantDigit; }
//            set { _insignificantDigit = value; }
//        }

//        private string _trimmedOff;

//        private string TrimmedOff
//        {
//            get { return _trimmedOff; }
//            set { _trimmedOff = value; }
//        }
        

//        private bool SignBit
//        {
//            get 
//            {
//                return _signBit;
//            }
//            {
//                _signBit = value;
//                if (value) this.InsignificantDigit = '1';
//                else this.InsignificantDigit = '0';
//            }
//        }


//        public int allowedNumberOfBits
//        {
//            get { return _allowedNumberOfBits; }
//            set
//            {
//                _allowedNumberOfBits = value;
//            }
//        }

//        private int BitNumberAdjustedForSignBit
//        {
//            get
//            {
//                return allowedNumberOfBits - Constants.SIZE_ADJUSTER_FOR_SIGN_BIT;
//            }
//        }//            set 


//        public override string StoredInput
//        {
//            get
//            {
//                string toBeReturned = string.Concat(TrimmedOff, _storedInput);
//                if (this.SignBit) return string.Concat("1", toBeReturned);
//                else return string.Concat("0", toBeReturned);
//            }
//            set
//            {
                

//                value = value.TrimStart('0');
//                if (value.Length <= BitNumberAdjustedForSignBit)
//                {
//                    Tuple<string, bool> result;
//                    result = BinUtilities.VerifyInputAsBin(value, _storedInput, '0');
//                    _storedInput = result.Item1;
//                }
//                else
//                {
//                    throw new BitSizeException(value, allowedNumberOfBits);
//                }

               
//                    TrimmedOff = BinUtilities.GetFiller(
//                        _storedInput,
//                        BitNumberAdjustedForSignBit, '0');

//            }
//        }


//        #endregion

//        #region "contructors"

//        //public SignedBinInt(string input)

//        public SignedBinInt(bool sign, string input, int size = 8)
//        {
//            this.SignBit = sign;
//            this.allowedNumberOfBits = size;
//            this.StoredInput = input;
            
//        }

//        public SignedBinInt(string input)
//        {

//        }
          

//        #endregion

//        #region "public methods"


//        public bool GetSign()
//        {
//            return SignBit;
//        }

//        public void ReverseSign()
//        {
//            SignBit = !SignBit;
//        }
//        #endregion

//        #region "private methods"
//        protected override void SetStoredInput(string input)
//        {
//            this.StoredInput = input;
//        }
        
//        #endregion

//    }
//}
