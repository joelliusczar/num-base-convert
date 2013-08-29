using binary_calculator.Enums;

namespace binary_calculator.Wrappers.UnfixedSize
{
    public class UnfixedBinInteger: UndefinedWrapper 
    {
        #region "constants for whole class"

        #endregion

        #region "Properties"
        public override string storedInput
        {
            get
            {
                return base.storedInput;
            }
            protected set
            {
                if (base.storedInput == null || base.storedInput.Length == 0)
                {
                    base.storedInput = "0";
                }

                bool inputAllowed = AreAllCharsOfInputLegal(value, NumberBases.BASE_TWO);
                if (inputAllowed)
                {
                    value = value.TrimStart('0');

                    if (value.Length == 0) base.storedInput = "0";
                    else base.storedInput = value;


                }
            }
        }
        #endregion

        #region "Public Methods"
        public UnfixedBinInteger(string input)
        {
            this.storedInput = input;
        }

        #endregion

        #region "Private Methods"


        #endregion
    }
}
