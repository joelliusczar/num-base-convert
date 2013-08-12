using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace binary_calculator.Wrappers
{
    public class WrapperIntNonDecimal: WrapperGeneric
    {
        


        #region "constants for whole class"

        #endregion


        #region "Properties"

        private int _allowedLength;
        private string _storedInput;
        private NumberBaseChoice _choice;
        private binary_calculator.dictionaries.Filters _filter;

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
                if (storedInput == null || storedInput.Length == 0)
                {
                    _storedInput = "0";
                }

                bool inputAllowed = InputAllCharsLegal(value);
                if (inputAllowed)
                {
                    if (value.Length <= allowedLength) _storedInput = value;
                    if (value.Length == 0) _storedInput = "0";
                }

            }
        }

        public NumberBaseChoice baseChoice
        {
            get { return _choice; }
            set { _choice = value; }
        }

        private binary_calculator.dictionaries.Filters filter
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

        public WrapperIntNonDecimal(NumberBaseChoice choice,int size = 8, string input = "")
        {
            baseChoice = choice;
            allowedLength = size;
            storedInput = input;
        }

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
        protected bool InputAllCharsLegal(string input)
        {
            bool result = true;

            
            string illegalChars = filter.GetIllegalChars(baseChoice);

            result = input.All(c => !illegalChars.Contains(c)); //this can be fixed to make it quicker

            return result;
        }

        #endregion
    }
}
