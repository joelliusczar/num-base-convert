using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.SignedIntegers;
using NUnit.Framework;

namespace TestBinCalc.TestObjects
{
    [TestFixture]
    class SignedBinInt_TEST: IWrapperTest
    {
        [Test]
        public void SignedBinInt_DEMO()
        {
            Initialization_TEST();
            SetStoredInput_TEST();
            AddChar_TEST();
            DeleteChar_TEST();
            ClearInput_TEST();
            ReverseSign_TEST();
        }

        public void Initialization_TEST()
        {
            SignedBinInt bin = new SignedBinInt();
            Assert.AreEqual(8,bin.allowedNumberOfBits);
            Assert.AreEqual("00000000", bin.StoredInput);
            Assert.AreEqual(false, bin.GetSign());
            bin = new SignedBinInt("0000000", 8, true);
            Assert.AreEqual(bin.allowedNumberOfBits, 8);
            Assert.AreEqual("10000000", bin.StoredInput);
            Assert.AreEqual(true, bin.GetSign());
            bin = new SignedBinInt("0001111", 8,true);
            Assert.AreEqual("10001111", bin.StoredInput);
            Assert.AreEqual(true, bin.GetSign());
            bin = new SignedBinInt("1001", 8);
            Assert.AreEqual("00001001", bin.StoredInput);
            Assert.AreEqual(false, bin.GetSign());
            bin = new SignedBinInt("Abc", 8);
            Assert.AreEqual("00000000", bin.StoredInput);
            Assert.AreEqual(false, bin.GetSign());
        }

        public void SetStoredInput_TEST()
        {
            SignedBinInt bin = new SignedBinInt();
            bin.StoredInput = "1001";
            Assert.AreEqual("00001001", bin.StoredInput);
            Assert.AreEqual(false, bin.GetSign());
            bin.StoredInput = "1111111";
            Assert.AreEqual("01111111", bin.StoredInput);
            Assert.AreEqual(false, bin.GetSign());
            bin.StoredInput = "abc";
            Assert.AreEqual("01111111", bin.StoredInput);
            bin.StoredInput = "1010";
            Assert.AreEqual("00001010", bin.StoredInput);
            bin.StoredInput = "";
            Assert.AreEqual("00000000", bin.StoredInput);
        }

        public void AddChar_TEST()
        {
            SignedBinInt bin = new SignedBinInt();
            bin.AddChar('1');
            Assert.AreEqual("00000001", bin.StoredInput);
            bin.AddChar('1');
            Assert.AreEqual("00000011", bin.StoredInput);
            bin.AddChar('0');
            Assert.AreEqual("00000110", bin.StoredInput);
            bin.AddChar('1');
            Assert.AreEqual("00001101", bin.StoredInput);
            bin.AddChar('1');
            Assert.AreEqual("00011011", bin.StoredInput);
            bin.AddChar('1');
            Assert.AreEqual("00110111", bin.StoredInput);
            bin.AddChar('0');
            Assert.AreEqual("01101110", bin.StoredInput);
            bin.AddChar('1');
            Assert.AreEqual("01101110", bin.StoredInput);
            bin.AddChar('0');
            Assert.AreEqual("01101110", bin.StoredInput);
            bin.StoredInput = "0";
            bin.AddChar('5');
            Assert.AreEqual("00000000", bin.StoredInput);  
        }

        public void DeleteChar_TEST()
        {
            SignedBinInt bin = new SignedBinInt();
            bin.DeleteChar();
            Assert.AreEqual("00000000", bin.StoredInput);
            bin.StoredInput = "0001111";
            bin.DeleteChar();
            Assert.AreEqual("00000111", bin.StoredInput);
            bin.StoredInput = "1000000";
            bin.DeleteChar();
            Assert.AreEqual("00100000", bin.StoredInput);
            bin.DeleteChar();
            Assert.AreEqual("00010000", bin.StoredInput);
            bin.DeleteChar();
            Assert.AreEqual("00001000", bin.StoredInput);
            bin.StoredInput = "1111111";
            bin.DeleteChar();
            Assert.AreEqual("00111111", bin.StoredInput);
        }

        public void ClearInput_TEST()
        {
            SignedBinInt bin = new SignedBinInt(); 
            bin.ClearInput();
            Assert.AreEqual("00000000", bin.StoredInput);
            bin.StoredInput = "1111111";
            bin.ClearInput();
            Assert.AreEqual("00000000", bin.StoredInput);
            bin.StoredInput = "0001111";
            bin.ClearInput();
            Assert.AreEqual("00000000", bin.StoredInput);
        }

        public void ReverseSign_TEST()
        {
            SignedBinInt bin = new SignedBinInt();
            bin.ReverseSign();
            Assert.AreEqual("10000000", bin.StoredInput);
            bin.ReverseSign();
            Assert.AreEqual("00000000", bin.StoredInput);
            bin.StoredInput = "1";
            bin.ReverseSign();
            Assert.AreEqual("10000001", bin.StoredInput);
            bin.StoredInput = "1111";
            Assert.AreEqual("10001111", bin.StoredInput);
            bin.ReverseSign();
            Assert.AreEqual("00001111", bin.StoredInput);
        }
    }
}
