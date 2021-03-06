using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MathHammer8.Tester
{
    [TestClass]
    public class BasicRollTester
    {
        [TestMethod]
        public void HasSixResultsByDefault()
        {
            var roll = new BasicRoll();
            Assert.AreEqual(6, roll.Results.Count(), "A basic roll should have 6 results");
        }

        [TestMethod]
        public void CanSetToHaveThreeSides()
        {
            var roll = new BasicRoll(3);
            Assert.AreEqual(3, roll.Results.Count(), "Should have 3 sides when requested");
        }

        [TestMethod]
        public void CanSetToHaveSixSides()
        {
            var roll = new BasicRoll(6);
            Assert.AreEqual(6, roll.Results.Count(), "Should have 6 sides when requested. Equivilent to default constructor.");
        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(6)]
        public void AllResultsShouldBeUnique(int sides)
        {
            var roll = new BasicRoll(sides);
            Assert.AreEqual(sides, roll.Results.Distinct().Count());
        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(6)]
        public void AllResultsShouldBePositive(int sides)
        {
            var rolls = new BasicRoll(sides);
            foreach(var result in rolls.Results)
            {
                Assert.IsTrue(result.Value > 0);
            }
        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(6)]
        public void AllResultsShouldBeLessThanOrEqualToSideCount(int sides)
        {
            var rolls = new BasicRoll(sides);
            foreach(var result in rolls.Results)
            {
                Assert.IsTrue(result.Value <= sides);
            }
        }
    }
}
