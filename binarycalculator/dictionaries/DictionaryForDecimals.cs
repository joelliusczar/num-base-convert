using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.dictionaries
{
    class DictionaryForDecimals
    {
        private  Dictionary<char,string> _toDecimal;

        public Dictionary<char, string> toDecimal
        {
            get 
            {
                if (_toDecimal == null) InitDictionary();

                return _toDecimal; 
            }
            private set { _toDecimal = value; }
        }


        private void InitDictionary()
        {
            toDecimal = new Dictionary<char, string>();

            #region "load dictionary"
            toDecimal.Add('0', "0");
            toDecimal.Add('1', "1");
            toDecimal.Add('2', "2");
            toDecimal.Add('3', "3");
            toDecimal.Add('4', "4");
            toDecimal.Add('5', "5");
            toDecimal.Add('6', "6");
            toDecimal.Add('7', "7");
            toDecimal.Add('8', "8");
            toDecimal.Add('9', "9");
            toDecimal.Add('A', "10");
            toDecimal.Add('B', "11");
            toDecimal.Add('C', "12");
            toDecimal.Add('D', "13");
            toDecimal.Add('E', "14");
            toDecimal.Add('F', "15");
            toDecimal.Add('G', "16");
            toDecimal.Add('H', "17");
            toDecimal.Add('I', "18");
            toDecimal.Add('J', "19");
            toDecimal.Add('K', "20");
            toDecimal.Add('L', "21");
            toDecimal.Add('M', "22");
            toDecimal.Add('N', "23");
            toDecimal.Add('O', "24");
            toDecimal.Add('P', "25");
            toDecimal.Add('Q', "26");
            toDecimal.Add('R', "27");
            toDecimal.Add('S', "28");
            toDecimal.Add('T', "29");
            toDecimal.Add('U', "30");
            toDecimal.Add('V', "31");
            toDecimal.Add('W', "32");
            toDecimal.Add('X', "33");
            toDecimal.Add('Y', "34");
            toDecimal.Add('Z', "35");
            toDecimal.Add('a', "10");
            toDecimal.Add('b', "11");
            toDecimal.Add('c', "12");
            toDecimal.Add('d', "13");
            toDecimal.Add('e', "14");
            toDecimal.Add('f', "15");
            toDecimal.Add('g', "16");
            toDecimal.Add('h', "17");
            toDecimal.Add('i', "18");
            toDecimal.Add('j', "19");
            toDecimal.Add('k', "20");
            toDecimal.Add('l', "21");
            toDecimal.Add('m', "22");
            toDecimal.Add('n', "23");
            toDecimal.Add('o', "24");
            toDecimal.Add('p', "25");
            toDecimal.Add('q', "26");
            toDecimal.Add('r', "27");
            toDecimal.Add('s', "28");
            toDecimal.Add('t', "29");
            toDecimal.Add('u', "30");
            toDecimal.Add('v', "31");
            toDecimal.Add('w', "32");
            toDecimal.Add('x', "33");
            toDecimal.Add('y', "34");
            toDecimal.Add('z', "35");
            #endregion

        }

        public string GetDecimalEquivalent(char key)
        {
            string toBeReturned = "";

            toBeReturned = toDecimal[key];

            return toBeReturned;
        }
        

    }
}
