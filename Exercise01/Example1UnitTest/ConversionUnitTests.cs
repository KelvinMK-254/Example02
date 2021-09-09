using Exercise01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Example1UnitTest
{
    [TestClass]
    public class ConversionUnitTests
    {
        [TestMethod]
        public void CheckIfResultIsString()
        {
            ulong myInput = 1234567890;
            Assert.AreEqual(true, Exercise1.Towards(myInput) is string);
        }

        [TestMethod]
        public void CheckIfResultIsNull()
        {
            ulong myInput = 1234567890;
            Assert.IsNotNull(Exercise1.Towards(myInput));
        }
    }
}
