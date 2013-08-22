using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.Integers;
using binary_calculator.Enums;

namespace binary_calculator.Converters.Integers
{
    public class ConverterToBin: GenericIntegerConverter
    {
        #region "constants for whole class"

        #endregion

        #region "Properties"
        



        #endregion

        #region "Public Methods"
        public ConverterToBin()
        {
        }

        public BinWrapper Convert(DecWrapper input)
        {
            long toBeConverted = input.storedNumber;
            int bitNumber = input.allowedNumberOfBits;
            string result = FromDecIntPos(toBeConverted, bitNumber);
            BinWrapper output = new BinWrapper( bitNumber, result);

            return output;
        }

        public BinWrapper Convert(PowerOfTwoWrapperNonBin input)
        {
            int bitNumber = input.allowedNumberOfBits;
            NumberBases baseChoice = input.baseChoice;
            string storedInput = input.storedInput;
            string result = FromPowerOfTwoIntPos(storedInput, baseChoice);

            BinWrapper output = new BinWrapper(bitNumber, result);

            return output;

        }

        #endregion

        #region "Private Methods"
        private string FromDecIntPos(long input, int bitNumber = 8)
        {
            string result = "";
            Stack<string> resultAsStack = new Stack<string>();
            for (int i = 0; i < bitNumber; i++)
            {
                string temp = (input % 2).ToString();
                resultAsStack.Push(temp);
                input = (long)(input / 2);
            }
            result = String.Concat(resultAsStack.ToArray());

            return result;
        }

        private string FromPowerOfTwoIntPos(string input,NumberBases choice)
        {
            string result = "";
            int numBase = (int)choice;
            int exponent = 0;
            int dictionaryValueSize = 4;

            //get the power of 2. Ex. 8=2^3, 16=2^4
            exponent = (int)Math.Log(numBase, 2);

            /*Note on substringStartingPoint
             * 4 is the number of bin digits for each hex char
            if exponent = 4(for hex) then substringStartingPoint = 0
            if exponent= 3(for oct) then substringStartingPoint = 1*/
            int substringStartingPoint = dictionaryValueSize - exponent;

            //load dictionary of binary representations of each oct and hex character
            dictionaries.DictionaryForBinary binDictionary = new dictionaries.DictionaryForBinary();

            //one string of 1's and 0's for each hex or oct character
            Stack<string> binStack = new Stack<string>();
            string temp;

            //convert each character to binary
            foreach (char digit in input)
            {
                temp = binDictionary.GetEquivalent(digit);
                temp = temp.Substring(substringStartingPoint); //see note on substringStartingPoint
                binStack.Push(temp);
            }

            result = string.Concat(binStack.ToArray());
            result = outputAdjuster(result);

            return result;
        }

        //this method is to correct errors that got introduced after converting from octal       
        private static string outputAdjuster(string strToFix)
        {
            //4 is the number of bin digits for each hex char
            int correctStrStartingPoint = strToFix.Length % 4;

            return strToFix.Substring(correctStrStartingPoint);
        }
        #endregion
    }
}
