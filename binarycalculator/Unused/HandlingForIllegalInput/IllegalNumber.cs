using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Converters;

namespace binary_calculator.HandlingForIllegalInput
{
    class IllegalNumber: GenericConverter, iOutOfRangeNumber
    {
        public string errorMessage { get; private set; }

        public override string ToString()
        {
            return errorMessage;
        }
    }

    
}
