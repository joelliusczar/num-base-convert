using System.Collections.Generic;

namespace binary_calculator.dictionaries
{
    class DictionaryForBinary
    {
       
        private  Dictionary<char,string> _toBinary;

        public Dictionary<char, string> toBinary
        {
            get 
            {
                if (_toBinary == null) InitDictionary();

                return _toBinary; 
            }
            private set { _toBinary = value; }
        }


        private void InitDictionary()
        {
            toBinary = new Dictionary<char, string>();

            #region "load dictionary"
            toBinary.Add('0', "0000");
            toBinary.Add('1', "0001");
            toBinary.Add('2', "0010");
            toBinary.Add('3', "0011");
            toBinary.Add('4', "0100");
            toBinary.Add('5', "0101");
            toBinary.Add('6', "0110");
            toBinary.Add('7', "0111");
            toBinary.Add('8', "1000");
            toBinary.Add('9', "1001");
            toBinary.Add('A', "1010");
            toBinary.Add('B', "1011");
            toBinary.Add('C', "1100");
            toBinary.Add('D', "1101");
            toBinary.Add('E', "1110");
            toBinary.Add('F', "1111");
            #endregion

        }

        public string GetEquivalent(char key)
        {
            string toBeReturned = "";

            toBeReturned = toBinary[key];

            return toBeReturned;
        }
    }
}
