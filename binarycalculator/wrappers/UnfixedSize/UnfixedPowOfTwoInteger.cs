﻿using binary_calculator.Enums;

namespace binary_calculator.Wrappers.UnfixedSize
{
    public class UnfixedPowOfTwoInteger: GenericWrapper
    {
        private PowOfTwoBases _baseChoice;

        public PowOfTwoBases baseChoice
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

        public UnfixedPowOfTwoInteger(PowOfTwoBases type, string input = "")
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