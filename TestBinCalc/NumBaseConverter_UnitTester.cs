using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using binary_calculator.Wrappers.SignedIntegers;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.Wrappers.Integers;

namespace TestBinCalc
{
    [TestFixture]
    public class NumBaseConverter_UnitTester
    {
        //[Test]
        //public void SignBinInt_TEST()
        //{
        //    SignedBinInt bin = new SignedBinInt();
        //    Assert.AreEqual(bin.allowedNumberOfBits, 8);
        //    Assert.AreEqual("00000000",bin.GetStoredBinaryNumber());
        //    bin.StoreBinaryNumber("10000001");
        //    Assert.AreEqual("00000000", bin.GetStoredBinaryNumber());
        //    bin.ReverseSign();
        //    Assert.AreEqual("10000000", bin.GetStoredBinaryNumber());
        //    bin.ReverseSign();
        //    Assert.AreEqual("00000000", bin.GetStoredBinaryNumber());
        //    bin.StoreBinaryNumber("00000001");
        //    Assert.AreEqual("00000000", bin.GetStoredBinaryNumber());
        //    bin.AddChar('1');
        //    Assert.AreEqual("00000001", bin.GetStoredBinaryNumber());
        //    bin.ReverseSign();
        //    Assert.AreEqual("11111111", bin.GetStoredBinaryNumber());
        //    bin.ReverseSign();
        //    Assert.AreEqual("00000001", bin.GetStoredBinaryNumber());
        //    bin.AddChar('0');
        //    Assert.AreEqual("00000010", bin.GetStoredBinaryNumber());
        //    bin.ReverseSign();
        //    Assert.AreEqual("11111110", bin.GetStoredBinaryNumber());
        //    bin.ReverseSign();
        //    bin.StoreBinaryNumber("0000011");
        //    bin.ReverseSign();
        //    Assert.AreEqual("11111111", bin.GetStoredBinaryNumber());
        //}

        //[Test]
        //public void BinInt_TEST()
        //{
        //    BinInt bin = new BinInt("", 8);
        //    Assert.AreEqual("00000000", bin.StoredInput);
        //    bin.AddChar('1');
        //    Assert.AreEqual("00000001", bin.StoredInput);
        //    bin.AddChar('0');
        //    Assert.AreEqual("00000010", bin.StoredInput);
        //    bin.DeleteChar();
        //    Assert.AreEqual("00000001", bin.StoredInput);
        //    bin.AddChar('A');
        //    Assert.AreEqual("00000001", bin.StoredInput);
        //    bin.StoredInput = "ABC";
        //    Assert.AreEqual("00000001", bin.StoredInput);
        //    bin.StoredInput = "11111110";
        //    Assert.AreEqual("11111110", bin.StoredInput);
        //    bin.AddChar('1');
        //    Assert.AreEqual("11111110", bin.StoredInput);
        //    bin.ClearInput();
        //    Assert.AreEqual("00000000", bin.StoredInput);
        //    bin.DeleteChar();
        //    BinInt bin2 = new BinInt("", 8);
        //    bin2.StoredInput = "00001";
        //    Assert.AreEqual("00000001", bin2.StoredInput);
        //}

        //[Test]
        //public void UnfixedBinInteger_TEST()
        //{
        //    UnfixedBinInteger bin = new UnfixedBinInteger("");
        //    Assert.AreEqual("0", bin.StoredInput);
        //    bin.StoredInput = "101";
        //    Assert.AreEqual("101", bin.StoredInput);
        //    bin.AddChar('A');
        //    Assert.AreEqual("101", bin.StoredInput);
        //    bin.AddChar('1');
        //    Assert.AreEqual("1011", bin.StoredInput);
        //    bin.DeleteChar();
        //    Assert.AreEqual("101", bin.StoredInput);
        //    bin.ClearInput();
        //    Assert.AreEqual("0", bin.StoredInput);
        //}
    }
}
