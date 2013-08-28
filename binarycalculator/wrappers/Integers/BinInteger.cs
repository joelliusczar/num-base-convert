using binary_calculator.Enums;



namespace binary_calculator.Wrappers.Integers
{
    public class BinInteger : UndefinedIntegerWrapper
    {
        
        #region "constants for whole class"
        protected const char FILL_STRING_WITH_THIS_CHAR__ZERO = '0';
        #endregion

        #region "Properties"


        public override string storedInput
        {
            get { return base.storedInput; }
            protected set 
            {
                

                bool inputAllowed = AreAllCharsOfInputLegal(value,NumberBases.BASE_TWO);
                if (inputAllowed)
                {
                    if (value.Length <= allowedNumberOfBits) base.storedInput = value;
                    if (value.Length == 0) base.storedInput = "0";
                }

                int numberOfFillerZerosNeeded = allowedNumberOfBits - base.storedInput.Length;
                string filler = new string(FILL_STRING_WITH_THIS_CHAR__ZERO, numberOfFillerZerosNeeded);
                base.storedInput = string.Concat(filler, base.storedInput);
            }
        }

        public override int allowedNumberOfBits
        {
            get
            {
                return base.allowedNumberOfBits;
            }
            set
            {
                base.allowedNumberOfBits = value;
                storedInput = "";
                    
            }
        }

        
        #endregion

        #region "Public Methods"

        public BinInteger(int size = 8, string input = "")
        {
            
            allowedNumberOfBits = size;
            storedInput = input;
        }


        #endregion

        #region "Private Methods"

        #endregion
    }
}
