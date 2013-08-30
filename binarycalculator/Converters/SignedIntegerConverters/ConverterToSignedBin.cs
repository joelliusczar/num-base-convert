using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.EnumsAndConstants;
using binary_calculator.Wrappers.SignedIntegers;
using binary_calculator.Wrappers.Integers;
using binary_calculator.Wrappers.UnfixedSize;

namespace binary_calculator.Converters.SignedIntegerConverters
{
    class ConverterToSignedBin
    {
        #region "constants for whole class"

        #endregion

        #region "Properties"

        #endregion

        #region "Public Methods"
        public SignedBinaryInteger Convert(SignedDecInteger unsigned)
        {
            throw new NotImplementedException();
        }


        public SignedBinaryInteger Convert(BinInteger unsigned)
        {
            string toBeNegated = unsigned.storedInput;
            string result = this.NegateBin(toBeNegated);

            SignedBinaryInteger output = new SignedBinaryInteger(result, unsigned.allowedNumberOfBits);

            return output;
        }
        #endregion

        #region "Private Methods"

        //this method is for negative integers only, not fractions or positive numbers
        public string decToBinNeg(long input, int size)
        {//decToBinNeg
            const int mathmaticallyNecessaryCorrection = 1;

            if (input == -1) //special case for when input is -1
            {//if

                return new string(Constants.FILL_STRING_WITH_THIS_CHAR__ONE, size);
            }//if
            else
            {//else
                //make input positive
                //mathmaticallyNecessaryCorrection = -1
                long input2 = Math.Abs(input) - mathmaticallyNecessaryCorrection;

                //convert the positive number to binary
                //arguement size affects whether you'll get 0010 vs 00000010
                String inputAsPosBin = fromDecIntConversionPos(input2, size, NumberBases.BASE_TWO);

                string toBeReturned = NegateBin(inputAsPosBin);

                return toBeReturned;

            }//else

        }

        private string NegateBin(string input)
        {
            char[] inputAsArray = input.ToCharArray();
            //switch each 1 and 0, so that it is now a negative binary integer
            for (int i = 0; i < inputAsArray.Length; i++)
            {//for
                if (inputAsArray[i] == '0')
                {//if
                    inputAsArray[i] = '1';
                }//if
                else
                {//else
                    inputAsArray[i] = '0';
                }//else
            }//for

            return String.Concat(inputAsArray);
        }

        private  string fromDecIntConversionPos(long input2, int size, NumberBases numberBases)
        {
            throw new NotImplementedException();
        }//decToBinNeg

        #endregion
    }
}
