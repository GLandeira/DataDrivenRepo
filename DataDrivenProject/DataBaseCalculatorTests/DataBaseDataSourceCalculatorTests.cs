using DataDrivenProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataBaseCalculatorTests
{
    
    [TestClass]
    public class DataBaseDataSourceCalculatorTests
    {
        private DataDrivenCalculator _calculator = new DataDrivenCalculator();
        private TestContext _testContext;
        
        public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }
        
        
        [DataTestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"C:\Users\Admin\Desktop\DataDrivenRepo-main\DataDrivenProject\TestData\CalculatorData.csv", "CalculatorData#csv",
        DataAccessMethod.Sequential)]
        public void AddNumbersUsingDataSource()
        {
            int ExpectedResult = Convert.ToInt32(TestContext.DataRow[0]);
            int FirstNumber = Convert.ToInt32(TestContext.DataRow[1]);
            int SecondNumber = Convert.ToInt32(TestContext.DataRow[2]);

            Assert.AreEqual(ExpectedResult, _calculator.Add(FirstNumber, SecondNumber));
        }
    }
}



