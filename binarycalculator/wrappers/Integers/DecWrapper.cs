﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Wrappers.Integers
{
    public class DecWrapper : GenericIntegerWrapper
    {

        #region "constants for whole class"

        #endregion

        #region "Properties"
        private long _storedNumber;
        private int _maxSize;
        
        public long storedNumber
        {
            get { return _storedNumber; }
            private set { _storedNumber = value; }
        }        

        public override string storedInput
        {
            get { return _storedInput; }
            protected set 
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

        public override int allowedNumberOfBits
        {
            get { return _allowedNumberOfBits; }
            set
            {
                if (value < 0)
                {
                    _allowedNumberOfBits = 1;
                    maxSize = (int)Math.Pow(2, allowedNumberOfBits);
                }
                else
                {
                    _allowedNumberOfBits = value;
                    maxSize = (int)Math.Pow(2, allowedNumberOfBits);
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
            this.allowedNumberOfBits = bitNumber;
            storedInput = input;
        }

        

        
        #endregion

        #region "Private Methods"
        private void copyInput(DecWrapper input)
        {
            this.allowedNumberOfBits = input.allowedNumberOfBits;
            this.storedInput = input.storedInput;
        }

        private bool TestAgainstSize(long value)
        {
            return (value < maxSize)&&(value >=0);
        }

        
        #endregion
        
    }
}
