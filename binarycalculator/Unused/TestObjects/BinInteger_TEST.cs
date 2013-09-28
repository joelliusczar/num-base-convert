//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using binary_calculator.Wrappers.Integers;
//using binary_calculator.EnumsAndConstants;

//namespace TestBinCalc.TestObjects
//{
//    class BinInteger_TEST: BinInteger
//    {
//        public BinInteger_TEST(int size, string input)
//            : base(size, input)
//        {
//            Console.Write("BinInteger instantiation!\n" +
//                "size: {0}\n" +
//                "input: {1}\n" +
//                "input length: {4}\n"+
//                "allowedNumberOfBits:{2}\n" +
//                "storedInput:{3}\n"+
//                "storedInput length: {5}\n\n\n",
//                size, input, this.allowedNumberOfBits, this.storedInput,input.Length,this.storedInput.Length);
//        }

//        public void AddChar_TEST(char value)
//        {
//            string potentialResult = string.Concat(this.storedInput, value.ToString());
//            string oldStoredInput = this.storedInput;
//            this.AddChar(value);
//            Console.Write("AddChar _TEST!\n" +
//                "char to add: {0}\n" +
//                "Potential Result: {1}\n" +
//                "Potential Result Length: {2}\n"+
//                "AllowedNumberOfBits: {3}\n"+
//                "Old storedInput: {6}\n"+
//                "Old storedInput length: {7}\n"+
//                "Result: {4}\n"+
//                "Result Length: {5}\n\n\n",
//                value,potentialResult,potentialResult.Length,this.allowedNumberOfBits,
//                this.storedInput,this.storedInput.Length,oldStoredInput,oldStoredInput.Length);
//        }

//        public void DeleteChar_TEST()
//        {
//            string oldStoredInput = this.storedInput;
//            this.deleteChar();
//            Console.Write("DeleteChar _TEST!\n" +
//                "AllowedNumberOfBits: {0}\n" +
//                "Old storedInput: {3}\n" +
//                "Old storedInput length: {4}\n" +
//                "Result: {1}\n" +
//                "Result Length: {2}\n\n\n",
//                 this.allowedNumberOfBits,
//                this.storedInput, this.storedInput.Length, oldStoredInput, oldStoredInput.Length);
//        }

//        public void AreAllCharsOfInputLegal_TEST(string input)
//        {
//            bool result = this.AreAllCharsOfInputLegal(input, NumberBases.BASE_TWO);
//            Console.Write("AreAllCharsOfInputLegal_TEST!\n" +
//                "input:{0}\n"+
//                "Is input legal?: {1}\n\n\n");
//        }

//        public void ClearInput_TEST()
//        {
//            string oldStoredInput = this.storedInput;
//            ClearInput();
//            Console.Write("ClearInput_TEST!\n"+
//                "old storedInput: {0}\n"+
//                "Result: {1}\n\n\n",
//                oldStoredInput,this.storedInput);
//        }

//        public void ReplaceProperties_TEST(string input, int size)
//        {
//            Console.Write("ReplaceProperties_TEST start!\n\n");
//            ReplaceStoredInput_TEST(input);
//            ReplaceAllowedNumberOfBits_TEST(size);
//            Console.Write("ReplaceProperties_TEST end!\n\n\n");
//        }

//        public void ReplaceStoredInput_TEST(string value)
//        {
//            string oldStoredInput = this.storedInput;
//            this.storedInput = value;
//            Console.Write("ReplaceStoredInput_TEST!\n" +
//                "input to be: {0}\n" +
//                "input length: {6}\n"+
//                "AllowedNumberOfBits: {1}\n" +
//                "Old storedInput: {2}\n" +
//                "Old storedInput length: {3}\n" +
//                "Result: {4}\n" +
//                "Result Length: {5}\n\n\n",
//                value, this.allowedNumberOfBits,
//                oldStoredInput, oldStoredInput.Length, this.storedInput, this.storedInput.Length,value.Length );

//        }

//        public void ReplaceAllowedNumberOfBits_TEST(int value)
//        {
//            string oldStoredInput = this.storedInput;
//            int oldSize = this.allowedNumberOfBits;

//            this.allowedNumberOfBits = value;
//            Console.Write("ReplaceAllowedNumberOfBits_TEST\n"+
//                "old storedInput: {0}\n"+
//                "old storedInput length: {1}\n"+
//                "old bit size: {2}\n"+
//                "Size to be: {3}\n"+
//                "current storedInput: {4}\n"+
//                "current storedInput length: {5}\n"+
//                "new size: {6}\n\n\n",
//            oldStoredInput,oldStoredInput.Length,oldSize,value,this.storedInput,this.storedInput.Length,
//            this.allowedNumberOfBits);
//        }
//    }

    
//}
