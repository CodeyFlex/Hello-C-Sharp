using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using Microsoft.VisualBasic;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        //Instance of calculator to be tested
        Calculator.CalculatorClass Calc = new CalculatorClass();

        [TestMethod]
        public void SumTest()
        {
            // Testing Sum method expecting it to return 8.
            Assert.AreEqual(8, Calc.sum(3, 5));
        }
        [TestMethod]
        public void MinusTest()
        {
            // Testing Minus method expecting it to return 2.
            Assert.AreEqual(2, Calc.minus(12, 10));
        }
        [TestMethod]
        public void MultiplyTest()
        {
            // Testing Multiply method expecting it to return 500.
            Assert.AreEqual(500, Calc.multiply(5, 100));
        }
        [TestMethod]
        public void DivideTest()
        {
            // Testing Divide method expecting it to return 20.
            Assert.AreEqual(20, Calc.divide(100, 5));
        }
        [TestMethod]
        public void UserExperienceTest()
        {
            // Testing user experience method.
            Assert.AreEqual("Thy is very impressed by this calculator", Calc.userExperience("Thy"));
        }
        [TestMethod]
        public void SpareMoneyTest()
        {
            // Testing spare money calculator.
            Assert.AreEqual(850, Calc.spareMoney(5000, 2800, 1000, 200, 150));
        }
    }
}
