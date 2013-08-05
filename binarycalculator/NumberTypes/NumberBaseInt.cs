using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.NumberTypes
{
    public abstract class  NumberBaseInt: NumberBase
    {
        #region "abstract"
        public abstract NumberBase UpdateNumber(long input);
        protected abstract string fromDecIntConversionPos(long input);
        #endregion

        #region "overrides"
        public override string ToString()
        {
            return representationOfNumber;
        }
        #endregion


    }
}
