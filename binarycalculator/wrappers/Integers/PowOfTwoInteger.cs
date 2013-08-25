﻿using binary_calculator.Enums;
using binary_calculator.Wrappers.UnfixedSize;

namespace binary_calculator.Wrappers.Integers
{
    public class PowOfTwoInteger : GenericIntegerWrapper
    {
            #region "constants for whole class"

            #endregion

            #region "Properties"
            private PowOfTwoBases _choice;

            public PowOfTwoBases baseChoice
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
                        UnfixedPowOfTwoInteger powerOfTwo = new UnfixedPowOfTwoInteger(baseChoice, value);

                        Converters.Integers.ConverterToBin converter = new Converters.Integers.ConverterToBin();
                        UnfixedBinInteger bin =  converter.Convert(powerOfTwo);
                        int binLength = bin.storedInput.Length;

                        if (binLength <= this.allowedNumberOfBits) base.storedInput = value;

                        if (value.Length == 0) base.storedInput = "0";
                    }
                }
            }
            #endregion

            #region "Public Methods"
            public PowOfTwoInteger(PowOfTwoBases type, string input = "", int allowedBitNumber = 8)
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