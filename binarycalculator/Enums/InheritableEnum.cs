using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Enums
{
    public abstract class InheritableEnum
    {
        private int _toInt;

        public int toInt
        {
            get { return _toInt; }
            protected set { _toInt = value; }
        }

        

    }
}
