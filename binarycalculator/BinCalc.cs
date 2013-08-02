using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace binary_calculator
{//namespace
    class BinCalc
    {//class

        #region "constants for whole class"
        private const char fillStringWithThisChar_Zero = '0',
            fillStringWithThisChar_One = '1',
            searchForThisChar_Zero = '0',
            seachForThisChar_One = '1',
            negativeSignBit = '1',
            positiveSignBit = '0',
            impliedOneInFront = '1';
        private const int noFixedSizeForIntegerPart = -1,
         necessaryExponentAdjustment = 1, 
         necessaryExcessAdjustment = 1,
         extraBitForSign = 1,
         firstCharLocation = 1,
         necessaryRangeAdjustment = 1;
        #endregion

        //constants for easy option settings
        public const int NUMBASE_BIN = 2;
        public const int NUMBASE_OCT = 8;
        public const int NUMBASE_DEC = 10;
        public const int NUMBASE_HEX = 16;

        public const int DATATYPE_UNSIGNED = 0;
        public const int DATATYPE_SIGNED = 1;
        public const int DATATYPE_FRACTION = -1;
        public const int DATATYPE_FLOAT = 3;

       

        #region "bin to hexOct"

        //overloaded method to convert hexidecimal or octal numbers to binary
        public static string hexOctToBin(String input, int hexOrOct, int sizeForErrorTesting)
        {
            //the overloaded method is basically for converion of non-IEE 754 values
            //calls original method
            return hexOctToBin(input, hexOrOct, sizeForErrorTesting, DATATYPE_UNSIGNED);
        }

        //convert hexidecimal or octal to binary
        public static string hexOctToBin(string input, int hexOrOct,
            int sizeXForErrorTesting, int sizeYForErrorTesting)
        {//hexOctToBin            
            //sizeXForErrorTesting and sizeYForErrorTesting
            //are normally the size of significand and
            //the size of the exponent. 
            //I left them generic so because they are interchangable

            //check for unwarnted, exception producing characters
            if (!checkInputNonFraction(input, hexOrOct))
                throw new ArgumentException();

            string result = "";
            try
            {
                //get the power of 2. Ex. 8=2^3, 16=2^4
                hexOrOct = (int)Math.Log(hexOrOct, NUMBASE_BIN);

                //4 is the number of bin digits for each hex char
                //if hexOrOct = 4(for hex) then substringStartingPoint = 0
                //if hexOrOct = 3(for oct) then substringStartingPoint = 1
                int substringStartingPoint = 4 - hexOrOct;

                //load hashtable of binary representations of each oct and hex character
                Hashtable hexOctToBinHash = loadHashForhexOctToBin();

                //one string of 1's and 0's for each hex or oct character
                string[] binArray = new string[input.Length];
                string temp;

                //convert each character to binary
                for (int i = 0; i < binArray.Length; i++)
                {//for
                    temp = (string)hexOctToBinHash[input[i]];
                    temp = temp.Substring(substringStartingPoint);
                    binArray[i] = temp;
                }//for

                result = outputAdjuster(string.Concat(binArray));
            }
            catch (NullReferenceException e)
            {
                result = "";
                printErrorReport(e);

            }

            //the length of the result should equal the length of the the significand + the length of the exponent
            if ((result.Length != sizeXForErrorTesting + sizeYForErrorTesting)&&(result.Length != sizeXForErrorTesting + sizeYForErrorTesting +1)
                &&result.Length != 0)
                throw new OutsideValueException("Input incorrect for that word size");
            

            return result;
        }//hexOctToBin

        //this method is to correct errors that got introduced after converting from octal       
        private static string outputAdjuster(string strToFix)
        {
            //4 is the number of bin digits for each hex char
            int correctStrStartingPoint = strToFix.Length % 4;

            return strToFix.Substring(correctStrStartingPoint);
        }

        public static string binToHexOct(String input, int convertBaseTo, int sizeForErrorTesting)
        {
            //the overloaded method is basically for converion of non-IEE 754 values
            return binToHexOct(input, convertBaseTo, sizeForErrorTesting, DATATYPE_UNSIGNED);
        }

        //input will be a string of 1's and 0's
        public static string binToHexOct(string input, int convertBaseTo,
            int sizeXForErrorTesting, int sizeYForErrorTesting)
        {//binTohexOct
            //sizeXForErrorTesting and sizeYForErrorTesting
            //are normally the size of significand and
            //the size of the exponent. 
            //I left them generic so because they are interchangable

            //check for unwanted characters
            if (!checkInputNonFraction(input, NUMBASE_BIN))
                throw new ArgumentException();

            //check to make sure that input has correct number of bits
            if ((input.Length != sizeXForErrorTesting + sizeYForErrorTesting) && (input.Length != sizeXForErrorTesting + sizeYForErrorTesting + 1)
                &&input.Length != 0)
                throw new OutsideValueException("Input incorrect for that word size");
            

            if (convertBaseTo == NUMBASE_OCT || convertBaseTo == NUMBASE_HEX)
            {
                //get a power of 2  Ex. if convertBaseTo = 16, then new value will be 4
                convertBaseTo = (int)Math.Log(convertBaseTo, NUMBASE_BIN);

                input = inputAdjuster(input, convertBaseTo);

                Hashtable binTohexOctHash = loadHashForBinTohexOct();


                int numberOfChars; //how many hexOct chars can be pulled from string

                //if greater than 4 then it means that it's not going to be in the hash
                //and the string has to be broken up it pieces that will go into the hash table
                if (input.Length >= convertBaseTo)
                    numberOfChars = (int)input.Length / convertBaseTo;
                else if (input.Length == 0)
                {
                    numberOfChars = 0;
                }
                else
                {//else //it was not greater than 4 so it's only 1 char.
                    numberOfChars = 1;

                }//else

                string binAsFourChars;

                string[] hexOctArray = new string[numberOfChars];

                for (int i = 0; i < numberOfChars; i++)
                {//for
                    //break into substrings
                    binAsFourChars = input.Substring(convertBaseTo * i, convertBaseTo);
                    hexOctArray[i] = (string)binTohexOctHash[inputAdjuster(binAsFourChars, 4)];
                }//for

                return string.Concat(hexOctArray);
            }
            else
                throw new ArgumentException("Needs to be a power of 2");
        }//binTohexOct


        private static string inputAdjuster(string input2, int numOfAmountNeededZeros)
        {
            //numOfAmountNeededZeros will normally be a power of 2

            if (input2.Length % numOfAmountNeededZeros != 0)
            {
                //if less than 4, add 0's to front so that it fits into one of the hash table keys
                string fillerZeros = new string('0', numOfAmountNeededZeros - (input2.Length % numOfAmountNeededZeros));
                input2 = string.Concat(fillerZeros, input2);
            }

            return input2;
        }
        #endregion

        #region "float"
        public static string decToBinFloat(double input, int maxLengthOfSignificand, int exponentLength)
        {//decToBinFloat
            string result;

            string integerPart;
            string fractionPart;
            string significand;
            int exponent = 0;
            string exponentAsStr;
            string signBit = "0";

            //for a 64 bit number, excessSize should be 1023
            //for a 32 bit number, excessSize should be 127
            int excessSize = (int)Math.Pow(2, exponentLength - necessaryExponentAdjustment) - necessaryExcessAdjustment;

            if (input == 0)
            {//if
                //create a string full of 0's
                result = new string(fillStringWithThisChar_Zero, extraBitForSign + maxLengthOfSignificand + exponentLength);
            }//if
            else
            {//else

                //if input is negative
                if (input < 0)
                {//if
                    //since floating numbers are not represented in 2's compliment,
                    //make number positive
                    input = input * -1;
                    signBit = "1";
                }//if

                //get the binary representation of the fractional part of the number
                //Ex. the .14 from 3.14
                fractionPart = fromDecFractionConversion(input,NUMBASE_BIN);

                #region "greater than 1 region"
                if (input > 1) // example: 15, 3.14
                {//if

                    //convert integer part to bin
                    integerPart = fromDecIntConversionPos((int)input, noFixedSizeForIntegerPart,NUMBASE_BIN);
                    exponent = integerPart.Length -necessaryExponentAdjustment; //has to do with how many places to move the binary point
                    integerPart = integerPart.Substring(firstCharLocation); //removes implied first 1
                    //convert integer part to bin and get what the exponent will be

                    if (exponent > excessSize)  //falls into overflow region
                    {//if
                        exponentAsStr = new string(fillStringWithThisChar_One, exponentLength);
                        significand = new string(fillStringWithThisChar_Zero, maxLengthOfSignificand);
                        result = string.Concat(signBit, exponentAsStr, significand);
                    }//if
                    #region "normal range"
                    else //falls into normal region
                    {//else
                        //get significand for normal range
                        significand = string.Concat(integerPart, fractionPart);

                        //get binary of exponent plus excess
                        exponentAsStr = fromDecIntConversionPos(exponent + excessSize, exponentLength,NUMBASE_BIN);

                        significand = transformSignificand(significand, maxLengthOfSignificand);

                        result = string.Concat(signBit, exponentAsStr, significand);

                    }//else
                    #endregion

                }//if
                #endregion
                #region "less than 1 region"
                else //example: .001, .25
                {//else
                    //get exponent 

                    //find first occurance of 1
                    //exponent is how many times binary point had to be moved
                    //the +1 is because the indexOf(1) only gets the location 
                    //of 1 but we actually need the location behind one
                    //the result is made negative because the exponent
                    //of a number less than 1 is always negative
                    //and this is the region numbers less than 1
                    exponent = -(fractionPart.IndexOf(seachForThisChar_One) + necessaryExponentAdjustment);

                    //if the exponent is negative even after
                    //adding the excess.
                    if (exponent + excessSize <= 0) //falls into underflow region
                    {//if
                        exponentAsStr = new string(fillStringWithThisChar_Zero, exponentLength);
                        significand = fractionPart.Substring(excessSize);
                        significand = transformSignificand(significand, maxLengthOfSignificand);
                    }//if
                    #region "normal region" 
                    else //reminder: this region is for numbers less than 1
                    {//else
                        //find first occurance of 1
                        //the +1 is because the indexOf(1) only gets the location 
                        //of 1 but we actually need the location behind the first 1
                        significand = fractionPart.Substring(fractionPart.IndexOf(seachForThisChar_One) + 1);

                        //get binary of exponent plus excess
                        exponentAsStr = fromDecIntConversionPos(exponent + excessSize, exponentLength,NUMBASE_BIN);
                        significand = transformSignificand(significand, maxLengthOfSignificand);

                    #endregion
                    }//else
                    result = string.Concat(signBit, exponentAsStr, significand);
                }//else

                #endregion

            }//else

            return result;
        }//decToBinFloat

        public static string binToDecFloat(string input, int exponentSize, int significandSize)
        {//binToDecFloat
             string toBeReturned = "";

            //check for unwanted characters in input
            if (!checkInputNonFraction(input, NUMBASE_BIN))
                throw new ArgumentException();

            //input size needs to match these values so that it will convert right
            if (input.Length != (significandSize + exponentSize + extraBitForSign)&&input.Length != 0)   
                throw new OutsideValueException("Input incorrect for that word size");
               
            

                try
                {
                    //for a 64 bit number, excessSize should be 1023
                    //for a 32 bit number, excessSize should be 127
                    int excessSize = (int)Math.Pow(2, exponentSize - necessaryExponentAdjustment) - necessaryExcessAdjustment;

                    double fractionPart = 0;
                    double integerPart = 0;
                    double result = 0;

                    string exponent;
                    string significand;
                    string integerPartAsStr;
                    string fractionPartAsStr;


                    //break up binary string into exponent, and significand
                    exponent = input.Substring(firstCharLocation, exponentSize);
                    significand = input.Substring(exponentSize + extraBitForSign);

                    //convert exponent back decimal then remove the excess
                    int exponentAsDec = (int)toDecIntConversionPos(exponent, NUMBASE_BIN) - excessSize;

                    //special conditions for infinity 
                    if (exponentAsDec > excessSize)
                    {//if
                        if (input[0] == negativeSignBit)
                            return "Negative Infinity";
                        else
                            return "Positive Infinity";

                    }//if
                    else if (exponentAsDec < -excessSize) //special condition defined for 0
                    {//else if
                        return "0";
                    }//else if
                    else
                    {//else
                        if (exponentAsDec < 0 && exponentAsDec > -excessSize) 
                        {//if
                            //case for numbers less than 1 that did not fall into the underlow region

                            //move binary point back to proper place, then get the fraction in decimal form
                            significand = string.Concat(
                                new string(fillStringWithThisChar_Zero, (int)Math.Abs(exponentAsDec) - necessaryExponentAdjustment),
                                impliedOneInFront, significand);
                            fractionPart = toDecFractionConversion(significand, NUMBASE_BIN);
                        }//if
                        else if (exponentAsDec == -excessSize)
                        {//else if
                            //case for underflow region

                            //move binary point back to proper place, then get the fraction in decimal form
                            significand = string.Concat(new string(fillStringWithThisChar_Zero, (int)Math.Abs(exponentAsDec)),
                                significand);
                            fractionPart = toDecFractionConversion(significand, NUMBASE_BIN);
                        }//else if
                        else if (exponentAsDec > 0 && exponentAsDec <= excessSize)
                        {//else if
                            //case for numbers within the normal range

                            
                            fractionPartAsStr = significand.Substring(exponentAsDec);
                            integerPartAsStr = significand.Substring(0, exponentAsDec);
                            integerPartAsStr = string.Concat(impliedOneInFront, integerPartAsStr);

                            integerPart = toDecIntConversionPos(integerPartAsStr, NUMBASE_BIN);
                            fractionPart = toDecFractionConversion(fractionPartAsStr, NUMBASE_BIN);

                        }//else if
                    }//else

                    result = integerPart + fractionPart;

                    //checks sign bit to determine whether to make negative
                    if (input[0] == negativeSignBit)
                        toBeReturned = string.Concat("-", string.Format("{0}", result));
                    else
                        toBeReturned = string.Concat(string.Format("{0}", result));

                }
                catch (ArgumentOutOfRangeException e)
                {
                    printErrorReport(e);
                }

                return toBeReturned;

           

        }//binToDecFloat

        //checks significand to see if it is the right length.
        //if too long, truncates the end values
        //if too short, add 0's
        //usually needs to be 23 bits or 58 bits, 23 bit significan for 32 bit numbers
        //and 58 bit significand for 64 bit nymbers
        private static string transformSignificand(string significand, int maxLengthOfSignificand)
        {//transformSignificand
            if (significand.Length > maxLengthOfSignificand)
                significand = significand.Remove(maxLengthOfSignificand);
            else if (significand.Length < maxLengthOfSignificand)
            {//else if
                string fillerZeros = new string(fillStringWithThisChar_Zero, maxLengthOfSignificand - significand.Length);
                significand = string.Concat(significand, fillerZeros);
            }//else if

            return significand;
        }//transformSignificand
        #endregion

        #region "Negative numbers in base 2 and powers of 2"

        //this method is only called for converting from negavtive
        //binary integers.
        private static long binToDecNegative(string input)
        {//binToDecNegative
            long result = toDecIntConversionPos(input,NUMBASE_BIN);
            //negative bin = positive bin - 2^n
            //where n is the number of bits 
            result = result - (long)Math.Pow(2, input.Length);

            return result;
        }//binToDecNegative

        //this method is for negative integers only, not fractions or positive numbers
        public static string decToBinNeg(long input, int size)
        {//decToBinNeg
            const int mathmaticallyNecessaryCorrection = 1;

            if (input == -1) //special case for when input is -1
            {//if

                return new string(fillStringWithThisChar_One, size);
            }//if
            else
            {//else
                //make input positive
                //mathmaticallyNecessaryCorrection = -1
                long input2 = Math.Abs(input) - mathmaticallyNecessaryCorrection;

                //convert the positive number to binary
                //arguement size affects whether you'll get 0010 vs 00000010
                String inputAsPosBin = fromDecIntConversionPos(input2, size,NUMBASE_BIN);
                char[] inputAsPosBinAsArray = inputAsPosBin.ToCharArray();

                //switch each 1 and 0, so that it is now a negative binary integer
                for (int i = 0; i < inputAsPosBinAsArray.Length; i++)
                {//for
                    if (inputAsPosBinAsArray[i] == '0')
                    {//if
                        inputAsPosBinAsArray[i] = '1';
                    }//if
                    else
                    {//else
                        inputAsPosBinAsArray[i] = '0';
                    }//else
                }//for

                return String.Concat(inputAsPosBinAsArray);

            }//else

        }//decToBinNeg

        public static string signedDecToBinTester(long input, int size)
        {//signedTester
            //check if number is within the range of representable numbers 
            //for the given size
            //Ex. Given 8 bits, the range is -128 to 127
            if ((input >= -Math.Pow(2, size - necessaryExponentAdjustment) && 
                (input <= Math.Pow(2, size - necessaryExponentAdjustment) - necessaryRangeAdjustment)))
            {//if
                if (input >= 0) //if negative
                    return fromDecIntConversionPos(input, size,NUMBASE_BIN);
                else
                    return decToBinNeg(input, size);
            }//if
            else
                throw new OutsideValueException("Number to large for that word size");
                    //return "Number to large for that word size";
        }//signedTester

        //tests which method to use to convert the binary integer
        //into a decimal integer
        public static string signedBinToDecTester(string input,int size)
        {//signedBinToDecTester
            string valueToBeReturned = "";
            //check that binary string is not too long or too shot
           if (input.Length > size && input.Length != 0)
                throw new OutsideValueException();
            try
            {
                if (input[0] == positiveSignBit) //if sign-bit says number is positive
                    valueToBeReturned = string.Format("{0}",toDecIntConversionPos(input, NUMBASE_BIN));
                else //sign-bit says number is negative
                    valueToBeReturned = string.Format("{0}",binToDecNegative(input));
            }
            catch (Exception ex)
            {
                printErrorReport(ex);              
            }

            return valueToBeReturned;
        }

        #endregion

        #region "Convert between any number base"
        //in all of these methods, decimal works as a sort of common currency
        //convert the number into decimal, then from decimal, convert to
        //the target number base

        public static string toAnyBaseFraction(string input, int size, int convertToBase, int convertFromBase)
        {
            
            double temp = toDecFractionConversion(input, convertFromBase);

            return fromDecFractionConversion(temp,convertToBase);
        }

        public static string toAnyBaseInt(string input,int size, int convertToBase, int convertFromBase)
        {
            long temp = toDecIntConversionPos(input,convertFromBase);

            return fromDecIntConversionPos(temp,size, convertToBase);
        }

        public static string toAnyBaseIntAndFract(string input, int size, int convertToBase, int convertFromBase)
        {
            double temp = toDecIntAndFract(input, convertFromBase);

            return fromDecIntAndFrac(temp, size, convertToBase);
        }

        #endregion

        #region "To and from dec"

        //convert positive decimal integers to any other number base
        public static string fromDecIntConversionPos(long input, int size, int convertToBase)
        {
            /*note 1
             * this method does not work with negative numbers.*/

            /*Note 2
             *Using -1 as size basically removes size limits and the 0's in front.
            Ex. 8 would be represented as 1000 instead of 00001000 if the size was 8. */

            if (convertToBase >= 1) //there is no base one
            {
                if (input < Math.Pow(2, size) || (size == noFixedSizeForIntegerPart))
                {//if
                    string result = "";

                    //if no fixed number of bits or the number is being
                    //converted to something other than binary
                    if (size == noFixedSizeForIntegerPart||convertToBase != NUMBASE_BIN)
                    {
                        string alphabetAndNumbers = "0123456789abcdefghijklmnopqrstuvwxyz";
                        char[] alphabetAndNumbersArray = alphabetAndNumbers.ToCharArray();
                        Stack<char> resultAsStack = new Stack<char>();
                        while (input > 0)
                        {   
                            //algorithm to convert a decimal to any number base
                            char temp = alphabetAndNumbersArray[(input % convertToBase)];
                            resultAsStack.Push(temp);
                            input = (long)(input / convertToBase);
                        }

                        result = String.Concat(resultAsStack.ToArray());
                    }
                    else //if number is being converted to binary and if number of bits
                        //is important
                    {
                        string[] resultAsArray = new string[size];
                        for (int i = 0; i < size; i++)
                        {
                            string temp = (input % convertToBase).ToString();
                            resultAsArray[i] = temp;
                            input = (long)(input / convertToBase);
                        }
                  
                        //the binary string starts off backwards so it needs to be reverse
                        Array.Reverse(resultAsArray);

                        result = String.Concat(resultAsArray);
                    }

                    return result;
                }
                else
                    throw new OutsideValueException("Number to large for that word size");
                //return "Number to large for that word size";
            }
            else
                throw new ArgumentOutOfRangeException("needs to be between 1 and 10");
        }

        //convert from any number base to decimal
        public static long toDecIntConversionPos(string input, int ConvertFromBase)
        {
            //check for unwanted characters
            if (!checkInputNonFraction(input, ConvertFromBase))
                throw new ArgumentException();

            Hashtable alphabetAndNumbersHash = loadHashForDec();
            char[] inputAsArray = input.ToCharArray();
            //make input backwards so that converts in the correct order
            Array.Reverse(inputAsArray);
            long result = 0;

            //1 iteration for each digit being converted
            for (int i = 0; i < inputAsArray.Length; i++)
            {
                //get decimal value from hash table
                //Ex. B would be a key for 11
                long temp = long.Parse((string)alphabetAndNumbersHash[inputAsArray[i]]);

                result = result + (long)(temp * Math.Pow(ConvertFromBase,i));

            }

            return result;

        }

        //convert decimal fractions to any other number base
        public static string fromDecFractionConversion(double input,int convertToBase)
        {//decToBinFraction

            //maximum number of digits after the '.'
            int maxSize = 100;

            string alphabetAndNumbers = "0123456789abcdefghijklmnopqrstuvwxyz";
            char[] alphabetAndNumbersArray = alphabetAndNumbers.ToCharArray();
            Queue<char> resultAsQueue = new Queue<char>();

            

            string result = "";

            if ((int)input >= 1) //get rid of the integer part
            {//if
                input = input - (int)input;
            }//if

            //loop until series terminates or after the defined maximum amount of digits is reached
            //because of rounding errors, the loop will usually eventually end
            //even with non-terminating numbers
            while ((input > 0)&&(resultAsQueue.Count <maxSize)) 
            {//while

                //algorithm to convert decimal to any number base
                //index in alphabetAndNumbersArray corresponds to
                //actual value
                //get rid of integer part that is there as a result of
                //above multiplication
                input = input * convertToBase;
                char temp = alphabetAndNumbersArray[(int)input];
                resultAsQueue.Enqueue(temp);
                input = input - (int)input;
                    
            }//while
            result = String.Concat(resultAsQueue.ToArray());
            return result;
        }//decToBinFraction

        //convert fraction from any number base to decimal
        public static double toDecFractionConversion(string input, int convertFromBase)
        {//binToDecFraction
            Hashtable alphabetAndNumbersHash = loadHashForDec();
            char[] inputAsArray = input.ToCharArray();

            double result = 0;
            for (int i = 0; i < inputAsArray.Length; i++)
            {//for
                //use digit as key in associative array to get the decimal value
                //then add the values of the digits together
                int numerator = int.Parse((string)alphabetAndNumbersHash[inputAsArray[i]]);
                result = result + (numerator*Math.Pow(convertFromBase, -(i+1)));

            }//for
            return result;
        }//binToDecFraction
        
        //this method is used for converting numbers that have an integer part
        //and a fractional part. Converts from decimal to any other base
        public static string fromDecIntAndFrac(double input, int fractSize, int convertToBase)
        {
            //casts input as a long integer which automatically removes the fractional part.
            string intPart = fromDecIntConversionPos((long)input, DATATYPE_FRACTION, convertToBase);

            string fractPart = fromDecFractionConversion(input, convertToBase);

            return String.Concat(intPart, ".", fractPart);
        }

        //this method is used for numbers that have an integer part
        //and a fractional part. Converts from any other number base into decimal
        public static double toDecIntAndFract(string input, int convertFromBase)
        {
            //find location of '.'
            int pointLocation = input.IndexOf('.');

            //splits the string into the integer part
            //and the fractional part.
            //Then it calls the methods to convert 
            //the each part into decimal
            string temp = input.Substring(0, pointLocation);
            long intPart = toDecIntConversionPos(temp, convertFromBase);

            temp = input.Substring(pointLocation+1);
            double fractPart = toDecFractionConversion(temp, convertFromBase);

            return intPart + fractPart;
        }

        #endregion

        #region "hashtables"

        //out of the way location to load associative arrays
        //which help for easy conversion

        private static Hashtable loadHashForhexOctToBin()
        {
            Hashtable hashToLoad = new Hashtable();

            hashToLoad.Add('0', "0000");
            hashToLoad.Add('1', "0001");
            hashToLoad.Add('2', "0010");
            hashToLoad.Add('3', "0011");
            hashToLoad.Add('4', "0100");
            hashToLoad.Add('5', "0101");
            hashToLoad.Add('6', "0110");
            hashToLoad.Add('7', "0111");
            hashToLoad.Add('8', "1000");
            hashToLoad.Add('9', "1001");
            hashToLoad.Add('A', "1010");
            hashToLoad.Add('B', "1011");
            hashToLoad.Add('C', "1100");
            hashToLoad.Add('D', "1101");
            hashToLoad.Add('E', "1110");
            hashToLoad.Add('F', "1111");

            return hashToLoad;
        }

        private static Hashtable loadHashForBinTohexOct()
        {
            Hashtable hashToLoad = new Hashtable();

            hashToLoad.Add("0000", "0");
            hashToLoad.Add("0001", "1");
            hashToLoad.Add("0010", "2");
            hashToLoad.Add("0011", "3");
            hashToLoad.Add("0100", "4");
            hashToLoad.Add("0101", "5");
            hashToLoad.Add("0110", "6");
            hashToLoad.Add("0111", "7");
            hashToLoad.Add("1000", "8");
            hashToLoad.Add("1001", "9");
            hashToLoad.Add("1010", "A");
            hashToLoad.Add("1011", "B");
            hashToLoad.Add("1100", "C");
            hashToLoad.Add("1101", "D");
            hashToLoad.Add("1110", "E");
            hashToLoad.Add("1111", "F");

            return hashToLoad;
        }

        private static Hashtable loadHashForDec()
        {

            Hashtable hashToLoad;
            hashToLoad = new Hashtable();
            hashToLoad.Add('0', "0");
            hashToLoad.Add('1', "1");
            hashToLoad.Add('2', "2");
            hashToLoad.Add('3', "3");
            hashToLoad.Add('4', "4");
            hashToLoad.Add('5', "5");
            hashToLoad.Add('6', "6");
            hashToLoad.Add('7', "7");
            hashToLoad.Add('8', "8");
            hashToLoad.Add('9', "9");
            hashToLoad.Add('A', "10");
            hashToLoad.Add('B', "11");
            hashToLoad.Add('C', "12");
            hashToLoad.Add('D', "13");
            hashToLoad.Add('E', "14");
            hashToLoad.Add('F', "15");
            hashToLoad.Add('G', "16");
            hashToLoad.Add('H', "17");
            hashToLoad.Add('I', "18");
            hashToLoad.Add('J', "19");
            hashToLoad.Add('K', "20");
            hashToLoad.Add('L', "21");
            hashToLoad.Add('M', "22");
            hashToLoad.Add('N', "23");
            hashToLoad.Add('O', "24");
            hashToLoad.Add('P', "25");
            hashToLoad.Add('Q', "26");
            hashToLoad.Add('R', "27");
            hashToLoad.Add('S', "28");
            hashToLoad.Add('T', "29");
            hashToLoad.Add('U', "30");
            hashToLoad.Add('V', "31");
            hashToLoad.Add('W', "32");
            hashToLoad.Add('X', "33");
            hashToLoad.Add('Y', "34");
            hashToLoad.Add('Z', "35");
            hashToLoad.Add('a', "10");
            hashToLoad.Add('b', "11");
            hashToLoad.Add('c', "12");
            hashToLoad.Add('d', "13");
            hashToLoad.Add('e', "14");
            hashToLoad.Add('f', "15");
            hashToLoad.Add('g', "16");
            hashToLoad.Add('h', "17");
            hashToLoad.Add('i', "18");
            hashToLoad.Add('j', "19");
            hashToLoad.Add('k', "20");
            hashToLoad.Add('l', "21");
            hashToLoad.Add('m', "22");
            hashToLoad.Add('n', "23");
            hashToLoad.Add('o', "24");
            hashToLoad.Add('p', "25");
            hashToLoad.Add('q', "26");
            hashToLoad.Add('r', "27");
            hashToLoad.Add('s', "28");
            hashToLoad.Add('t', "29");
            hashToLoad.Add('u', "30");
            hashToLoad.Add('v', "31");
            hashToLoad.Add('w', "32");
            hashToLoad.Add('x', "33");
            hashToLoad.Add('y', "34");
            hashToLoad.Add('z', "35");

            return hashToLoad;
        }

        #endregion

        //check for unwarnted, exception producing characters
        private static bool checkInputNonFraction(string inputToBeChecked,int numBaseConvertedFromToCheck)
        {
             Hashtable setOfCharsToTestAgainst_Hash = new Hashtable();

            //the number base will act as a key, while a string of the other characters will be the the values
            //in an associative array
            setOfCharsToTestAgainst_Hash.Add(NUMBASE_BIN,
                "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"23456789");
            setOfCharsToTestAgainst_Hash.Add(NUMBASE_HEX,
                "GHIJKLMNOPQRSTUVWXYZghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"");
            setOfCharsToTestAgainst_Hash.Add(NUMBASE_OCT,
                "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"89");

            
            //use numBaseConvertedFromToCheck to tell the program which character set 
            //to grab from the associative array, which will tell the program which character set
            //to test against
            string strToTestAgainst = (string)setOfCharsToTestAgainst_Hash[numBaseConvertedFromToCheck];
            const int notFound = -1;

            for (int i = 0; i < inputToBeChecked.Length; i++)
            {
                
                if (strToTestAgainst.IndexOf(inputToBeChecked[i]) != notFound)
                {
                    return false;
                }
            }
            return true;
        }

        //this prints the errors from exceptions into a .txt file
        private static void printErrorReport(Exception generatedException)
        {
            string exeFolder = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);

            exeFolder = string.Concat(exeFolder, "\\ProgramerCalcErrorReports");
            if (!Directory.Exists(exeFolder))
                Directory.CreateDirectory(exeFolder);
            exeFolder = string.Concat(exeFolder, "\\out.txt");

            StreamWriter myOut;

            myOut = new StreamWriter(exeFolder, true);
            myOut.WriteLine("[{0}]{1}", DateTime.Now, generatedException);
            myOut.Flush();
            myOut.Close();
        }

    }//class

    
 }//namespace
