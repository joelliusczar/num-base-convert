using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Inputs
{
    public abstract class InputIntNonDecimal: InputGeneric
    {
        


        #region "constants for whole class"

        #endregion


        #region "Properties"

        private int _allowedLength;
        private string _storedInput;

        public int allowedLength
        {
            get { return _allowedLength; }
            set { _allowedLength = value; }
        }

        public string storedInput
        {
            get { return _storedInput; }
            protected set 
            {
                bool inputAllowed = InputAllCharsLegal(value);
                if (inputAllowed)
                {
                    if (value.Length <= allowedLength) _storedInput = value;
                    if (value.Length == 0) _storedInput = "0";
                }
            }
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
        #endregion

        #region "Private Methods"
        protected abstract bool InputAllCharsLegal(string input);
        #endregion
    }
}
