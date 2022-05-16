using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataDrivenProject;

namespace NormalCalculatorTests
{
    [TestClass]
    public class NormalCalculatorTests
    {
        private DataDrivenCalculator _calculator = new DataDrivenCalculator();

        [TestMethod]
        public void AddTenAndTwentyGivesThirty()
        {
            Assert.AreEqual(_calculator.Add(10, 20), 30);
        }

        [TestMethod]
        public void AddTwoAndEightGivesTen()
        {
            Assert.AreEqual(_calculator.Add(2, 8), 10);
        }

        [TestMethod]
        public void AddthreeAndSevenGivesTen()
        {
            Assert.AreEqual(_calculator.Add(3, 7), 10);
        }
    }
}