using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio
{
    public class InterestRate
    {
        private static double IRate => 0.01;

        public static double _Irate
        {
            get { return IRate; }
        }

        static public double GetIRate() => _Irate;
    }
}
