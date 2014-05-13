using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.UnfixedSize;
using NUnit.Framework;
using binary_calculator.EnumsAndConstants;

namespace TestBinCalc.TestObjects
{
    [TestFixture]
    public class UnfixedPowOfTwoInteger_TEST: IWrapperTest
    {
        [Test]
        public void UnfixedPowOfTwoInteger_DEMO()
        {
            Initialization_TEST();
            SetStoredInput_TEST();
            AddChar_TEST();
            DeleteChar_TEST();
            ClearInput_TEST();
        }

        public void Initialization_TEST()
        {
            UnfixedPowOfTwoInteger hex;
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN);
            Assert.AreEqual("0", hex.StoredInput);
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN, "000");
            Assert.AreEqual("000", hex.StoredInput);
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN, "ABC");
            Assert.AreEqual("ABC", hex.StoredInput);
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN, "abc");
            Assert.AreEqual("abc", hex.StoredInput);
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN, "-dec");
            Assert.AreEqual("0", hex.StoredInput);
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN, "123");
            Assert.AreEqual("123", hex.StoredInput);
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN, "a123");
            Assert.AreEqual("a123", hex.StoredInput);
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN, "00123");
            Assert.AreEqual("00123", hex.StoredInput);
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN, "abcg");
            Assert.AreEqual("0", hex.StoredInput);
            UnfixedPowOfTwoInteger oct;
            oct = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_EIGHT);
            Assert.AreEqual("0", oct.StoredInput);
            oct = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_EIGHT,"1");
            Assert.AreEqual("1", oct.StoredInput);
            oct = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_EIGHT, "56");
            Assert.AreEqual("56", oct.StoredInput);
            oct = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_EIGHT, "48");
            Assert.AreEqual("0", oct.StoredInput);
            oct = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_EIGHT, "10");
            Assert.AreEqual("10", oct.StoredInput);
            oct = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_EIGHT, "9");
            Assert.AreEqual("0", oct.StoredInput);
        }

        public void SetStoredInput_TEST()
        {
            UnfixedPowOfTwoInteger hex;
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN);
            hex.StoredInput = "5";
            Assert.AreEqual("5", hex.StoredInput);
            hex.StoredInput = "000";
            Assert.AreEqual("000", hex.StoredInput);
            hex.StoredInput = "-5";
            Assert.AreEqual("000", hex.StoredInput);
            hex.StoredInput = "abc";
            Assert.AreEqual("abc", hex.StoredInput);
            hex.StoredInput = "abcg";
            Assert.AreEqual("abc", hex.StoredInput);
            hex.StoredInput = "56";
            Assert.AreEqual("56", hex.StoredInput);
            hex.StoredInput = "00124";
            Assert.AreEqual("00124", hex.StoredInput);
            UnfixedPowOfTwoInteger oct;
            oct = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_EIGHT);
            oct.StoredInput = "00124";
            Assert.AreEqual("00124", oct.StoredInput);
            oct.StoredInput = "72";
            Assert.AreEqual("72", oct.StoredInput);
            oct.StoredInput = "-5";
            Assert.AreEqual("72", oct.StoredInput);
            oct.StoredInput = "128";
            Assert.AreEqual("72", oct.StoredInput);
              
        }

        public void AddChar_TEST()
        {
            UnfixedPowOfTwoInteger hex;
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN);
            hex.AddChar('0');
            Assert.AreEqual("00", hex.StoredInput);
            hex.AddChar('A');
            Assert.AreEqual("00A", hex.StoredInput);
            hex.StoredInput = "5";
            hex.AddChar('6');
            Assert.AreEqual("56", hex.StoredInput);
            hex.AddChar('-');
            Assert.AreEqual("56", hex.StoredInput);
            hex.AddChar('g');
            Assert.AreEqual("56", hex.StoredInput);
            hex.AddChar('f');
            Assert.AreEqual("56f", hex.StoredInput);
            UnfixedPowOfTwoInteger oct;
            oct = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_EIGHT);
            oct.AddChar('0');
            Assert.AreEqual("00", oct.StoredInput);
            oct.StoredInput = "56";
            oct.AddChar('8');
            Assert.AreEqual("56", oct.StoredInput);
            oct.AddChar('7');
            Assert.AreEqual("567", oct.StoredInput);

        }

        public void DeleteChar_TEST()
        {
            UnfixedPowOfTwoInteger hex;
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN);
            hex.DeleteCharFromBack();
            Assert.AreEqual("0", hex.StoredInput);
            hex.StoredInput = "123";
            hex.DeleteCharFromBack();
            Assert.AreEqual("12", hex.StoredInput);
            hex.DeleteCharFromBack();
            Assert.AreEqual("1", hex.StoredInput);
        }

        public void ClearInput_TEST()
        {
            UnfixedPowOfTwoInteger hex;
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN);
            hex.ClearInput();
            Assert.AreEqual("0", hex.StoredInput);
            hex.StoredInput = "123";
            hex.ClearInput();
            Assert.AreEqual("0", hex.StoredInput);
        }
    }
}
