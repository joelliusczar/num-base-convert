using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Wrappers.Integers;
using binary_calculator.Wrappers.SignedIntegers;
using binary_calculator.Converters.Integers;
using NUnit.Framework;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.EnumsAndConstants;

namespace TestBinCalc.TestObjects
{
    [TestFixture]
    public class ConverterToDec_TEST
    {
        ConverterToDec converter;
        DecInt dec;
        BinInt bin;
        UnfixedBinInteger uBin;
        UnfixedDecInteger uDec;
        UnfixedPowOfTwoInteger hex;
        UnfixedPowOfTwoInteger oct;

        [SetUp]
        public void Setup()
        {
            converter = new ConverterToDec();
            bin = new BinInt();
            uBin = new UnfixedBinInteger();
            hex = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_SIXTEEN);
            oct = new UnfixedPowOfTwoInteger(PowOfTwoBases.BASE_EIGHT);

        }

        [Test]
        public void ConverterToDec_DEMO()
        {
            ConvertFromBin();
            ConvertFromUnfixedBin();
            ConvertFromUnfixedHex();
            ConvertFromUnfixedOct();
        }

        public void ConvertFromBin()
        {
            dec = converter.Convert(bin);
            Assert.AreEqual("0", dec.StoredInput);
            bin.StoredInput = "00000001";
            dec = converter.Convert(bin);
            Assert.AreEqual("1", dec.StoredInput);
            bin.StoredInput = "00000010";
            dec = converter.Convert(bin);
            Assert.AreEqual("2", dec.StoredInput);
            bin.StoredInput = "00000011";
            dec = converter.Convert(bin);
            Assert.AreEqual("3", dec.StoredInput);
            bin.StoredInput = "00000100";
            dec = converter.Convert(bin);
            Assert.AreEqual("4", dec.StoredInput);
            bin.StoredInput = "00001000";
            dec = converter.Convert(bin);
            Assert.AreEqual("8", dec.StoredInput);
            bin.StoredInput = "00010000";
            dec = converter.Convert(bin);
            Assert.AreEqual("16", dec.StoredInput);
            bin.StoredInput = "00011111";
            dec = converter.Convert(bin);
            Assert.AreEqual("31", dec.StoredInput);
            bin.StoredInput = "00100000";
            dec = converter.Convert(bin);
            Assert.AreEqual("32", dec.StoredInput);
            bin.StoredInput = "10101010";
            dec = converter.Convert(bin);
            Assert.AreEqual("170", dec.StoredInput);
            bin.StoredInput = "00101001";
            dec = converter.Convert(bin);
            Assert.AreEqual("41", dec.StoredInput);
            bin.StoredInput = "01000000";
            dec = converter.Convert(bin);
            Assert.AreEqual("64", dec.StoredInput);
            bin.StoredInput = "10000000";
            dec = converter.Convert(bin);
            Assert.AreEqual("128", dec.StoredInput);
            bin.StoredInput = "11111111";
            dec = converter.Convert(bin);
            Assert.AreEqual("255", dec.StoredInput);
        }

        public void ConvertFromUnfixedBin()
        {
            uDec = converter.Convert(uBin);
            Assert.AreEqual("0", uDec.StoredInput);
            uBin.StoredInput = "1";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("1", uDec.StoredInput);
            uBin.StoredInput = "10";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("2", uDec.StoredInput);
            uBin.StoredInput = "11";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("3", uDec.StoredInput);
            uBin.StoredInput = "100";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("4", uDec.StoredInput);
            uBin.StoredInput = "1000";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("8", uDec.StoredInput);
            uBin.StoredInput = "10000";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("16", uDec.StoredInput);
            uBin.StoredInput = "11111";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("31", uDec.StoredInput);
            uBin.StoredInput = "100000";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("32", uDec.StoredInput);
            uBin.StoredInput = "10101010";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("170", uDec.StoredInput);
            uBin.StoredInput = "101001";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("41", uDec.StoredInput);
            uBin.StoredInput = "11111111";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("255", uDec.StoredInput);
            uBin.StoredInput = "100000000";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("256", uDec.StoredInput);
            uBin.StoredInput = "1000000000";
            uDec = converter.Convert(uBin);
            Assert.AreEqual("512", uDec.StoredInput);
            
        }

        public void ConvertFromUnfixedHex()
        {
            uDec = converter.Convert(hex);
            Assert.AreEqual("0", uDec.StoredInput);
            hex.StoredInput = "1";
            uDec = converter.Convert(hex);
            Assert.AreEqual("1", uDec.StoredInput);
            hex.StoredInput = "2";
            uDec = converter.Convert(hex);
            Assert.AreEqual("2", uDec.StoredInput);
            hex.StoredInput = "5";
            uDec = converter.Convert(hex);
            Assert.AreEqual("5", uDec.StoredInput);
            hex.StoredInput = "A";
            uDec = converter.Convert(hex);
            Assert.AreEqual("10", uDec.StoredInput);
            hex.StoredInput = "B";
            uDec = converter.Convert(hex);
            Assert.AreEqual("11", uDec.StoredInput);
            hex.StoredInput = "c";
            uDec = converter.Convert(hex);
            Assert.AreEqual("12", uDec.StoredInput);
            hex.StoredInput = "d";
            uDec = converter.Convert(hex);
            Assert.AreEqual("13", uDec.StoredInput);
            hex.StoredInput = "E";
            uDec = converter.Convert(hex);
            Assert.AreEqual("14", uDec.StoredInput);
            hex.StoredInput = "f";
            uDec = converter.Convert(hex);
            Assert.AreEqual("15", uDec.StoredInput);
            hex.StoredInput = "10";
            uDec = converter.Convert(hex);
            Assert.AreEqual("16", uDec.StoredInput);
            hex.StoredInput = "ff";
            uDec = converter.Convert(hex);
            Assert.AreEqual("255", uDec.StoredInput);
        }

        public void ConvertFromUnfixedOct()
        {
            uDec = converter.Convert(oct);
            Assert.AreEqual("0", uDec.StoredInput);
            oct.StoredInput = "1";
            uDec = converter.Convert(oct);
            Assert.AreEqual("1", uDec.StoredInput);
            oct.StoredInput = "5";
            uDec = converter.Convert(oct);
            Assert.AreEqual("5", uDec.StoredInput);
            oct.StoredInput = "10";
            uDec = converter.Convert(oct);
            Assert.AreEqual("8", uDec.StoredInput);
            oct.StoredInput = "377";
            uDec = converter.Convert(oct);
            Assert.AreEqual("255", uDec.StoredInput);
        }
    }
}
