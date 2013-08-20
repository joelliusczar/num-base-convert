using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using binary_calculator.Enums;



namespace binary_calculator.Wrappers.Integers
{
    public class BinWrapper : GenericIntegerWrapper
    {
        
        #region "constants for whole class"

        #endregion

        #region "Properties"


        public override string storedInput
        {
            get { return _storedInput; }
            protected set 
            {
                if (storedInput == null || storedInput.Length == 0)
                {
                    _storedInput = "0";
                }

                bool inputAllowed = AreAllCharsOfInputLegal(value,NumberBasesPowerOfTwo.BASE_TWO);
                if (inputAllowed)
                {
                    if (value.Length <= allowedNumberOfBits) _storedInput = value;
                    if (value.Length == 0) _storedInput = "0";
                }

            }
        }

        
        #endregion

        #region "Public Methods"

        public BinWrapper(int size = 8, string input = "")
        {
            
            allowedNumberOfBits = size;
            storedInput = input;
        }


        #endregion

        #region "Private Methods"


        #endregion
    }
}
