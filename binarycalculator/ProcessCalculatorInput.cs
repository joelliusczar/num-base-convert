using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace binary_calculator
{
    class ProcessCalculatorInput
    {
        //this class works as a mediator between the gui and the actual calculations done in 
        //the BinCalc class
        //this class helps to filter out unwanted input


        public const int NUMBASE_BIN = 2;
        public const int NUMBASE_OCT = 8;
        public const int NUMBASE_DEC = 10;
        public const int NUMBASE_HEX = 16;

        public const int DATATYPE_UNSIGNED = 0;
        public const int DATATYPE_SIGNED = 1;
        public const int DATATYPE_FRACTION = -1;
        public const int DATATYPE_FLOAT = 3;


        #region "strings to test against"
        private const string decUnsignedInputTestAgainst = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"";
        private const string decSignedInputTestAgainst = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz.`!@#$%^&*()<>?:{},/;'[]\\|\"";
        private const string decFractionInputTestAgainst = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-`!@#$%^&*()<>?:{},/;'[]\\|\"";
        private const string decFloatInputTestAgainst = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz`!@#$%^&*()<>?:{},/;'[]\\|\"";

        private const string binInputTestAgainst = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"23456789";
        private const string binFractInputTestAgainst = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-`!@#$%^&*()<>?:{},/;'[]\\|\"23456789";

        private const string hexInputTestAgainst = "GHIJKLMNOPQRSTUVWXYZghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"";
        private const string hexFractInputTestAgainst = "GHIJKLMNOPQRSTUVWXYZghijklmnopqrstuvwxyz-`!@#$%^&*()<>?:{},/;'[]\\|\"";

        private const string octInputTestAgainst = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-.`!@#$%^&*()<>?:{},/;'[]\\|\"89";
        private const string octFractInputTestAgainst = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-`!@#$%^&*()<>?:{},/;'[]\\|\"89";
        #endregion

        public static string processInputToBeConverted(string input, int dataType, int convertFromBase,
            int convertToBase,int size,int exponentSize)
        {
                //based on the options set in the gui, this method determines which calculations will be used
            string display = "";

            double numberToBeConverted = 0;

            try
            {
                //converts string to number ahead of time if needed
                if (convertFromBase == BinCalc.NUMBASE_DEC)
                    numberToBeConverted = double.Parse(input);

                //outline of IF statements:
                // I.  Unsigned Numbers
                //     a.Converting from decimal
                //     b.Converting from anything else
                // II. Signed Numbers
                //     a.Converting from decimal
                //     b.Converting from binary
                //          1.Converting to Octal or Hexidecimal
                //          2.Converting to Decimal
                //     c.Converting from Octal
                //          1.Converting to Hexidecimal
                //          2.Converting to Decimal
                //     d.Converting from hexidecimal
                //          1.Converting to Octal
                //          2.Converting to Decimal
                // III.Floating Numbers (Non-IEEE 754
                //     a.Converting from decimal
                //     b.Converting from anything else
                // IV. Floating Numbers (IEEE 754)
                //     a.Converting from decimal
                //     b.Converting from binary
                //          1.Converting to Octal or Hexidecimal
                //          2.Converting to Decimal
                //     c.Converting from Octal
                //          1.Converting to Hexidecimal
                //          2.Converting to Decimal
                //     d.Converting from hexidecimal
                //          1.Converting to Octal
                //          2.Converting to Decimal
                //sometimes the binary operation is done automatically
                //as a part of converting to and from othe number bases
                #region "determine which operation to use                
                #region "Unsigned Numbers"
                if (dataType == DATATYPE_UNSIGNED)
                {
                    if (convertFromBase == BinCalc.NUMBASE_DEC)
                    {
                        display = BinCalc.fromDecIntConversionPos((long)numberToBeConverted, size, convertToBase);
                    }
                    else
                    {
                        display = BinCalc.toAnyBaseInt(input, size, convertToBase, convertFromBase);
                    }
                }
                #endregion
                #region "Signed Numbers"
                else if (dataType == DATATYPE_SIGNED)
                {
                    if (convertFromBase == BinCalc.NUMBASE_DEC)
                    {

                        display = BinCalc.signedDecToBinTester((long)numberToBeConverted, size);

                        if (convertToBase == BinCalc.NUMBASE_HEX || convertToBase == BinCalc.NUMBASE_OCT)
                        {
                            display = BinCalc.binToHexOct(display, convertToBase, size);
                        }

                    }
                    else if (convertFromBase == BinCalc.NUMBASE_BIN)
                    {
                        if (convertToBase == BinCalc.NUMBASE_OCT || convertToBase == BinCalc.NUMBASE_HEX)
                        {
                            display = BinCalc.binToHexOct(input, convertToBase, size);
                        }
                        else if (convertToBase == BinCalc.NUMBASE_DEC)
                        {
                            display = string.Format("{0}", BinCalc.signedBinToDecTester(input, size));
                        }
                    }
                    else if (convertFromBase == BinCalc.NUMBASE_OCT)
                    {
                        display = BinCalc.hexOctToBin(input, convertFromBase, size);

                        if (convertToBase == BinCalc.NUMBASE_HEX)
                        {
                            display = BinCalc.binToHexOct(display, convertToBase, size);
                        }
                        else if (convertToBase == BinCalc.NUMBASE_DEC)
                        {
                            display = string.Format("{0}", BinCalc.signedBinToDecTester(display, size));
                        }
                    }
                    else if (convertFromBase == BinCalc.NUMBASE_HEX)
                    {
                        display = BinCalc.hexOctToBin(input, convertFromBase, size);

                        if (convertToBase == BinCalc.NUMBASE_OCT)
                        {
                            display = BinCalc.binToHexOct(display, convertToBase, size);
                        }
                        else if (convertToBase == BinCalc.NUMBASE_DEC)
                        {
                            display = string.Format("{0}", BinCalc.signedBinToDecTester(display, size));
                        }
                    }
                    else
                    { }
                }
                #endregion
                #region "Floating Numbers (Non-IEEE 754)"
                else if (dataType == DATATYPE_FRACTION)
                {
                    if (convertFromBase == BinCalc.NUMBASE_DEC)
                    {
                        display = BinCalc.fromDecIntAndFrac(numberToBeConverted, size, convertToBase);
                    }
                    else
                    {
                        display = BinCalc.toAnyBaseIntAndFract(input, size, convertToBase, convertFromBase);
                    }
                }
                #endregion
                #region "Floating Numbers"
                else if (dataType == DATATYPE_FLOAT)
                {
                    if (convertFromBase == BinCalc.NUMBASE_DEC)
                    {
                        display = BinCalc.decToBinFloat(numberToBeConverted, size, exponentSize);

                        if (convertToBase == BinCalc.NUMBASE_HEX || convertToBase == BinCalc.NUMBASE_OCT)
                        {
                            display = BinCalc.binToHexOct(display, convertToBase, exponentSize, size);
                        }
                    }
                    else if (convertFromBase == BinCalc.NUMBASE_BIN)
                    {
                        if (convertToBase == BinCalc.NUMBASE_OCT || convertToBase == BinCalc.NUMBASE_HEX)
                        {
                            display = BinCalc.binToHexOct(input, convertToBase, exponentSize, size);
                        }
                        else if (convertToBase == BinCalc.NUMBASE_DEC)
                        {
                            display = string.Format("{0}", BinCalc.binToDecFloat(input, exponentSize, size));

                        }
                    }
                    else if (convertFromBase == BinCalc.NUMBASE_OCT)
                    {
                        display = BinCalc.hexOctToBin(input, convertFromBase, exponentSize, size);

                        if (convertToBase == BinCalc.NUMBASE_HEX)
                        {
                            display = BinCalc.binToHexOct(display, convertToBase, exponentSize, size);
                        }
                        else if (convertToBase == BinCalc.NUMBASE_DEC)
                        {

                            display = string.Format("{0}", BinCalc.binToDecFloat(display, exponentSize, size));

                        }
                    }
                    else if (convertFromBase == BinCalc.NUMBASE_HEX)
                    {
                        display = BinCalc.hexOctToBin(input, convertFromBase, exponentSize, size);

                        if (convertToBase == BinCalc.NUMBASE_OCT)
                        {
                            display = BinCalc.binToHexOct(display, convertToBase, exponentSize, size);

                        }
                        else if (convertToBase == BinCalc.NUMBASE_DEC)
                        {

                            display = string.Format("{0}", BinCalc.binToDecFloat(display, exponentSize, size));

                        }
                    }
                    else
                    { }
                }
                #endregion
                #endregion
            }
            #region "Exception Catchers"
            catch (FormatException ex)
            {
                printErrorReport(ex);
            }
            catch (OutsideValueException ex)
            {
                printErrorReport(ex);

                display = "Input incorrect for that word size";

            }
            catch (ArgumentException argEx)
            {
                display = "";
                printErrorReport(argEx);
            }
            #endregion

            return display;
            
        }

        public static string checkUserInput(System.Windows.Forms.KeyPressEventArgs e, int dataType, int numBase,string display)
        {//checkUserInput
            //checks each keyboard key that user presses and determines what to do with it

            const int notFound = -1;
            int result = 0;

            if (e.KeyChar.GetHashCode() != 524296) //prevent delete key from sending output
            {//if
                //determines which character set to test input against
                //Ex. if using the character set for decimal numbers
                //pressing 'A' will not register but it will if the
                //character set is for hexidecimal
                if( (numBase == NUMBASE_DEC ) && (dataType == DATATYPE_UNSIGNED) )
                    result = decUnsignedInputTestAgainst.IndexOf(e.KeyChar);

                else if ((numBase == NUMBASE_DEC) && (dataType == DATATYPE_SIGNED ))
                    result = decSignedInputTestAgainst.IndexOf(e.KeyChar);

                else if ((numBase == NUMBASE_DEC) && (dataType == DATATYPE_FRACTION))
                    result = decFractionInputTestAgainst.IndexOf(e.KeyChar);

                else if ((numBase == NUMBASE_DEC) && ( (dataType == DATATYPE_FLOAT)))
                    result = decFloatInputTestAgainst.IndexOf(e.KeyChar);

                else if( (numBase == NUMBASE_BIN) && (dataType != DATATYPE_FRACTION) )
                    result = binInputTestAgainst.IndexOf(e.KeyChar);

                else if ((numBase == NUMBASE_BIN) && (dataType == DATATYPE_FRACTION))
                    result = binFractInputTestAgainst.IndexOf(e.KeyChar);

                else if( (numBase == NUMBASE_HEX) && (dataType != DATATYPE_FRACTION) )
                    result = hexInputTestAgainst.IndexOf(e.KeyChar);

                else if ((numBase == NUMBASE_HEX) && (dataType == DATATYPE_FRACTION))
                    result = hexFractInputTestAgainst.IndexOf(e.KeyChar);

                else if ((numBase == NUMBASE_OCT) && (dataType == DATATYPE_FRACTION))
                    result = octFractInputTestAgainst.IndexOf(e.KeyChar);

                else if ((numBase == NUMBASE_OCT) && (dataType != DATATYPE_FRACTION))
                    result = octInputTestAgainst.IndexOf(e.KeyChar);

              //this section prevents users from using multiple '.' or '-'
             //and prevents users from using '-' in the wrong location
             if (result == -1)
             {//if
                 if (display.IndexOf('.') == notFound || e.KeyChar != '.' )
                 {
                     if (display.Length == 0 || e.KeyChar != '-')
                     {
                         display = string.Concat(display, e.KeyChar);
                     }
                 }
   
                }//if
            }//if
            else if (e.KeyChar.GetHashCode() == 524296) //if the user presses backspace
            {//else
                //deletes characters
                try
                {
                    display = display.Remove(display.Length - 1);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    printErrorReport(ex);

                    
                }
                

            }//else

            return display;

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

        
    }

}
