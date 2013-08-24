using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.Enums;

namespace TestBinCalc.TestObjects
{
    class UnfixedPowOfTwo_TEST: UnfixedPowOfTwoInteger
    {
        public UnfixedPowOfTwo_TEST(PowOfTwoBases choice, string input) : base(choice, input) { }

        public void SetInput_TEST(string input)
        {
           
        }
    }
}
