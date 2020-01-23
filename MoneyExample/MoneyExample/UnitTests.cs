using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyExample
{
   
    class UnitTests
    {
        [Test]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.times(2);
            Assert.AreEqual(10,product.amount);
            Dollar product2 = five.times(3);
            Assert.AreEqual(15, product2.amount);
        }
    }
}
