using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Wrappers.Integers
{
    public class DecWrapper:GenericWrapper
    {

        #region "constants for whole class"

        #endregion

        #region "Properties"
        private long _storedNumber;
        private string _storedInput;
        private int _bitNumber;
        private int _maxSize;
        
        public long storedNumber
        {
            get { return _storedNumber; }
            private set { _storedNumber = value; }
        }        

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
                    maxSize = (int)Math.Pow(2, bitNumber);
                }
            }
        }

        public int maxSize
        {
            get { return _maxSize; }
            private set { _maxSize = value; }
        }

        #endregion

        #region "Public Methods"
        public DecWrapper(int bitNumber = 8, string input = "")
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

        public override string ToString()
        {
            return storedInput;
        }
        #endregion

        #region "Private Methods"
        private void copyInput(DecWrapper input)
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
