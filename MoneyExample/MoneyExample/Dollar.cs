using System;

namespace MoneyExample
{
    internal class Dollar
    {
        internal double amount;
        private int v;

        public Dollar(int v)
        {
            this.v = v;
        }

        internal void times(int v)
        {
            throw new NotImplementedException();
        }
    }
}