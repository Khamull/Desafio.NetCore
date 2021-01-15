using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio
{
    public class Amount
    {
        private decimal InitialValue;
        private int Time;
        private decimal IR;

        public decimal _IR
        {
            get { return IR; }
            set { IR = value; }
        }

        public int _Time
        {
            get { return Time; }
            set { Time = value; }
        }


        public decimal _InitialValue
        {
            get { return InitialValue; }
            set { InitialValue = value; }
        }

        private decimal FinalValue()
        {
            var tax = (decimal)Math.Pow((double)(1 + IR), (double)_Time);
            var finalValue = _InitialValue * tax;
            return finalValue;
        }

        public decimal GetFinalValue()
        {
            return FinalValue();
        }
    }
}
