using binary_calculator.EnumsAndConstants;
using binary_calculator.Utilities;

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

                string result = "";

                bool isValid = BinUtilities.VerifyInput(value,base.StoredInput,out result);

                base.StoredInput = result;
                
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
