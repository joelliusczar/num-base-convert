using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.NumberTypes
{
    public abstract class  NumberGenericInt: NumberGeneric
    {


        #region "abstract"
        
        #endregion

        #region "overrides"
        public override string ToString()
        {
            return representationOfNumber;
        }
        #endregion


    }
}
