using binary_calculator.EnumsAndConstants;
using binary_calculator.Utilities;
using System;

namespace binary_calculator.Wrappers.UnfixedSize
{
    public class UnfixedBinInteger: Undefined
    {
        #region "constants for whole class"

        #endregion

        #region "Properties"
        private bool _IsValid;

        public bool IsValid
        {
            get { return _IsValid; }
            private set { _IsValid = value; }
        }

        public override string StoredInput
        {
            get
            {
                return base.StoredInput;
            }
            set
            {

                Tuple<string,bool> result;

                result = BinUtilities.VerifyInputAsBin(value,base.StoredInput);
                this.IsValid = result.Item2;
                base.StoredInput = result.Item1;
                
            }
        }

        #endregion

        #region "contructors"
        public UnfixedBinInteger(string input = "")
        {
            this.StoredInput = input;
            if (!this.IsValid)
            {
                throw new IncorrectNumberBaseException();
            }
            
        }


        #endregion

        #region "Public Methods"

        #endregion

        #region "Private Methods"
        protected override void SetStoredInput(string input)
        {
            this.StoredInput = input;
        }

        #endregion
    }
}
