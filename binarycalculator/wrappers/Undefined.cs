using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Wrappers
{
    public abstract class Undefined
    {
        
        #region "properties"
        private string _storedInput;

        public virtual string StoredInput
        {
            get { return _storedInput; }
            set 
            {
                if (string.IsNullOrEmpty(_storedInput))
                {
                    _storedInput = "0";
                }
                _storedInput = value; 
            }
        }
        #endregion

        #region "contructors"
        #endregion

        #region "public methods"
        public virtual void AddChar(char digit)
        {
            string storeConcat = StoredInput + digit;
            this.SetStoredInput(storeConcat);
        }

        public virtual void DeleteCharFromBack()
        {
            string temp = "";
            if (!string.IsNullOrEmpty(this.StoredInput))
            {
                temp = StoredInput.Substring(0, StoredInput.Length - 1);
            }
            this.SetStoredInput(temp);
        }

        public virtual void DeleteCharFromFront()
        {
            string temp = "";
            if (!string.IsNullOrEmpty(this.StoredInput))
            {
                temp = StoredInput.Substring(1);
            }
            this.SetStoredInput(temp);
        }

        public void ClearInput()
        {
            this.SetStoredInput("0");
        }


        public override string ToString()
        {
            return StoredInput;
        }
        #endregion

        #region "private methods"
        protected abstract void SetStoredInput(string input);

        #endregion
    }
}
