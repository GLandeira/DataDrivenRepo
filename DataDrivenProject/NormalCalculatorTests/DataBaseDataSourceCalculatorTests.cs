using DataDrivenProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System;

namespace NormalCalculatorTests
{
    internal class DataBaseDataSourceCalculatorTests
    {
        private DataDrivenCalculator _calculator = new DataDrivenCalculator();
        private TestContext _context;
        public TestContext Context  { get => _context; set => _context = value;}

        
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"TestData\CalculatorData.csv", "Data#csv",
        DataAccessMethod.Sequential)]
        public void AddNumbersUsingDataSource()
        {
            int ExpectedResult = Convert.ToInt32(Context.DataRow["Expected"]);
            int FirstNumber = Convert.ToInt32(Context.DataRow["X"]);
            int SecondNumber = Convert.ToInt32(Context.DataRow["Y"]);

            Assert.AreEqual(ExpectedResult, _calculator.Add(FirstNumber, SecondNumber));
        }
    }
}



