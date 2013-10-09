using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using binary_calculator.Converters;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.EnumsAndConstants;

namespace TestBinCalc.TestObjects
{
    [TestFixture]
    public class ConverterToAny_TEST
    {
        [Test]
        public void ConverterToAny_DEMO()
        {
            ConvertDecToBin();
        }

        public void ConvertDecToBin()
        {
            UnfixedDecInteger dec = new UnfixedDecInteger(0);
            ConverterToAny converter = new ConverterToAny();
            UnfixedAnyInteger any = converter.Convert(dec, NumberBases.BASE_TWO);
            Assert.AreEqual("0", any.StoredInput);
            dec.StoredNumber = 1;
            any = converter.Convert(dec, NumberBases.BASE_TWO);
            Assert.AreEqual("1", any.StoredInput);
            dec.StoredNumber = 2;
            any = converter.Convert(dec, NumberBases.BASE_TWO);
            Assert.AreEqual("10", any.StoredInput);
            dec.StoredNumber = 3;
            any = converter.Convert(dec, NumberBases.BASE_TWO);
            Assert.AreEqual("11", any.StoredInput);
            dec.StoredNumber = 4;
            any = converter.Convert(dec, NumberBases.BASE_TWO);
            Assert.AreEqual("100", any.StoredInput);
            dec.StoredNumber = 8;
            any = converter.Convert(dec, NumberBases.BASE_TWO);
            Assert.AreEqual("1000", any.StoredInput);
            dec.StoredNumber = 15;
            any = converter.Convert(dec, NumberBases.BASE_TWO);
            Assert.AreEqual("1111", any.StoredInput);
            dec.StoredNumber = 16;
            any = converter.Convert(dec, NumberBases.BASE_TWO);
            Assert.AreEqual("10000", any.StoredInput);
            dec.StoredNumber = 32;
            any = converter.Convert(dec, NumberBases.BASE_TWO);
            Assert.AreEqual("100000", any.StoredInput);
            dec.StoredNumber = 41;
            any = converter.Convert(dec, NumberBases.BASE_TWO);
            Assert.AreEqual("101001", any.StoredInput);
            dec.StoredNumber = 170;
            any = converter.Convert(dec, NumberBases.BASE_TWO);
            Assert.AreEqual("10101010", any.StoredInput);
            dec.StoredNumber = 255;
            any = converter.Convert(dec, NumberBases.BASE_TWO);
            Assert.AreEqual("11111111", any.StoredInput);
        }

    }
}
