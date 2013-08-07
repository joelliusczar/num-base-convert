using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Inputs;

namespace binary_calculator.NumberTypes
{
    public class NoFixedSizeUnsignedInt: NumberGenericInt
    {
        

        #region "constants for whole class"

        #endregion

        #region "Properties"
        private int _numberBase;

        public int numberBase
        {
            get { return _numberBase; }
            set
            {
                if (value <= MAX_BASE && value > 1) _numberBase = value;
            }
        }
     

        #endregion

        #region "Public Methods"

        public NoFixedSizeUnsignedInt(InputIntDecimal input, int numberBase)
        {
            this.numberBase = numberBase;
            UpdateNumber(input);
        }


        public NumberGeneric UpdateNumber(InputIntDecimal input)
        {
            long toBeConverted = input.storedNumber;
            representationOfNumber = fromDecIntConversionPos(toBeConverted);

            return this;
        }
        #endregion

        #region "Private Methods"
        protected string fromDecIntConversionPos(long input)
        {
            string result = "";

            char[] alphabetAndNumbers = "0123456789abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Stack<char> resultAsStack = new Stack<char>();
            while (input > 0)
            {
                //algorithm to convert a decimal to any number base
                char temp = alphabetAndNumbers[(input % numberBase)];
                resultAsStack.Push(temp);
                input = (long)(input / numberBase);
            }
            result = String.Concat(resultAsStack.ToArray());

            return result;
        }

        #endregion

    }
}
