using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.EnumsAndConstants;

namespace binary_calculator.Utilities
{
    public static class BinUtilities
    {
        #region "public methods"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">the new number</param>
        /// <param name="prevInput">the old stored number that is getting replaced</param>
        /// <param name="unneeded">leading insignificant characters</param>
        /// <returns>returns input if it is a valid number, or prevInput if input was invalid</returns>
        public static Tuple<string,bool> VerifyInputAsBin(string input,string prevInput,char unneeded = '0')
        {
            //gets rid of leading insignificant characters. For ex. with 04, the zero is unneeded. Therefore we strip it.
            input = input.TrimStart(unneeded); 

            bool inputAllowed = GlobalUtilities.AreAllCharsOfInputLegal(input, NumberBases.BASE_TWO);
            if (inputAllowed)
            {
                if (!string.IsNullOrEmpty(input))
                {
                    return new Tuple<string, bool>(input, inputAllowed); 
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(prevInput))
                {
                    return new Tuple<string, bool>(prevInput, inputAllowed);  
                }
            }
            return new Tuple<string, bool>("0", inputAllowed);

        }

        public static string RemoveSignBit(string binInput)
        {
            if (!string.IsNullOrWhiteSpace(binInput))
            {
                return binInput.Substring(1);
            }
            return "0";
        }

        public static bool GetSignBitValue(string binInput)
        {
            if (!string.IsNullOrWhiteSpace(binInput))
            {
                if (binInput[0] == '1') {
                    return true;
                }
                else if (binInput[0] == '0')
                {
                    return false;
                }
                else
                {
                    throw new IncorrectNumberBaseException(binInput[0], NumberBases.BASE_TWO);
                }
            }
            return false;
        }

        public static Tuple<string, bool> GetSignBitValueAndCutOffFrontBit(string binInput)
        {
            bool signBitValue = GetSignBitValue(binInput);
            string stringWithoutFrontBit = RemoveSignBit(binInput);

            return new Tuple<string,bool>(stringWithoutFrontBit,signBitValue);
        }

        public static string FillOutWithSelectedChar(string input, int maxLength,char fillerChar)
        {
            string result = "";
            string filler = GetFiller(input, maxLength, fillerChar);
            result = string.Concat(filler, input);
            return result;
        }


        public static string GetFiller(string input, int maxLength, char fillerChar)
        {
            string filler = "";
            input = string.IsNullOrEmpty(input) ? "" : input;
            if (input.Length < maxLength)
            {
                int numberOfFillerZerosNeeded = maxLength - input.Length;
                filler = new string(fillerChar, numberOfFillerZerosNeeded);
            }
            return filler;
        }

        
        public static string GetTrimmedOffCharsFromStart(string toBeTrimmed,char charToTrimOff)
        {
            if (!string.IsNullOrEmpty(toBeTrimmed))
            {

                
                string result = "";
                result = toBeTrimmed.TrimStart(charToTrimOff);
                if (result.Length > 0)
                {
                    string trimmed = toBeTrimmed.Replace(result, "");
                    return trimmed;
                }
                else return toBeTrimmed;
            }
            else return "";
        }

        #endregion

        #region "private methods"
        
        #endregion

        
        
    }
}
