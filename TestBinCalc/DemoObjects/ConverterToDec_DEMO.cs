using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Converters.Integers;
using binary_calculator.Wrappers.Integers;
using binary_calculator.Wrappers.UnfixedSize;
using binary_calculator.EnumsAndConstants;

namespace TestBinCalc.DemoObjects
{
    public class ConverterToDec_DEMO
    {
        private ConverterToDec test;
        private BinInteger binTest;
        private PowOfTwoInteger powOfTwoTest;
        private UnfixedPowOfTwoInteger UnfixedPowOfTwoTest;
        public int size;
        public PowOfTwoBases choice;

        public ConverterToDec_DEMO(int size, PowOfTwoBases choice)
        {
            this.size = size;
            this.choice = choice;
            test = new ConverterToDec();
        }

        public void ConvertBin(string input)
        {
            binTest = new BinInteger(this.size, input);

            DecInteger dec = test.Convert(binTest);
            Console.Write("ConvertToDec\n");
            Console.Write("Input: {0}\n", input);
            Console.Write("Input length: {0}\n", input.Length);
            Console.Write("result: {0}\n", dec.storedInput);
            Console.Write("result length: {0}\n", dec.storedInput.Length);
            Console.Write("allowedNumberOfBits: {0}\n", dec.allowedNumberOfBits);
            Console.Write("\n\n\n");
        }

        
    }
}
