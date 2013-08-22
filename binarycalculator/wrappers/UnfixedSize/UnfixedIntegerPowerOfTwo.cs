using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Enums;

namespace binary_calculator.Wrappers.UnfixedSize
{
    class UnfixedIntegerPowerOfTwo: GenericWrapper
    {
        private NumberBases _type;

        public NumberBases type
        {
            get { return _type; }
            private set 
            {

                _type = value;
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
                base.storedInput = value;
            }
        }

        public UnfixedIntegerPowerOfTwo(NumberBasesPowerOfTwo type, string input = "")
        {
            this.type = type.type;
            storedInput = input;
        }

        public void SetNumberBase(NumberBasesPowerOfTwo type)
        {
            this.type = type.type;
        }

    }
}
