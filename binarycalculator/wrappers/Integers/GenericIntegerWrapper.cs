using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Wrappers.Integers
{
    public class GenericIntegerWrapper:GenericWrapper  
    {
        protected int _allowedNumberOfBits;

        public virtual int allowedNumberOfBits
        {
            get { return _allowedNumberOfBits; }
            set { _allowedNumberOfBits = value; }
        }
    }
}
