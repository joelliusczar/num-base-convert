using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.Enums;

namespace TestBinCalc.TestObjects
{
    class UnfixedAny_TEST: UnfixedAnyInteger
    {
        public UnfixedAny_TEST(NumberBases choice, string input) : base(choice, input) { }

        public void SetNumberBase_TEST(NumberBases choice)
        {
            this.baseChoice = choice;
        }

        public void SetInput_TEST(string input)
        {
            this.storedInput = input;
        }
    }
}
