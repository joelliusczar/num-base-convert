using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using binary_calculator.Utilities;

namespace TestBinCalc.TestObjects
{
    [TestFixture]
    public class BinUtilities_TEST
    {
        [Test]
        public void BinUtilities_DEMO()
        {
            GetTrimmedOffCharsFromStart_TEST();
        }

        public void GetTrimmedOffCharsFromStart_TEST()
        {
            string t1 = BinUtilities.GetTrimmedOffCharsFromStart("aaabbcc", 'a');
            Assert.AreEqual("aaa", t1);
            string t3 = BinUtilities.GetTrimmedOffCharsFromStart("", 'a');
            string t2 = BinUtilities.GetTrimmedOffCharsFromStart("aaa", 'a');
            Assert.AreEqual("aaa", t2);
            
        }
    }
}
