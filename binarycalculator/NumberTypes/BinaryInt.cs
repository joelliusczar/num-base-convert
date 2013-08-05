using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.NumberTypes
{
    class BinaryInt: NumberBaseInt
    {
        #region "constants for whole class"

        #endregion

        #region "Properties"


        #endregion

        #region "Public Methods"
        public BinaryInt(long input, int bitNumber)
        {
            this.bitNumber = bitNumber;

        }

        public override NumberBase UpdateNumber(long input)
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
