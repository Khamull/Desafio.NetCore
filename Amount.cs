using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio
{
    public class Amount
    {
        private double InitialValue;
        private int Time;
        private double IR;

        public double _IR
        {
            get { return IR; }
            set { IR = value; }
        }

        public int _Time
        {
            get { return Time; }
            set { Time = value; }
        }


        public double _InitialValue
        {
            get { return InitialValue; }
            set { InitialValue = value; }
        }

        private double FinalValue()
        {
            var tax = (double)Math.Pow((double)(1 + IR), (double)_Time);
            var finalValue = _InitialValue * tax;
            finalValue = Math.Round(finalValue, 2);
            return finalValue;
        }

        public double GetFinalValue()
        {
            return FinalValue();
        }
        protected virtual void Dispose(bool disposing)
        {
        }
    }
}
