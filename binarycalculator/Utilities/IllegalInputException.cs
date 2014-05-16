using binary_calculator.EnumsAndConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Utilities
{
    public class IllegalInputException: Exception
    {
        public IllegalInputException()
            : base("The input either used illegal characters or was out of range for the current number base")
        { }

        public IllegalInputException(string message)
            :base(message)
        { }

        public IllegalInputException(string message, Exception innerException)
            : base(message,innerException)
        { }

        public IllegalInputException(Exception innerException)
            : base("The input either used illegal characters or was out of range for the current number base", innerException)
        { }
    }
}
