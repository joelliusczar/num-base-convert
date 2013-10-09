
using System.Collections.Generic;
using binary_calculator.EnumsAndConstants;
using System;
using binary_calculator.Wrappers.UnfixedSize;

namespace binary_calculator.Converters
{
    public class ConverterToAny
    {
        #region "constants for whole class"

        #endregion

        #region "Properties"

        #endregion

        #region "Public Methods"
        public UnfixedAnyInteger Convert(UnfixedDecInteger dec, NumberBases numType)
        {
            string output = FromDecIntConversionPos(dec.StoredNumber, (int)numType);
            UnfixedAnyInteger any = new UnfixedAnyInteger(numType, output);

            return any;
        }
        #endregion

        #region "Private Methods"
        private string FromDecIntConversionPos(long input, int convertToBase)
        {

                    string result = "";

                        char[] alphabetAndNumbersArray = "0123456789abcdefghijklmnopqrstuvwxyz"
                            .ToCharArray();
                        Stack<char> resultAsStack = new Stack<char>();
                        while (input > 0)
                        {
                            //algorithm to convert a decimal to any number base
                            char temp = alphabetAndNumbersArray[(input % convertToBase)];
                            resultAsStack.Push(temp);
                            input = (long)(input / convertToBase);
                        }

                        result = String.Concat(resultAsStack.ToArray());

                    return result;
 
            
        }

        #endregion
    }
}
