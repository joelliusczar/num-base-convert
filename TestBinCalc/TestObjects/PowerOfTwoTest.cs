using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Enums;
using binary_calculator.Wrappers.Integers;


namespace TestBinCalc.TestObjects
{
    class PowerOfTwoTest: PowerOfTwoWrapperNonBin
    {
        public PowerOfTwoTest(NumberBasesPowerOfTwo type, string input = "", int allowedBitNumber = 8) : base(type, input, allowedBitNumber) { }

        public void setProperties(NumberBasesPowerOfTwo type, string input, int allowedBitNumber)
        {
            
        }
    }
}
