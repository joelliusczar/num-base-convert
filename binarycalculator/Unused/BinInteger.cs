//using binary_calculator.EnumsAndConstants;



//namespace binary_calculator.Wrappers.Integers
//{
//    public class BinInteger : UndefinedIntegerWrapper
//    {
        
//        #region "constants for whole class"
        
//        #endregion

//        #region "Properties"


//        public override string storedInput
//        {
//            get { return FillOutWithSelectChar(base.storedInput); }
//            set 
//            {
                

//                bool inputAllowed = AreAllCharsOfInputLegal(value,NumberBases.BASE_TWO);
//                if (inputAllowed)
//                {
//                    if (value.Length <= GetAllowedLength()) base.storedInput = value;
//                    if (value.Length == 0) base.storedInput = "0";
//                }

//            }
//        }

        

//        public override int allowedNumberOfBits
//        {
//            get
//            {
//                return base.allowedNumberOfBits;
//            }
//            set
//            {
//                base.allowedNumberOfBits = value;
//                storedInput = "";
                    
//            }
//        }

        
//        #endregion

//        #region "Public Methods"

//        public BinInteger(int size = 8, string input = "")
//        {
            
//            allowedNumberOfBits = size;
//            storedInput = input;
//        }


//        #endregion

//        #region "Private Methods"
//        protected virtual string FillOutWithSelectChar(string input)
//        {
//            string result = "";
//            int numberOfFillerZerosNeeded = GetAllowedLength() - input.Length;
//            string filler = new string(Constants.ZERO, numberOfFillerZerosNeeded);
//            result = string.Concat(filler, input);

//            return result;
//        }

//        protected virtual int GetAllowedLength()
//        {
//            return allowedNumberOfBits; 
//        }

        
//        #endregion
//    }
//}
