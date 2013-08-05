using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Inputs;

namespace binary_calculator.NumberTypes
{
    class BinaryInt: NumberGenericInt
    {
        #region "constants for whole class"

        #endregion

        #region "Properties"
        



        #endregion

        #region "Public Methods"
        public BinaryInt(InputIntDecimal input)
        {
            this.input = input;

        }

        public override NumberGeneric UpdateNumber(long input)
        {
            representationOfNumber = fromDecIntConversionPos(input);
            return this;
        }
        #endregion

        #region "Private Methods"
        protected override string fromDecIntConversionPos(long input)
        {
            string result = "";

            return result;
        }
        #endregion
    }
}
