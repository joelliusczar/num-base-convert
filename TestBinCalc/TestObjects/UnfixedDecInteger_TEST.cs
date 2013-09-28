using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.UnfixedSize;
using NUnit.Framework;

namespace TestBinCalc.TestObjects
{
    [TestFixture]
    public class UnfixedDecInteger_TEST: IWrapperTest
    {
        [Test]
        public void UnfixedDecInteger_DEMO()
        {
            Initialization_TEST();
            SetStoredInput_TEST();
            ClearInput_TEST();
            DeleteChar_TEST();
            AddChar_TEST();
        }

        public void Initialization_TEST()
        {
            UnfixedDecInteger dec = new UnfixedDecInteger("");
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec = new UnfixedDecInteger(0);
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec = new UnfixedDecInteger(5);
            Assert.AreEqual("5", dec.StoredInput);
            Assert.AreEqual(5, dec.StoredNumber);
            dec = new UnfixedDecInteger("A");
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec = new UnfixedDecInteger("Abc");
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec = new UnfixedDecInteger("255");
            Assert.AreEqual("255", dec.StoredInput);
            Assert.AreEqual(255, dec.StoredNumber);
            dec = new UnfixedDecInteger(255);
            Assert.AreEqual("255", dec.StoredInput);
            Assert.AreEqual(255, dec.StoredNumber);
            dec = new UnfixedDecInteger("-2");
            Assert.AreEqual("2", dec.StoredInput);
            Assert.AreEqual(2, dec.StoredNumber);
        }

        
        public void SetStoredInput_TEST()
        {
            UnfixedDecInteger dec = new UnfixedDecInteger("");
            dec.StoredInput = "5";
            Assert.AreEqual("5", dec.StoredInput);
            Assert.AreEqual(5, dec.StoredNumber);
            dec.StoredNumber = 0;
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec.StoredInput = "256";
            Assert.AreEqual("256", dec.StoredInput);
            Assert.AreEqual(256, dec.StoredNumber);
            dec.StoredInput = "AAA";
            Assert.AreEqual("256", dec.StoredInput);
            Assert.AreEqual(256, dec.StoredNumber);
            dec.StoredInput = "-2";
            Assert.AreEqual("2", dec.StoredInput);
            Assert.AreEqual(2, dec.StoredNumber);
        }

        
        public void ClearInput_TEST()
        {
            UnfixedDecInteger dec = new UnfixedDecInteger("");
            dec.ClearInput();
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec.StoredInput = "5";
            dec.ClearInput();
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec.StoredNumber = 256;
            dec.ClearInput();
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);

        }

               
        public void DeleteChar_TEST()
        {
            UnfixedDecInteger dec = new UnfixedDecInteger("");
            dec.DeleteChar();
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec.StoredInput = "5";
            dec.DeleteChar();
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec.StoredNumber = 256;
            dec.DeleteChar();
            Assert.AreEqual("25", dec.StoredInput);
            Assert.AreEqual(25, dec.StoredNumber);
        }

        
        public void AddChar_TEST()
        {
            UnfixedDecInteger dec = new UnfixedDecInteger("");
            dec.AddChar('2');
            Assert.AreEqual("2", dec.StoredInput);
            Assert.AreEqual(2, dec.StoredNumber);
            dec.AddChar('5');
            Assert.AreEqual("25", dec.StoredInput);
            Assert.AreEqual(25, dec.StoredNumber);
            dec.DeleteChar();
            dec.AddChar('5');
            Assert.AreEqual("25", dec.StoredInput);
            Assert.AreEqual(25, dec.StoredNumber);
            dec.StoredInput = "12";
            dec.AddChar('8');
            Assert.AreEqual("128", dec.StoredInput);
            Assert.AreEqual(128, dec.StoredNumber);
            dec.StoredNumber = 6;
            dec.AddChar('8');
            Assert.AreEqual("68", dec.StoredInput);
            Assert.AreEqual(68, dec.StoredNumber);

        }
    }
}
