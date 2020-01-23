using System;

namespace MoneyExample
{
    internal class Dollar
    {
        internal int  amount;
        private int multiplier;

        public Dollar(int amount)
        {
            this.amount = amount;
        }



        internal Dollar times(int multiplier)
        {
                   //   return new Dollar(amount * multiplier);
   
            return new Dollar(amount * multiplier);


        }
    }
}