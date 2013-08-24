using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.Integers;

namespace TestBinCalc.TestObjects
{
    class Dec_TEST: DecInteger
    {
        public Dec_TEST(int size, string input) : base(size, input) { }

        public void SetSize_TEST(int size)
        {
            this.allowedNumberOfBits = size;
            
            
        }

        public void SetInput(string input)
        {
            this.storedInput = input;
        }
    }
}
