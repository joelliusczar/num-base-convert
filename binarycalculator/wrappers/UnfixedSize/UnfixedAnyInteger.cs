using binary_calculator.EnumsAndConstants;

namespace binary_calculator.Wrappers.UnfixedSize
{
    public class UnfixedAnyInteger: UndefinedWrapper 
    {
        
        #region "constants for whole class"

        #endregion

        #region "Properties"
        private NumberBases _choice;

        public override string storedInput
        {
            get
            {
                return base.storedInput;
            }
            set
            {
                if (base.storedInput == null || base.storedInput.Length == 0)
                {
                    base.storedInput = "0";
                }

                bool inputAllowed = AreAllCharsOfInputLegal(value, baseChoice);
                if (inputAllowed)
                {
                    if (value.Length == 0) base.storedInput = "0";
                    else base.storedInput = value;
                }
            }
        }

        public NumberBases baseChoice
        {
            get { return _choice; }
            set
            {
                _choice = value;
                storedInput = "0"; //resets the number so that there are no illegal characters according to the new number base.
            }
        }
        #endregion

        #region "Public Methods"
        public UnfixedAnyInteger(NumberBases type, string input = "")
        {
            this.baseChoice = type;
            this.storedInput = input;
        }
        #endregion

        #region "Private Methods"
        

        #endregion

    }
}
