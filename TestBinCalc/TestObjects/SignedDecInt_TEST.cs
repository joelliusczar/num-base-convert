using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.SignedIntegers;
using NUnit.Framework;

namespace TestBinCalc.TestObjects
{
    [TestFixture]
    public class SignedDecInt_TEST: IWrapperTest
    {
        SignedDecInt dec;

        [Test]
        public void SignedDecInt_DEMO()
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
            dec = new SignedDecInt("");
            Assert.AreEqual(8, dec.allowedNumberOfBits);
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt(0);
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt(5);
            Assert.AreEqual("5", dec.StoredInput);
            dec = new SignedDecInt("A");
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt("Abc");
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt("255");
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt(127);
            Assert.AreEqual("127", dec.StoredInput);
            dec = new SignedDecInt("-2");
            Assert.AreEqual("-2", dec.StoredInput);
            dec = new SignedDecInt(256);
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt("256");
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt(5, 4);
            Assert.AreEqual(4, dec.allowedNumberOfBits);
            dec = new SignedDecInt(0,8,true);
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt(5,8,true);
            Assert.AreEqual("-5", dec.StoredInput);
            dec = new SignedDecInt("A", 8);
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt("Abc", 8);
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt("255", 8);
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt(128, 8, true);
            Assert.AreEqual("-128", dec.StoredInput);
            dec = new SignedDecInt("-2", 8);
            Assert.AreEqual("-2", dec.StoredInput);
            dec = new SignedDecInt(256, 8, true);
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt("256", 8);
            Assert.AreEqual("0", dec.StoredInput);
            dec = new SignedDecInt("127");
            Assert.AreEqual("127", dec.StoredInput);
        }

        public void SetStoredInput_TEST()
        {
            dec = new SignedDecInt("");
            dec.StoredInput = "5";
            Assert.AreEqual("5", dec.StoredInput);
            dec.StoredInput = "256";
            Assert.AreEqual("5", dec.StoredInput);
            dec.StoredInput = "AAA";
            Assert.AreEqual("5", dec.StoredInput);
            dec.StoredInput = "-2";
            Assert.AreEqual("-2", dec.StoredInput);
            dec.StoredInput = "255";
            Assert.AreEqual("-2", dec.StoredInput);
            dec.StoredInput = "127";
            Assert.AreEqual("127", dec.StoredInput);
            dec.StoredInput = "128";
            Assert.AreEqual("127", dec.StoredInput);
            dec.StoredInput = "-128";
            Assert.AreEqual("-128", dec.StoredInput);
            dec.StoredInput = "-129";
            Assert.AreEqual("-128", dec.StoredInput);
            dec.StoredInput = "0";
            Assert.AreEqual("0", dec.StoredInput);
            dec.StoredInput = "6-4";
            Assert.AreEqual("0", dec.StoredInput);
            dec.StoredInput = "";
            Assert.AreEqual("0", dec.StoredInput);
            dec.StoredInput = "-32";
            Assert.AreEqual("-32", dec.StoredInput);
            dec.StoredInput = "1-2";
            Assert.AreEqual("-32", dec.StoredInput);
            dec.StoredInput = "";
            Assert.AreEqual("0", dec.StoredInput);
            dec.StoredInput = "32";
            Assert.AreEqual("32", dec.StoredInput);
            dec.StoredInput = "-";
            Assert.AreEqual("32", dec.StoredInput);
            dec.StoredInput = "32";
            Assert.AreEqual("32", dec.StoredInput);
            dec.StoredInput = "-0";
            Assert.AreEqual("0", dec.StoredInput);
            dec.StoredInput = "32";
            Assert.AreEqual("32", dec.StoredInput);
            dec.StoredInput = "032";
            Assert.AreEqual("32", dec.StoredInput);
            dec.StoredInput = "0";
        }

        public void SetAllowedNumberOfBits()
        {
            dec = new SignedDecInt("");
            dec.StoredInput = "128";
            dec.allowedNumberOfBits = 4;
            Assert.AreEqual(4, dec.allowedNumberOfBits);
            Assert.AreEqual("0", dec.StoredInput);
            dec.allowedNumberOfBits = 8;
            Assert.AreEqual(8, dec.allowedNumberOfBits);
            dec.allowedNumberOfBits = -4;
            Assert.AreEqual(8, dec.allowedNumberOfBits);
            dec.allowedNumberOfBits = 1024;
            Assert.AreEqual(1024, dec.allowedNumberOfBits);
            dec.allowedNumberOfBits = 8;
        }

        public void AddChar_TEST()
        {
            dec = new SignedDecInt("");
            dec.AddChar('2');
            Assert.AreEqual("2", dec.StoredInput);
            dec.AddChar('5');
            Assert.AreEqual("25", dec.StoredInput);
            dec.AddChar('6');
            Assert.AreEqual("25", dec.StoredInput);
            dec.StoredInput = "12";
            dec.AddChar('8');
            Assert.AreEqual("12", dec.StoredInput);
            dec.AddChar('8');
            Assert.AreEqual("12", dec.StoredInput);
            dec.AddChar('7');
            Assert.AreEqual("127", dec.StoredInput);
            dec.StoredInput = "6";
            dec.AddChar('8');
            Assert.AreEqual("68", dec.StoredInput);
            dec.AddChar('-');
            Assert.AreEqual("68", dec.StoredInput);
            dec.StoredInput = "-12";
            dec.AddChar('8');
            Assert.AreEqual("-128", dec.StoredInput);
        }

        public void DeleteChar_TEST()
        {
            dec = new SignedDecInt("");
            dec.StoredInput = "0";
            dec.DeleteChar();
            Assert.AreEqual("0", dec.StoredInput);
            dec.StoredInput = "5";
            dec.DeleteChar();
            Assert.AreEqual("0", dec.StoredInput);
            dec.StoredInput = "122";
            dec.DeleteChar();
            Assert.AreEqual("12", dec.StoredInput);
        }

        public void ClearInput_TEST()
        {
            dec = new SignedDecInt("");
            dec.ClearInput();
            Assert.AreEqual("0", dec.StoredInput);
            dec.StoredInput = "5";
            dec.ClearInput();
            Assert.AreEqual("0", dec.StoredInput);
            dec.StoredInput = "122";
            dec.ClearInput();
            Assert.AreEqual("0", dec.StoredInput);
        }
    }
}
