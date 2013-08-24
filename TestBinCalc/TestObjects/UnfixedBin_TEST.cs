using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.UnfixedSize;

namespace TestBinCalc.TestObjects
{
    class UnfixedBin_TEST: UnfixedBinInteger
    {
        public UnfixedBin_TEST(string input) : base(input) { }

        public void SetInput_TEST(string input)
        {
            this.storedInput = input;
        }
    }
}
