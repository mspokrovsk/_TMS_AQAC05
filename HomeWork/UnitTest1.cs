namespace HomeWork
{
    using NUnit.Framework.Internal;
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test(Description = "Проверка деления на ноль"), Order(3)]
        public void TestDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Div(10, 0));
        }

        [Test(Description = "Проверка целочисленного деления"), Order(2)]
        [TestCase(10, 2, 5)]
        [TestCase(10, 3, 3)]
        [TestCase(10, 0, 10)]
        public void TestDivInt(int a, int b, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calculator.Div(a, b));
        }

        [Test(Description = "Проверка деления числа с плавающей точкой"), Order(2)]
        [TestCase(10.5, 2.5, 4.2)]
        [TestCase(10.5, 3.0, 3.5)]
        [TestCase(10.1, 0.0, 10.1)]
        public void TestDivDouble(double a, double b, double expectedResult)
        {
            Assert.AreEqual(expectedResult, _calculator.Div(a, b));
        }
    }
}