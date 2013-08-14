using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.Integers;

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

        public BinOctHexWrapper FromDecIntPos(DecWrapper input)
        {
            long toBeConverted = input.storedNumber;
            int bitNumber = input.bitNumber;
            string result = Convert(toBeConverted, bitNumber);
            BinOctHexWrapper output = new BinOctHexWrapper(NumberBaseChoice.BASE_TWO, bitNumber, result);

            return output;
        }
        #endregion

        #region "Private Methods"
        private string Convert(long input, int bitNumber = 8)
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
        #endregion
    }
}
