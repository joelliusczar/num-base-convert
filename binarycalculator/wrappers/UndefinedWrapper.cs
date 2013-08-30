using System.Linq;
using binary_calculator.Enums;

namespace binary_calculator.Wrappers
{
    public abstract class UndefinedWrapper
    {
        

            #region "constants for whole class"

            #endregion


            #region "Properties"

            private string _storedInput;
            private binary_calculator.dictionaries.Filters _filter;

            public virtual string storedInput
            {
                get 
                {
                    if (_storedInput == null || _storedInput.Length == 0)
                    {
                        _storedInput = "0";
                    }
                    return _storedInput; 
                }
                protected set { _storedInput = value; }
            }

            protected binary_calculator.dictionaries.Filters filter
            {
                get
                {
                    if (_filter == null)
                        _filter = new binary_calculator.dictionaries.Filters();

                    return _filter;
                }
            }
        
            #endregion

            #region "Public Methods"
            public virtual void ClearInput()
            {
                storedInput = "0";
            }

            public virtual void AddChar(char digit)
            {
                string storeConcat = string.Concat(storedInput, digit.ToString());
                storedInput = storeConcat;
            }

            public virtual void deleteChar()
            {
                string temp = storedInput.Substring(0, storedInput.Length - 1);
                storedInput = temp;
            }

            public override string ToString()
            {
                return storedInput;
            }
            #endregion

            #region "Private Methods"
            private bool CheckIfContains(string input, string illegalChars)
            {
                bool result = false;

                result = input.All(c => !illegalChars.Contains(c)); //this can be fixed to make it quicker

                return result;
            }

            protected bool AreAllCharsOfInputLegal(string input, NumberBases baseChoice)
            {
                bool result = true;


                string illegalChars = filter.GetIllegalChars(baseChoice);

                result = CheckIfContains(input, illegalChars);

                return result;
            }

            
            #endregion

            
        
    }
}
