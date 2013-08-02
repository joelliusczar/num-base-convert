﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.NumberTypes
{
    public class NoFixedSizeUnsignedInt: NumberBase
    {
        

        #region "constants for whole class"

        #endregion

        #region "Properties"


        #endregion

        #region "Public Methods"

        public NoFixedSizeUnsignedInt(long input, int numberBase)
        {
            this.numberBase = numberBase;
            representationOfNumber = fromDecIntConversionPos(input);
        }


        public string UpdateNumber(long input)
        {
            representationOfNumber = fromDecIntConversionPos(input);

            return representationOfNumber;
        }
        #endregion

        #region "Private Methods"
        private string fromDecIntConversionPos(long input)
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
