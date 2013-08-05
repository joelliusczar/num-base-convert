using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Inputs
{
    public abstract class InputGeneric
    {
        

            #region "constants for whole class"

            #endregion


            #region "Properties"
            private int _bitNumber;

            public int bitNumber
            {
                get { return _bitNumber; }
                set
                {
                    if (value < 0)
                    {
                        _bitNumber = 1;
                        maxSize = (int)Math.Pow(2, bitNumber);
                    }
                    else
                    {
                        _bitNumber = value;
                    }
                }
            }

            private int _maxSize;

            public int maxSize
            {
                get { return _maxSize; }
                private set { _maxSize = value; }
            }
        
            #endregion

            #region "Public Methods"

            #endregion

            #region "Private Methods"

            #endregion

            
        
    }
}
