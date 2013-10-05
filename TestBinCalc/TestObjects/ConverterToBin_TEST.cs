using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using binary_calculator.Converters.Integers;
using binary_calculator.Wrappers.Integers;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.EnumsAndConstants;

namespace TestBinCalc.TestObjects
{
    [TestFixture]
    public class ConverterToBin_TEST
    {
        ConverterToBin converter;
        DecInt dec;
        BinInt bin;
        UnfixedPowOfTwoInteger hex;
        UnfixedPowOfTwoInteger oct;
        UnfixedBinInteger ubin;

        [SetUp]
        public void SetUp()
        {
            converter = new ConverterToBin();
            dec = new DecInt("");
            
        }

        [Test]
        public void ConverterToBin_DEMO()
        {
            ConvertDec_TEST();
            ConvertUnsignedHex();
            ConvertUnsignedOct();
        }

        public void ConvertDec_TEST()
        {
            dec.StoredNumber = 25;
            bin = converter.Convert(dec);
            Assert.AreEqual(8, bin.allowedNumberOfBits);
            Assert.AreEqual("00011001", bin.StoredInput);
            dec.StoredNumber = 16;
            bin = converter.Convert(dec);
            Assert.AreEqual("00010000", bin.StoredInput);
            dec.StoredNumber = 1;
            bin = converter.Convert(dec);
            Assert.AreEqual("00000001", bin.StoredInput);
            dec.StoredNumber = 14;
            bin = converter.Convert(dec);
            Assert.AreEqual("00001110", bin.StoredInput);
            dec.StoredNumber = 5;
            bin = converter.Convert(dec);
            Assert.AreEqual("00000101", bin.StoredInput);
            dec.StoredNumber = 41;
            bin = converter.Convert(dec);
            Assert.AreEqual("00101001", bin.StoredInput);
        }

        public void ConvertUnsignedHex()
        {
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN, "");
            hex.StoredInput = "4";
            ubin = converter.Convert(hex);
            Assert.AreEqual("100", ubin.StoredInput);
            hex.StoredInput = "8";
            ubin = converter.Convert(hex);
            Assert.AreEqual("1000", ubin.StoredInput);
            hex.StoredInput = "A";
            ubin = converter.Convert(hex);
            Assert.AreEqual("1010", ubin.StoredInput);
            hex.StoredInput = "b";
            ubin = converter.Convert(hex);
            Assert.AreEqual("1011", ubin.StoredInput);
            hex.StoredInput = "C";
            ubin = converter.Convert(hex);
            Assert.AreEqual("1100", ubin.StoredInput);
            hex.StoredInput = "d";
            ubin = converter.Convert(hex);
            Assert.AreEqual("1101", ubin.StoredInput);
            hex.StoredInput = "56";
            ubin = converter.Convert(hex);
            Assert.AreEqual("1010110", ubin.StoredInput);
            hex.StoredInput = "ef";
            ubin = converter.Convert(hex);
            Assert.AreEqual("11101111", ubin.StoredInput);
        }

        public void ConvertUnsignedOct()
        {
            oct = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_EIGHT);
            oct.StoredInput = "4";
            ubin = converter.Convert(oct);
            Assert.AreEqual("100", ubin.StoredInput);
            oct.StoredInput = "10";
            ubin = converter.Convert(oct);
            Assert.AreEqual("1000", ubin.StoredInput);
            oct.StoredInput = "42";
            ubin = converter.Convert(oct);
            Assert.AreEqual("100010", ubin.StoredInput);

        }
    }
}
