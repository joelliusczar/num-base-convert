using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Wrappers.UnfixedSize
{
    public class UnfixedInteger: GenericWrapper 
    {
        private NumberBaseChoice _choice;

        public override string storedInput
        {
            get
            {
                return base.storedInput;
            }
            protected set
            {
                if (base.storedInput == null || base.storedInput.Length == 0)
                {
                    base.storedInput = "0";
                }

                bool inputAllowed = InputAllCharsLegal(value, baseChoice);
                if (inputAllowed)
                {
                    if (value.Length == 0) base.storedInput = "0";
                    else base.storedInput = value;
                }
            }
        }

        public NumberBaseChoice baseChoice
        {
            get { return _choice; }
            set
            {
                _choice = value;
            }
        }

        public UnfixedInteger(NumberBaseChoice type, string input = "")
        {
            this.baseChoice = type;
            this.storedInput = input;
        }
    }
}
