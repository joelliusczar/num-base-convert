using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.Integers;
using binary_calculator.EnumsAndConstants;

namespace binary_calculator.Wrappers.SignedIntegers
{
    public class SignedBinaryInteger: BinInteger
    {
        private bool _signBit;

        private bool SignBit
        {
            get { return _signBit; }
            set { _signBit = value; }
        }


        public override string storedInput
        {
            get
            {
                StringBuilder result = new StringBuilder(base.storedInput);
                if (SignBit)
                {
                    result.Insert(Constants.BEGINING_OF_STRING, '1');
                }
                else
                {
                    result.Insert(Constants.BEGINING_OF_STRING,'0');
                }
                return result.ToString();
            }
            set
            {
                base.storedInput = value;
            }
        }

        public SignedBinaryInteger(string input = "", int size = 8,bool sign = false) : base(size, input) 
        {
            this.SignBit = sign;
        }

        protected override string FillOutWithSelectChar(string input)
        {
            string result = "";
            if (SignBit)
            {
                int numberOfFillerCharsNeeded = allowedNumberOfBits - input.Length;
                string filler = new string(binary_calculator.EnumsAndConstants.Constants.ONE, numberOfFillerCharsNeeded);
                result = string.Concat(filler, input);
            }
            else
            {
                result = base.FillOutWithSelectChar(input);
            }

            return result;
        }

        public void ReverseSign()
        {
            SignBit = !SignBit;
        }

        /// <summary>
        /// returns the length but subtracts 1 to make room for the sign bit.
        /// </summary>
        /// <returns></returns>
        protected override int GetAllowedLength()
        {
            return allowedNumberOfBits - 1;
        }

    }
}
