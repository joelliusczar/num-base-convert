using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.Integers;
using NUnit.Framework;

namespace TestBinCalc.TestObjects
{
    [TestFixture]
    class DecInt_TEST: IWrapperTest
    {
        [Test]
        public void DecInt_DEMO()
        {
            Initialization_TEST();
            SetStoredInput_TEST();
            SetAllowedNumberOfBits();
            AddChar_TEST();
            DeleteChar_TEST();
            ClearInput_TEST();
        }

        public void Initialization_TEST()
        {
            DecInt dec = new DecInt("0");
            Assert.AreEqual(8, dec.allowedNumberOfBits);
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec = new DecInt(0);
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec = new DecInt(5);
            Assert.AreEqual("5", dec.StoredInput);
            Assert.AreEqual(5, dec.StoredNumber);
            dec = new DecInt("A");
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec = new DecInt("Abc");
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec = new DecInt("255");
            Assert.AreEqual("255", dec.StoredInput);
            Assert.AreEqual(255, dec.StoredNumber);
            dec = new DecInt(255);
            Assert.AreEqual("255", dec.StoredInput);
            Assert.AreEqual(255, dec.StoredNumber);
            dec = new DecInt("-2");
            Assert.AreEqual("2", dec.StoredInput);
            Assert.AreEqual(2, dec.StoredNumber);
            dec = new DecInt(256);
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec = new DecInt("256");
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec = new DecInt(5,4);
            Assert.AreEqual(4, dec.allowedNumberOfBits);

        }

        public void SetStoredInput_TEST()
        {
            DecInt dec = new DecInt("0");
            dec.StoredInput = "5";
            Assert.AreEqual("5", dec.StoredInput);
            Assert.AreEqual(5, dec.StoredNumber);
            dec.StoredInput = "256";
            Assert.AreEqual("5", dec.StoredInput);
            Assert.AreEqual(5, dec.StoredNumber);
            dec.StoredInput = "AAA";
            Assert.AreEqual("5", dec.StoredInput);
            Assert.AreEqual(5, dec.StoredNumber);
            dec.StoredNumber = 0;
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec.StoredInput = "-2";
            Assert.AreEqual("2", dec.StoredInput);
            Assert.AreEqual(2, dec.StoredNumber);
            dec.StoredInput = "255";
            Assert.AreEqual("255", dec.StoredInput);
            Assert.AreEqual(255, dec.StoredNumber);
            dec.StoredNumber = 0;
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec.StoredNumber = 255;
            Assert.AreEqual("255", dec.StoredInput);
            Assert.AreEqual(255, dec.StoredNumber);
            
        }

        public void SetAllowedNumberOfBits()
        {
            DecInt dec = new DecInt("0");
            dec.StoredNumber = 128;
            dec.allowedNumberOfBits = 4;
            Assert.AreEqual(4, dec.allowedNumberOfBits);
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec.allowedNumberOfBits = 8;
            Assert.AreEqual(8, dec.allowedNumberOfBits);
            dec.allowedNumberOfBits = -4;
            Assert.AreEqual(8, dec.allowedNumberOfBits);
            dec.allowedNumberOfBits = 1024;
            Assert.AreEqual(1024, dec.allowedNumberOfBits);

        }

        public void AddChar_TEST()
        {
            DecInt dec = new DecInt("0");
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
            dec.AddChar('6');
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

        public void DeleteChar_TEST()
        {
            DecInt dec = new DecInt("0");
            dec.DeleteChar();
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec.StoredInput = "5";
            dec.DeleteChar();
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec.StoredNumber = 255;
            dec.DeleteChar();
            Assert.AreEqual("25", dec.StoredInput);
            Assert.AreEqual(25, dec.StoredNumber);
        }

        public void ClearInput_TEST()
        {
            DecInt dec = new DecInt("0");
            dec.ClearInput();
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec.StoredInput = "5";
            dec.ClearInput();
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
            dec.StoredNumber = 255;
            dec.ClearInput();
            Assert.AreEqual("0", dec.StoredInput);
            Assert.AreEqual(0, dec.StoredNumber);
        }
    }
}
