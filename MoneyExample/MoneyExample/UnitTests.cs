using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyExample
{
    [TestClass]
    class UnitTests
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            
        }
    }
}
