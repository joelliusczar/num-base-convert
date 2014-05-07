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

                base.StoredInput = result.Item1;
                
            }
        }

        #endregion

        #region "contructors"
        public UnfixedBinInteger(string input = "")
        {
            this.StoredInput = input;
            
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
