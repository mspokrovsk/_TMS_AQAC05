namespace HomeWork
{
    using NUnit.Framework.Internal;
    [TestFixture, Category("Regression")]
    public class CalculatorTests
    {
        public Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test(Description = "Проверка деления на ноль"), Order(3)]
        [Author("mspokrovsk")]
        [Repeat(5)]
        public void TestDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Div(10, 0), "Деление на ноль недопустимо");
        }

        [Test, Ignore("Пропуск теста")]
        [Author("mspokrovsk")]
        public void TestDivideByZer()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Div(10, 0), "Деление на ноль недопустимо");
        }

        [Test(Description = "Проверка целочисленного деления"), Order(1)]
        [Author("mspokrovsk")]
        [Retry(3)]
        [TestCase(10, 2, 5)]
        [TestCase(10, 3, 3)]
        public void TestDivInt(int a, int b, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calculator.Div(a, b));
        }

        [Test(Description = "Проверка деления числа с плавающей точкой"), Order(2)]
        [Author("mspokrovsk")]
        [TestCase(10.5, 2.5, 4.2)]
        [TestCase(10.5, 3.0, 3.5)]
        public void TestDivDouble(double a, double b, double expectedResult)
        {
            Assert.AreEqual(expectedResult, _calculator.Div(a, b));
        }

        [Test, Order(4)]
        [Author("mspokrovsk")]
        public void AllValuesTest(
        [Random(1, 10, 1)] int randomNumber,
        [Range(1, 2, 1)] int rangeNumber)
        {
            int a = randomNumber;
            int b = rangeNumber;
            int expectedResult = 2;
            Assert.AreEqual(expectedResult, _calculator.Div(a, b));
            Assert.AreEqual(expectedResult, _calculator.Div(a, b));
        }

        [Test(Description = "Проверка с внешним хранилищем"), Order(5)]
        [Author("mspokrovsk")]
        [TestCaseSource(typeof(TestData), nameof(TestData.DivCases))]
        public void DivideTest(int a, int b, int c)
        {
            Assert.That(a / b, Is.EqualTo(c));
        }
    }
}