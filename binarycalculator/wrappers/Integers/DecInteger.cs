using System;

namespace binary_calculator.Wrappers.Integers
{
    public class DecInteger : UndefinedIntegerWrapper
    {

        #region "constants for whole class"

        #endregion

        #region "Properties"
        private int _maxSize;

        public override string storedInput
        {
            get { return base.storedInput; }
            protected set 
            {
                long temp;
                if ( value.Length == 0) value = "0";
                bool validLong = (long.TryParse(value, out temp));
                if (TestAgainstSize(temp)&&validLong)
                {
                    base.storedInput = value;
                }
                
            }
        }

        public override int allowedNumberOfBits
        {
            get { return base.allowedNumberOfBits; }
            set
            {
                if (value < 0)
                {
                    base.allowedNumberOfBits = 1;
                    maxSize = (int)Math.Pow(2, allowedNumberOfBits);

                }
                else
                {
                    base.allowedNumberOfBits = value;
                    maxSize = (int)Math.Pow(2, allowedNumberOfBits);
                }

                storedInput = "0";
                    
            }
        }

        public int maxSize
        {
            get { return _maxSize; }
            private set { _maxSize = value; }
        }

        #endregion

        #region "Public Methods"
        /// <summary>
        /// The 
        /// </summary>
        /// <param name="bitNumber"></param>
        /// <param name="input">The Reason that this is a string is because of I want to take advantage of the AddChar method</param>
        public DecInteger(int bitNumber = 8, string input = "") 
        {
            this.allowedNumberOfBits = bitNumber;
            storedInput = input;
        }

        

        
        #endregion

        #region "Private Methods"

        private bool TestAgainstSize(long value)
        {
            return (value < maxSize)&&(value >=0);
        }

       
        #endregion
        
    }
}
