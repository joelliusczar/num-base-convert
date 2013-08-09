using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Inputs
{
    public class InputBinary: InputIntNonDecimal
    {
        #region "Properties"

        #endregion

        #region "Public Methods"
        public InputBinary(int size = 8, string input = "")
        {
            allowedLength = size;
            storedInput = input;
        }

        #endregion

        #region "Private Methods"
        protected override bool InputAllCharsLegal(string input)
        {
            bool result = true;

            Filters filter = new Filters();
            string illegalChars = filter.GetIllegalChars(NumberBaseChoice.BASE_TWO);

            result = input.All(c => !illegalChars.Contains(c));

            return result;
        }
        #endregion
    }
}
