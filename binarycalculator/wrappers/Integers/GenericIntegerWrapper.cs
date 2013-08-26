
namespace binary_calculator.Wrappers.Integers
{
    public abstract class GenericIntegerWrapper:GenericWrapper  
    {
        

        #region "constants for whole class"

        #endregion

        #region "Properties"
        private int _allowedNumberOfBits; 

        public virtual int allowedNumberOfBits
        {
            get { return _allowedNumberOfBits; }
            set 
            {
                _allowedNumberOfBits = value;               
            }
        }
        #endregion

        #region "Public Methods"

        #endregion

        #region "Private Methods"


        #endregion
    }
}
