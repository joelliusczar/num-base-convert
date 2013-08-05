using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.NumberTypes;

namespace binary_calculator.HandlingForIllegalInput
{
    class IllegalNumber: NumberBase, iOutOfRangeNumber
    {
        public string errorMessage { get; private set; }
    }
}
