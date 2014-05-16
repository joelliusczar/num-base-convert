using binary_calculator.EnumsAndConstants;
using binary_calculator.Utilities;

namespace binary_calculator.Wrappers.UnfixedSize
{
    public class UnfixedAnyInteger: UndefinedNumber
    {
        
        #region "constants for whole class"

        #endregion

        #region "Properties"
        private NumberBases _choice;

        public override string StoredInput
        {
            get
            {
                return base.StoredInput;
            }
            set
            {
                if (string.IsNullOrEmpty(base.StoredInput))
                {
                    base.StoredInput = "0";
                }

                bool inputAllowed = GlobalUtilities.AreAllCharsOfInputLegal(value, baseChoice);
                if (inputAllowed)
                {
                    if (value.Length == 0) base.StoredInput = "0";
                    else base.StoredInput = value;
                }
            }
        }

        public NumberBases baseChoice
        {
            get { return _choice; }
            set
            {
                _choice = value;
                StoredInput = "0"; //resets the number so that there are no illegal characters according to the new number base.
            }
        }
        #endregion

        #region "Public Methods"
        public UnfixedAnyInteger(NumberBases type, string input = "")
        {
            this.baseChoice = type;
            this.StoredInput = input;
        }
        #endregion

        #region "Private Methods"
        protected override void SetStoredInput(string input)
        {
            this.StoredInput = input;
        }

        #endregion

    }
}
