using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Inputs
{
    public class InputIntDecimal:InputGeneric
    {

        #region "constants for whole class"

        #endregion

        #region "Properties"
        private long _storedNumber;

        public long storedNumber
        {
            get { return _storedNumber; }
            private set { _storedNumber = value; }
        }

        private string _storedInput;

        public string storedInput
        {
            get { return _storedInput; }
            private set 
            {
                long temp;
                if ( value.Length == 0) value = "0";
                bool validLong = (long.TryParse(value, out temp));
                if (TestAgainstSize(temp)&&validLong)
                {
                    _storedInput = value;
                    storedNumber = temp;
                }
                
            }
        }

        #endregion

        #region "Public Methods"
        public InputIntDecimal(int bitNumber = 8, string input = "")
        {
            this.bitNumber = bitNumber;
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
        #endregion

        #region "Private Methods"
        private void copyInput(InputIntDecimal input)
        {
            this.bitNumber = input.bitNumber;
            this.storedInput = input.storedInput;
        }

        private bool TestAgainstSize(long value)
        {
            return (value < maxSize)&&(value >=0);
        }

        
        #endregion
        
    }
}
