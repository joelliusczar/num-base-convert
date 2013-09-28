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
        public static bool VerifyInput(string input,string prevInput,out string output,char unneeded = '0')
        {
            input = input.TrimStart(unneeded);

            bool inputAllowed = GlobalUtilities.AreAllCharsOfInputLegal(input, NumberBases.BASE_TWO);
            if (inputAllowed)
            {
                if (input.Length == 0) output = "0";
                else output = input;
                return true;
            }
            else if (prevInput == null || prevInput.Length == 0)
            {
                output = "0";
                return false;
            }
            else
            {
                output = prevInput;
                return false;
            }

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
            if (input.Length < maxLength)
            {
                int numberOfFillerZerosNeeded = maxLength - input.Length;
                filler = new string(fillerChar, numberOfFillerZerosNeeded);
            }
            return filler;
        }

        

        public static string GetTrimmedOffCharsFromStart(string toBeTrimmed,char charToTrimOff)
        {
            if (toBeTrimmed.Length != 0)
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
