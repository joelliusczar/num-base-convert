using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using binary_calculator.Wrappers.SignedIntegers;

namespace TestBinCalc
{
    [TestFixture]
    public class NumBaseConverter_UnitTester
    {
        [Test]
        public void SignBinaryInteger_TEST()
        {
            SignedBinaryInteger bin = new SignedBinaryInteger();
            Assert.AreEqual(bin.allowedNumberOfBits, 8);
            Assert.AreEqual("00000000",bin.storedInput);
            bin.storedInput = "10000001";
            Assert.AreEqual("00000000", bin.storedInput);
            bin.ReverseSign();
            Assert.AreEqual("10000000", bin.storedInput);
            bin.ReverseSign();
            Assert.AreEqual("00000000", bin.storedInput);
            bin.storedInput = "00000001";
            Assert.AreEqual("00000000", bin.storedInput);
            bin.AddChar('1');
            Assert.AreEqual("00000001", bin.storedInput);

        }
    }
}
