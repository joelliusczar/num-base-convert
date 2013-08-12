using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers;

namespace binary_calculator.NumberTypes
{
    public class BinaryInt: NumberGenericInt
    {
        #region "constants for whole class"

        #endregion

        #region "Properties"
        



        #endregion

        #region "Public Methods"
        public BinaryInt(WrapperIntDecimal input)
        {
            this.input = input;
            UpdateNumber(input);

        }

        public NumberGeneric UpdateNumber(WrapperIntDecimal input)
        {
            long toBeConverted = input.storedNumber;
            int bitNumber = input.bitNumber;
            representationOfNumber = fromDecIntConversionPos(toBeConverted,bitNumber);

            return this;
        }
        #endregion

        #region "Private Methods"
        protected string fromDecIntConversionPos(long input, int bitNumber = 8)
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
