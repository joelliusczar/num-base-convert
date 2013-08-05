using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.NumberTypes
{
    public abstract class  NumberGenericInt: NumberGeneric
    {
        #region "abstract"
        public abstract NumberGeneric UpdateNumber(long input);
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
