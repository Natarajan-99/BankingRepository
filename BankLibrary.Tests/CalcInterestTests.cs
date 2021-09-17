using BankingLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankLibrary.Tests
{
    [TestClass]
    public class CalcInterestTests
    {
        [TestMethod]
        public void Calculate_AcceptsPNR_ReturnsSI()
        {
            int ExpectedResult = 1000;
            CalcInterest calc = new CalcInterest();
            int ActualResult = calc.Calculate(10000, 1, 10);
            Assert.AreEqual(ExpectedResult, ActualResult);

        }
    }
}
