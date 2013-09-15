using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Wrappers.UnfixedSize
{
    public class UnfixedDecInteger: UndefinedWrapper
    {

        #region "constants for whole class"

        #endregion

        #region "Properties"

        private long _storedNumber;

        public long StoredNumber
        {
            get { return _storedNumber; }
            set { _storedNumber = value; }
        }


        public override string storedInput
        {
            get
            {
                return base.storedInput;
            }
            set
            {
                long temp;
                if (value.Length == 0) value = "0";
                bool validLong = (long.TryParse(value, out temp));
                if (validLong)
                {
                    base.storedInput = value;
                    this.StoredNumber = temp;
                }
            }
        }
        #endregion

        #region "Public Methods"
        public UnfixedDecInteger(string input = "")
        {
            storedInput = input;
        }

        public UnfixedDecInteger(long input = 0)
        {
            storedInput = input.ToString();
        }
        #endregion

        #region "Private Methods"


        #endregion

        
    }
}
