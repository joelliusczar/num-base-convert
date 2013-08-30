using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.EnumsAndConstants;
using TestBinCalc.TestObjects;

namespace TestBinCalc.DemoObjects
{
    public class UnfixedPowOfTwoInteger_DEMO
    {
        private UnfixedPowOfTwoInterger_TEST test;

        public UnfixedPowOfTwoInteger_DEMO(PowOfTwoBases choice, string input)
        {
            test = new UnfixedPowOfTwoInterger_TEST(choice, input);
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
