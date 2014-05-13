using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.EnumsAndConstants;
using binary_calculator.Wrappers.SignedIntegers;
using binary_calculator.Wrappers.Integers;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.Converters.Integers;

namespace binary_calculator.Converters.SignedIntegerConverters
{
    class ConverterToSignedBin
    {
        #region "constants for whole class"

        #endregion

        #region "Properties"

        #endregion

        #region "Public Methods"
        public SignedBinInt Convert(SignedDecInt signedDecInteger)
        {
            uint inputNumber = signedDecInteger.GetUnsignedNumber();
            int size = signedDecInteger.allowedNumberOfBits;
            SignedBinInt signedBin;

            if (inputNumber >= 0)
            {
                DecInt dec = new DecInt(inputNumber,size);
                ConverterToBin binConvert = new ConverterToBin();
                BinInt bin = binConvert.Convert(dec);
                signedBin = new SignedBinInt(Constants.POSITIVE, bin.StoredInput, bin.allowedNumberOfBits);
                return signedBin;
            }
            else
            {

                string negBinRepresentation = this.decToBinNeg(inputNumber, size);
                signedBin = new SignedBinInt(Constants.NEGATIVE, negBinRepresentation, size);
            }

            return signedBin;

        }

        public SignedBinInt Negate(SignedBinInt signedBinaryInteger)
        {
            //string toBeNegated = signedBinaryInteger.StoredInput;
            //string result = this.NegateBin(toBeNegated);

            //signedBinaryInteger.ReverseSign();
            //signedBinaryInteger.StoredInput = result;

            //return signedBinaryInteger;
            throw new NotImplementedException();
        }

        //fix this
        public SignedBinInt Negate(BinInt unsigned)
        {
            //string toBeNegated = unsigned.StoredInput;
            //string result = this.NegateBin(toBeNegated);

            //SignedBinInt output = new SignedBinInt(input: result, size: unsigned.allowedNumberOfBits);

            //return output;
            throw new NotImplementedException();
        }
        #endregion

        #region "Private Methods"

        //this method is for negative integers only, not fractions or positive numbers
        public string decToBinNeg(long input, int size)
        {//decToBinNeg
            const int MATHEMATICALLY_NECESSARY_CORRECTION = 1;

            if (input == -1) //special case for when input is -1
            {//if

                return new string(Constants.ONE, size);
            }//if
            else
            {//else
                //make input positive
                //mathmaticallyNecessaryCorrection = -1
                uint inputAdjusted = (uint)Math.Abs(input) - MATHEMATICALLY_NECESSARY_CORRECTION;

                DecInt dec = new DecInt(inputAdjusted, size);
                ConverterToBin binConvert = new ConverterToBin();
                BinInt unsignedBin = binConvert.Convert(dec);

                //convert the positive number to binary
                //arguement size affects whether you'll get 0010 vs 00000010
                String inputAsPosBin = unsignedBin.StoredInput;

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
