using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Wrappers.Integers
{
    public class PowerOfTwoWrapperNonBin : GenericIntegerWrapper
    {
            #region "constants for whole class"

            #endregion

            #region "Properties"
            private NumberBaseChoice _choice;

            public NumberBaseChoice baseChoice
            {
                get { return _choice; }
                set
                {
                    _choice = value;
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

                    bool inputAllowed = InputAllCharsLegal(value, baseChoice);
                    if (inputAllowed)
                    {
                        binary_calculator.Converters.Integers.ConverterToBin bin = new Converters.Integers.ConverterToBin();


                        //need to do work here!!!!!!!!!!!!!!!!!!!
                        //BinWrapper binWrapper = bin.FromPowerOfTwoIntPos(
                        
                        if(value.Length == 0) base.storedInput = "0";
                    }
                }
            }
            #endregion

            #region "Public Methods"

            #endregion

            #region "Private Methods"


            #endregion
    }
}
