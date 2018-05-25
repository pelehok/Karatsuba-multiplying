using Microsoft.VisualStudio.TestTools.UnitTesting;
using Karatsuba_multiplying;
using System.Collections.Generic;

namespace MultipleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            BigValue value = new BigValue(45878588);
            // act
            List<BigValue> list = value.DoubleSplit();
            
            //assert
            Assert.AreEqual(list[0].ToString(),new BigValue(new BigInteger(4587)).ToString());
            Assert.AreEqual(list[1].ToString(),new BigValue(new BigInteger(8588)).ToString());
        }
    }
}
