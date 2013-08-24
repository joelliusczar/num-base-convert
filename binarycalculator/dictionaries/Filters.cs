using System.Collections.Generic;
using binary_calculator.Enums;

namespace binary_calculator.dictionaries
{
    
    //need to fix this class to account for the switch I am making in how I handle enums
    public class Filters
    {

        private Dictionary<NumberBases,string> _illegalCharLists;

        private Dictionary<NumberBases,string> illegalCharLists
        {
            get { return _illegalCharLists; }
            set { _illegalCharLists = value; }
        }

        public Filters()
        {
            #region "dictionary"
            illegalCharLists = new Dictionary<NumberBases, string>();
            illegalCharLists.Add(NumberBases.BASE_TWO,
                "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"23456789");
            illegalCharLists.Add(NumberBases.BASE_SIXTEEN,
                "GHIJKLMNOPQRSTUVWXYZghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"");
            illegalCharLists.Add(NumberBases.BASE_EIGHT,
                "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"89");
            #endregion
        }

        public string GetIllegalChars(NumberBases choice)
        {
            string toBeReturned = "";
            
            toBeReturned = illegalCharLists[choice];

            return toBeReturned;
        }

        
    }
}
