using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.Integers;

namespace TestBinCalc.TestObjects
{
    public class Bin_TEST: BinInteger
    {
        public Bin_TEST(int size, string input) : base(size, input) { }

        public void SetInput_TEST(string input)
        {
            
            this.storedInput = input;
           
        }

        public void SetSize(int size)
        {
            this.allowedNumberOfBits = size;
        }

    }
}
