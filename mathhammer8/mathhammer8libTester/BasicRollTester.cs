using Microsoft.VisualStudio.TestTools.UnitTesting;
using mathhammer8lib;

namespace mathhammer8libTester
{
    [TestClass]
    public class BasicRollTester
    {
        [TestMethod]
        public void HasSixResults()
        {
            var roll = new BasicRoll();
            Assert.AreEqual(6, roll.Results.Count, "A basic roll should have 6 results");
        }
    }
}
