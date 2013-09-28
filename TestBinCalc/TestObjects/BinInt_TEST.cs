using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.Integers;

namespace TestBinCalc.TestObjects
{
    [TestFixture]
    public class BinInt_TEST : IWrapperTest
    {
        [Test]
        public void BintInt_DEMO()
        {
            Initialization_TEST();
        }

        public void Initialization_TEST()
        {
            BinInt bin = new BinInt("", 8);
            Assert.AreEqual("00000000",bin.StoredInput);
            bin = new BinInt("ABC", 8);
            Assert.AreEqual("00000000", bin.StoredInput);
        }

        public void SetStoredInput_TEST()
        {
            throw new NotImplementedException();
        }

        public void AddChar_TEST()
        {
            throw new NotImplementedException();
        }

        public void DeleteChar_TEST()
        {
            throw new NotImplementedException();
        }

        public void ClearInput_TEST()
        {
            throw new NotImplementedException();
        }
    }
}
