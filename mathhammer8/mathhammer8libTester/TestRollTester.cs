using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MathHammer8.Tester
{
    [TestClass]
    public class TestRollTester
    {
        [TestMethod]
        public void NoModifierSomeSuccesses()
        {
            var tested = new TestedRoll(4, 0, new BasicRoll());
            Assert.AreEqual(3, tested.Results.Count(r => r.Result == RollResultDisposition.Pass));
        }

        [TestMethod]
        public void CountsAreEqual()
        {
            var rolls = new BasicRoll();
            var testedRolls = new TestedRoll(4, 0, rolls);
            Assert.AreEqual(rolls.Results.Count(), testedRolls.Results.Count());
        }
    }
}
