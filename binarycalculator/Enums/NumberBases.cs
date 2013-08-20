using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_calculator.Enums
{
    public abstract class NumberBases: InheritableEnum
    {
        public static readonly NumberBases BASE_TWO = new Two();
        public static readonly NumberBases BASE_EIGHT = new Eight();
        public static readonly NumberBases BASE_SIXTEEN = new Sixteen();

        private class Two : NumberBases
        {
            public Two()
            {
                toInt = 2;
            }
        }

        private class Eight : NumberBases
        {
            public Eight()
            {
                toInt = 8;
            }
        }

        private class Sixteen : NumberBases
        {
            public Sixteen()
            {
                toInt = 16;
            }
        }
    }
}
