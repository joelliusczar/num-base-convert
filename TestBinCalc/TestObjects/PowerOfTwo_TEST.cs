using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Enums;
using binary_calculator.Wrappers.Integers;


namespace TestBinCalc.TestObjects
{
    class PowerOfTwo_TEST: PowOfTwoInteger
    {
        public PowerOfTwo_TEST(PowOfTwoBases type, string input = "", int allowedBitNumber = 8) : base(type, input, allowedBitNumber) { }

        public void SetInput_TEST( string input)
        {
            this.storedInput = input;
            

        }

        public void SetAllowedBitNumber_TEST(int allowedBitNumber)
        {
            this.allowedNumberOfBits = allowedBitNumber;
        }
    }
}
