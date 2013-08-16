using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Wrappers
{
    public abstract class GenericWrapper
    {
        

            #region "constants for whole class"

            #endregion


            #region "Properties"

            protected string _storedInput;
            private binary_calculator.dictionaries.Filters _filter;

            public virtual string storedInput
            {
                get { return _storedInput; }
                protected set { _storedInput = value; }
            }

            protected binary_calculator.dictionaries.Filters filter
            {
                get
                {
                    if (_filter == null)
                        _filter = new binary_calculator.dictionaries.Filters();

                    return _filter;
                }
                set { _filter = value; }
            }
        
            #endregion

            #region "Public Methods"
            public void ClearInput()
            {
                storedInput = "0";
            }

            public void AddChar(char digit)
            {
                string storeConcat = string.Concat(storedInput, digit.ToString());
                storedInput = storeConcat;
            }

            public void deleteChar()
            {
                string temp = storedInput.Substring(0, storedInput.Length - 1);
                storedInput = temp;
            }

            public override string ToString()
            {
                return storedInput;
            }
            #endregion

            #region "Private Methods"
            protected bool InputAllCharsLegal(string input, NumberBaseChoice baseChoice)
            {
                bool result = true;


                string illegalChars = filter.GetIllegalChars(baseChoice);

                result = input.All(c => !illegalChars.Contains(c)); //this can be fixed to make it quicker

                return result;
            }      
            #endregion

            
        
    }
}
