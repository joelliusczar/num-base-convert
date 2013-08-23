using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Enums
{
    /// <summary>
    /// This class is an encapsulation of number base that is used to restrict number base to a select types while maintaining compatibility.
    /// </summary>
    public class NumberBasesPowerOfTwo 
    {
        public enum BaseChoice { BASE_TWO = 2, BASE_EIGHT = 8, BASE_SIXTEEN = 16 }
        private NumberBases _numberBase;

        public NumberBases numberBase
        {
            get { return _numberBase; }
            private set { _numberBase = value; }
        }

        public NumberBasesPowerOfTwo(BaseChoice choice)
        {
            setChoice(choice);
        }

        public void setChoice(BaseChoice choice)
        {
            switch (choice)
            {
                case BaseChoice.BASE_TWO:
                    numberBase = NumberBases.BASE_TWO;
                    break;
                case BaseChoice.BASE_EIGHT:
                    numberBase = NumberBases.BASE_EIGHT;
                    break;
                case BaseChoice.BASE_SIXTEEN:
                    numberBase = NumberBases.BASE_SIXTEEN;
                    break;
                
            }
        }
        
    }
}
