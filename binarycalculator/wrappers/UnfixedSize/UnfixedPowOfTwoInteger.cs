using binary_calculator.EnumsAndConstants;
using binary_calculator.Utilities;

namespace binary_calculator.Wrappers.UnfixedSize
{
    public class UnfixedPowOfTwoInteger : UndefinedNumber
    {
        private PowOfTwoBases _baseChoice;

        private PowOfTwoBases baseChoice
        {
            get { return _baseChoice; }
            set //should this be changed to protected or something?
            {

                _baseChoice = value;
                StoredInput = "0";
            }
        }


        public override string StoredInput
        {
            get
            {
                return base.StoredInput;
            }
            set
            {
                if (StoredInput == null || StoredInput.Length == 0)
                {
                    base.StoredInput = "0";
                }

                bool inputAllowed = GlobalUtilities.AreAllCharsOfInputLegal(value, baseChoice.numberBase);
                if (inputAllowed)
                {
                    base.StoredInput = value;
                    if (value.Length == 0) base.StoredInput = "0";
                }
            }
        }

        

        

        #region "properties"
        #endregion

        #region "contructors"
        public UnfixedPowOfTwoInteger(PowOfTwoBases type, string input = "")
        {
            this.baseChoice = type;
            StoredInput = input;
        }
        #endregion

        #region "public methods"
        public NumberBases GetNumberBase()
        {
            return this.baseChoice.numberBase;
        }
        #endregion

        #region "private methods"
        protected override void SetStoredInput(string input)
        {
            this.StoredInput = input;
        }
        #endregion

    }
}
