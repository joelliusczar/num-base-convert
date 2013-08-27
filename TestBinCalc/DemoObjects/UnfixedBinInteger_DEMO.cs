using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestBinCalc.TestObjects;

namespace TestBinCalc.DemoObjects
{
    class UnfixedBinInteger_DEMO
    {
        private UnfixedBinInteger_TEST test;

        public UnfixedBinInteger_DEMO(string input)
        {
            test = new UnfixedBinInteger_TEST(input);
        }

        public void AddChar(char value)
        {
            test.AddChar_TEST(value);
        }

        public void DeleteChar()
        {
            test.DeleteChar_TEST();
        }

        public void ClearInput()
        {
            test.ClearInput_TEST();

        }

        public void AreAllCharsOfInputLegal(string value)
        {
            test.AreAllCharsOfInputLegal_TEST(value);
        }

        public void ReplaceStoredInput(string value)
        {
            test.ReplaceStoredInput_TEST(value);
        }

        public void ReplaceProperties(string input, int size)
        {
            test.ReplaceProperties_TEST(input, size);
        }

    }
}
