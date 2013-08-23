using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Enums;
using binary_calculator.Wrappers.UnfixedSize;

namespace binary_calculator.Wrappers.Integers
{
    public class PowerOfTwoWrapperNonBin : GenericIntegerWrapper
    {
            #region "constants for whole class"

            #endregion

            #region "Properties"
            private NumberBasesPowerOfTwo _choice;

            public NumberBasesPowerOfTwo baseChoice
            {
                get { return _choice; }
                private set
                {
                    _choice = value;
                    storedInput = "0"; //resets the number so that there are no illegal characters according to the new number base.
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
                        UnfixedIntegerPowerOfTwo powerOfTwo = new UnfixedIntegerPowerOfTwo(baseChoice, value);

                        Converters.Integers.ConverterToBin converter = new Converters.Integers.ConverterToBin();
                        UnfixedBin bin =  converter.Convert(powerOfTwo);
                        int binLength = bin.storedInput.Length;

                        if (binLength <= this.allowedNumberOfBits) base.storedInput = value;

                        if (value.Length == 0) base.storedInput = "0";
                    }
                }
            }
            #endregion

            #region "Public Methods"
            public PowerOfTwoWrapperNonBin(NumberBasesPowerOfTwo type, string input = "", int allowedBitNumber = 8)
            {
                this.allowedNumberOfBits = allowedBitNumber;
                this.baseChoice = type;
                this.storedInput = input;
            }

            public NumberBases GetNumberBase()
            {
                return this.baseChoice.numberBase;
            }
            #endregion

            #region "Private Methods"
            

            #endregion
    }
}
