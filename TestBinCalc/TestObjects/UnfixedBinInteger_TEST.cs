using binary_calculator.Wrappers.UnfixedSize;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestBinCalc.TestObjects
{
    [TestFixture]
    public class UnfixedBinInteger_TEST: IWrapperTest
    {
        [Test]
        public void UnfixedBinInteger_DEMO()
        {
            Initialization_TEST();
            SetStoredInput_TEST();
            AddChar_TEST();
            DeleteChar_TEST();
            ClearInput_TEST();
        }

        public void Initialization_TEST()
        {
            UnfixedBinInteger bin = new UnfixedBinInteger("");
            Assert.AreEqual("0", bin.StoredInput);
            bin = new UnfixedBinInteger("1");
            Assert.AreEqual("1", bin.StoredInput);
            bin = new UnfixedBinInteger("0");
            Assert.AreEqual("0", bin.StoredInput);
            bin = new UnfixedBinInteger("101");
            Assert.AreEqual("101", bin.StoredInput);
            bin = new UnfixedBinInteger("ABC");
            Assert.AreEqual("0", bin.StoredInput);
            bin = new UnfixedBinInteger("3");
            Assert.AreEqual("0", bin.StoredInput);
            bin = new UnfixedBinInteger("9");
            Assert.AreEqual("0", bin.StoredInput);
            bin = new UnfixedBinInteger("0000");
            Assert.AreEqual("0", bin.StoredInput);
        }

        public void SetStoredInput_TEST()
        {
            UnfixedBinInteger bin = new UnfixedBinInteger("");
            bin.StoredInput = "";
            Assert.AreEqual("0",bin.StoredInput);
            bin.StoredInput = "1";
            Assert.AreEqual("1", bin.StoredInput);
            bin.StoredInput = "";
            Assert.AreEqual("0", bin.StoredInput);
            bin.StoredInput = "1010";
            Assert.AreEqual("1010", bin.StoredInput);
            bin.StoredInput = "000";
            Assert.AreEqual("0", bin.StoredInput);
            bin.StoredInput = "1111";
            Assert.AreEqual("1111", bin.StoredInput);
        }

        public void AddChar_TEST()
        {
            UnfixedBinInteger bin = new UnfixedBinInteger("");
            bin.AddChar('1');
            Assert.AreEqual("1", bin.StoredInput);
            bin.AddChar('1');
            Assert.AreEqual("11", bin.StoredInput);
            bin.StoredInput = "0";
            bin.AddChar('1');
            Assert.AreEqual("1", bin.StoredInput);
            bin.StoredInput = "0";
            bin.AddChar('0');
            Assert.AreEqual("0", bin.StoredInput);
            bin.AddChar('a');
            Assert.AreEqual("0", bin.StoredInput);
            bin.StoredInput = "110110";
            bin.AddChar('a');
            Assert.AreEqual("110110", bin.StoredInput);

        }

        public void DeleteChar_TEST()
        {
            UnfixedBinInteger bin = new UnfixedBinInteger("");
            bin.DeleteChar();
            Assert.AreEqual("0", bin.StoredInput);
            bin.StoredInput = "101";
            bin.DeleteChar();
            Assert.AreEqual("10", bin.StoredInput);

        }

        public void ClearInput_TEST()
        {
            UnfixedBinInteger bin = new UnfixedBinInteger("");
            bin.ClearInput();
            Assert.AreEqual("0", bin.StoredInput);
            bin.StoredInput = "101";
            bin.ClearInput();
            Assert.AreEqual("0", bin.StoredInput);
        }
    }
}
