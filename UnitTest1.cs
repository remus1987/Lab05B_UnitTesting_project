using NUnit.Framework;
using Lab05_Unit_Testing;

namespace TestCalculatorMethods
{
    public class Tests
    {
        [TestFixture]
        public class CalculatorTest
        {

            Calculator calc = new Calculator();
            [SetUp]
            public void SetUpMethod()
            {
                calc = new Calculator();
            }
            [Test]
            public void TestAddMethod()
            {
                Assert.AreEqual(5, calc.Add(2, 3));
            }
            [Test]
            public void TestSubtractMethod()
            {
                Assert.AreEqual(-1, calc.Subtract(2, 3));
            }
            [Test]
            public void TestMultiplyMethod()
            {
                Assert.AreEqual(6, calc.Multiply(2, 3));
            }
            [Test]
            public void TestDivideMethod()
            {
                Assert.AreNotEqual(6, calc.Divide(2, 3));
            }
            [TearDown]
            public void CleanUp()
            {
                calc = null;
            }
        }
    }
}