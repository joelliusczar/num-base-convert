using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Utilities
{
    public class BitSizeException: Exception
    {
        public BitSizeException()
            : base("That bit string will not fit in the given number of bits")
        { }

        public BitSizeException(string input)
            :base(string.Format("The bit string: {0} will not fit in the given amount of bits",input))
        { }

        public BitSizeException(string input,Exception innerException)
            : base(string.Format("The bit string: {0} will not fit in the given amount of bits", input),innerException)
        { }

        public BitSizeException(string input, int bitNumber)
            : base(string.Format("The bit string: {0} will not fit in {1} bits", input,bitNumber))
        { }

        public BitSizeException(string input, int bitNumber,Exception innerException)
            : base(string.Format("The bit string: {0} will not fit in {1} bits", input, bitNumber),innerException)
        { }

        


    }
}
