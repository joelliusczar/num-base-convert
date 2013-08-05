using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.NumberTypes;

namespace binary_calculator.HandlingForIllegalInput
{
    class IllegalNumber: NumberGeneric, iOutOfRangeNumber
    {
        public string errorMessage { get; private set; }

        public override string ToString()
        {
            return errorMessage;
        }
    }

    
}
