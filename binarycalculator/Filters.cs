using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator
{
    public enum NumberBaseChoice 
    {
        BASE_TWO = 2,
        BASE_EIGHT = 8,
        BASE_SIXTEEN = 16
    }

    public class Filters
    {

        private Dictionary<NumberBaseChoice,string> _illegalCharLists;

        private Dictionary<NumberBaseChoice,string> illegalCharLists
        {
            get { return _illegalCharLists; }
            set { _illegalCharLists = value; }
        }

        public Filters()
        {
            #region "dictionary"
            illegalCharLists = new Dictionary<NumberBaseChoice, string>();
            illegalCharLists.Add(NumberBaseChoice.BASE_TWO,
                "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"23456789");
            illegalCharLists.Add(NumberBaseChoice.BASE_SIXTEEN,
                "GHIJKLMNOPQRSTUVWXYZghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"");
            illegalCharLists.Add(NumberBaseChoice.BASE_EIGHT,
                "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"89");
            #endregion
        }

        public string GetIllegalChars(NumberBaseChoice choice)
        {
            string toBeReturned = "";
            
            toBeReturned = illegalCharLists[choice];

            return toBeReturned;
        }
    }
}
