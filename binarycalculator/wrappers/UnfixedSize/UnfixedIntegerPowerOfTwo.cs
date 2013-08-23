using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Enums;

namespace binary_calculator.Wrappers.UnfixedSize
{
    public class UnfixedIntegerPowerOfTwo: GenericWrapper
    {
        private NumberBasesPowerOfTwo _baseChoice;

        public NumberBasesPowerOfTwo baseChoice
        {
            get { return _baseChoice; }
            private set 
            {

                _baseChoice = value;
                storedInput = "0";
            }
        }


        public override string storedInput
        {
            get
            {
                return base.storedInput;
            }
            protected set
            {
                if (storedInput == null || storedInput.Length == 0)
                    {
                        base.storedInput = "0";
                    }

                bool inputAllowed = AreAllCharsOfInputLegal(value, baseChoice.numberBase);
                if (inputAllowed)
                {
                    base.storedInput = value;
                    if (value.Length == 0) base.storedInput = "0";
                }
            }
        }

        public UnfixedIntegerPowerOfTwo(NumberBasesPowerOfTwo type, string input = "")
        {
            this.baseChoice = type;
            storedInput = input;
        }

        public NumberBases GetNumberBase()
        {
            return this.baseChoice.numberBase;
        }

    }
}
