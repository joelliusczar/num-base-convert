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
    public class UnfixedAnyInteger_TEST: IWrapperTest
    {
        [Test]
        public void UnfixedAnyInteger_DEMO()
        {
            Initialization_TEST();
            SetStoredInput_TEST();
            AddChar_TEST();
            DeleteChar_TEST();
            ClearInput_TEST();
        }

        public void Initialization_TEST()
        {
            UnfixedAnyInteger any = new UnfixedAnyInteger(NumberBases.BASE_THIRTYSIX);
            Assert.AreEqual("0", any.StoredInput);
            any = new UnfixedAnyInteger(NumberBases.BASE_THIRTYSIX,"abcXYZ123");
            Assert.AreEqual("abcXYZ123", any.StoredInput);
        }

        public void SetStoredInput_TEST()
        {
            UnfixedAnyInteger any = new UnfixedAnyInteger(NumberBases.BASE_THIRTYSIX);
            any.StoredInput = "123";
            Assert.AreEqual("123", any.StoredInput);
            any.StoredInput = "-123";
            Assert.AreEqual("123", any.StoredInput);
            any.StoredInput = "abc";
            Assert.AreEqual("abc", any.StoredInput);
            any.StoredInput = "XYZ";
            Assert.AreEqual("XYZ", any.StoredInput);
        }

        public void AddChar_TEST()
        {
            UnfixedAnyInteger any = new UnfixedAnyInteger(NumberBases.BASE_THIRTYSIX);
            any.AddChar('1');
            Assert.AreEqual("01", any.StoredInput);
            any.AddChar('a');
            Assert.AreEqual("01a", any.StoredInput);
            any.AddChar('x');
            Assert.AreEqual("01ax", any.StoredInput);
            any.AddChar('*');
            Assert.AreEqual("01ax", any.StoredInput);
        }

        public void DeleteChar_TEST()
        {
            UnfixedAnyInteger any = new UnfixedAnyInteger(NumberBases.BASE_THIRTYSIX);
            any.DeleteCharFromBack();
            Assert.AreEqual("0", any.StoredInput);
            any.StoredInput = "XYZ";
            any.DeleteCharFromBack();
            Assert.AreEqual("XY", any.StoredInput);
        }

        public void ClearInput_TEST()
        {
            UnfixedAnyInteger any = new UnfixedAnyInteger(NumberBases.BASE_THIRTYSIX);
            any.ClearInput();
            Assert.AreEqual("0", any.StoredInput);
            any.StoredInput = "XYZ";
            any.ClearInput();
            Assert.AreEqual("0", any.StoredInput);
            any.StoredInput = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            any.ClearInput();
            Assert.AreEqual("0", any.StoredInput);
        }
    }
}
