using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator
{
    public class OutsideValueException: ApplicationException 
    {
        public OutsideValueException() { }

        public OutsideValueException(string message) { }
        public OutsideValueException(string message, System.Exception inner) { }

        protected OutsideValueException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }

    }
}
