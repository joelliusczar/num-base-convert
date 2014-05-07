using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.EnumsAndConstants;

namespace binary_calculator.Utilities
{
    public class IncorrectNumberBaseException: Exception
    {
        public IncorrectNumberBaseException()
            : base("That character is outside of the number range for the number base currently being used")
        { }
        
        public IncorrectNumberBaseException(char violatingChar)
            :base(string.Format("The character: {0} is outside of the number range for the number base currently being used",violatingChar))
        { }

        public IncorrectNumberBaseException(char violatingChar, NumberBases currentBase)
            : base(string.Format("The character: {0} is outside of the number range for the number base: {1}", violatingChar,currentBase))
        { }

        public IncorrectNumberBaseException(string message)
            :base(message)
        { }

        public IncorrectNumberBaseException(string message, Exception innerException)
            : base(message,innerException)
        { }

        public IncorrectNumberBaseException(char violatingChar, NumberBases currentBase, Exception innerException)
            : base(string.Format("The character: {0} is outside of the number range for the number base: {1}", violatingChar, currentBase), innerException)
        { }

        public IncorrectNumberBaseException(char violatingChar, Exception innerException)
            : base(string.Format("The character: {0} is outside of the number range for the number base currently being used", violatingChar),innerException)
        { }

        public IncorrectNumberBaseException(Exception innerException)
            : base("That character is outside of the number range for the number base currently being used",innerException)
        { }
    }
}
