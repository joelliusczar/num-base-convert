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
    public class ConverterToBin_DEMO
    {
        private ConverterToBin test;
        private DecInteger dec;
        private PowOfTwoInteger powOfTwo;
        private UnfixedPowOfTwoInteger UnfixedPowOfTwo;
        public int size;
        public PowOfTwoBases choice;
        

        public ConverterToBin_DEMO(int size,PowOfTwoBases choice)
        {
            test = new ConverterToBin();
            this.size = size;
            this.choice = choice;
        }

        public void ConvertDec(string input)
        {
            dec = new DecInteger(this.size, input);

            BinInteger bin =  test.Convert(dec);

            Console.Write("ConvertToDec\n");
            Console.Write("Input: {0}\n",input);
            Console.Write("storedInput: {0}\n", bin.storedInput);
            Console.Write("storedInput length: {0}\n", bin.storedInput.Length);
            Console.Write("allowedNumberOfBits: {0}",bin.allowedNumberOfBits);

        }

        public void ConvertPowOfTwo(string input)
        {
            powOfTwo = new PowOfTwoInteger(choice, input, this.size);

            BinInteger bin = test.Convert(powOfTwo);
            Console.Write("ConvertToPowOfTwo\n");
            Console.Write("Input: {0}\n", input);
            Console.Write("Number Base: {0}\n", choice);
            Console.Write("result: {0}\n", bin.storedInput);
            Console.Write("result length: {0}\n", bin.storedInput.Length);
            Console.Write("result allowedNumberOfBits: {0}\n", bin.allowedNumberOfBits);
        }

        public void ConvertUnfixedPowOfTwo(string input)
        {
            UnfixedPowOfTwo = new UnfixedPowOfTwoInteger(choice, input);

            UnfixedBinInteger bin = test.Convert(UnfixedPowOfTwo);
            Console.Write("ConvertToUnfixedPowOfTwo\n");
            Console.Write("Input: {0}\n", input);
            Console.Write("result: {0}\n", bin.storedInput);
            Console.Write("result length: {0}\n", bin.storedInput.Length);
            Console.Write("storedInput length: {0}\n", UnfixedPowOfTwo.storedInput.Length);
        }

    }
}
