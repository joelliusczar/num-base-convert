
namespace binary_calculator.Enums
{
    /// <summary>
    /// This class is an encapsulation of number base that is used to restrict number base to a select types while maintaining compatibility.
    /// </summary>
    public class PowOfTwoBases
    {
        #region "Constants"


        #endregion

        public static readonly PowOfTwoBases BASE_TWO = new Two();
        public static readonly PowOfTwoBases BASE_EIGHT = new Eight();
        public static readonly PowOfTwoBases BASE_SIXTEEN = new Sixteen();
        //public enum BaseChoice { BASE_TWO = 2, BASE_EIGHT = 8, BASE_SIXTEEN = 16 }
        private NumberBases _numberBase;
        protected int toInt = 0;

        public NumberBases numberBase
        {
            get { return _numberBase; }
            private set 
            {
                toInt = (int)value;
                _numberBase = value; 
            }
        }

        public PowOfTwoBases(PowOfTwoBases choice)
        {
            setChoice(choice);
        }

        protected PowOfTwoBases(int value)
        {
            toInt = value;
        }

        public void setChoice(PowOfTwoBases baseChoice)
        {
            int choice = baseChoice.toInt;
            switch (choice)
            {
                case 2:
                    numberBase = NumberBases.BASE_TWO;
                    break;
                case 8:
                    numberBase = NumberBases.BASE_EIGHT;
                    break;
                case 16:
                    numberBase = NumberBases.BASE_SIXTEEN;
                    break;
                
            }
        }

        public override string ToString()
        {
            return numberBase.ToString();
        }

        #region "internal classes"
        

        public class Two: PowOfTwoBases
        {
            public Two() : base(2) { }
        }

        public class Eight : PowOfTwoBases
        {
            public Eight() : base(8) { }
        }

        public class Sixteen :PowOfTwoBases
        {
            public Sixteen() : base(16) { }
        }
        #endregion
    }
}
