using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace binary_calculator.Wrappers.Integers
{
    public class BinOctHexWrapper: GenericWrapper
    {
        


        #region "constants for whole class"

        #endregion


        #region "Properties"

        private int _allowedNumberOfBits;
        private string _storedInput;
        private NumberBaseChoice _choice;
        private binary_calculator.dictionaries.Filters _filter;

        public int allowedNumberOfBits
        {
            get { return _allowedNumberOfBits; }
            set { _allowedNumberOfBits = value; }
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
                    if (value.Length <= allowedNumberOfBits) _storedInput = value;
                    if (value.Length == 0) _storedInput = "0";
                }

            }
        }

        public NumberBaseChoice baseChoice
        {
            get { return _choice; }
            set 
            { 
                _choice = value;
            }
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

        public BinOctHexWrapper(NumberBaseChoice choice,int size = 8, string input = "")
        {
            baseChoice = choice;
            allowedNumberOfBits = size;
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

        private bool IsSizeLegal(int size, NumberBaseChoice type)
        {
            bool result = true;

            int denominator = (int)Math.Log((double)type, 2);



            return result;
        }

        #endregion
    }
}
