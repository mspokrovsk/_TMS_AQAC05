using NUnit.Framework.Legacy;
using NUnitTest;

namespace NUnitProject;

public class AssertExample
{
    [Test]
    public void PassTest()
    {
        Console.WriteLine("Pass test...");
        Assert.Pass();
    }

    [Test]
    public void FailTest()
    {
        Console.WriteLine("Fail test...");
        Assert.Fail();
    }

    [Test]
    public void AreEqualTest()
    {
        Console.WriteLine("AreEqual test...");
        //Assert.AreEqual(Calc.Sum(1, 2), 3);
        Assert.That(Calc.Sum(1, 2), Is.EqualTo(3));
    }

    // Test with an expected result
    [Test(ExpectedResult = 4)]
    public int ExpectedResultTest()
    {
        Console.WriteLine("ExpectedResultTest...");
        return 2 + 2;
    }

    [Test]
    public void StandardCompareTest()
    {
        var expectedValue = 1;
        var actualValue = 1;

        var expectedPerson = new Person("Alex");
        var actualPerson = expectedPerson;

        //Assert.IsTrue(1 == 1);
        //Assert.IsFalse(1 != 1);

        //Assert.AreEqual(expectedValue, actualValue);
        //Assert.AreEqual(expectedValue, actualValue, "Сообщение в случае ошибки");

        //Assert.AreNotEqual(expectedValue, actualValue + 1, "Сообщение в случае ошибки");

        // Проверяем, что obj1 и obj2 указывают на один и тот же объект
        //Assert.AreSame(expectedPerson, actualPerson);
        //Assert.AreNotSame(expectedPerson, new Person("Alex"));

        //Assert.Greater(1, 2);
        //Assert.GreaterOrEqual(1, 2);

        // Аналоги через That
        Assert.That(actualValue, Is.EqualTo(expectedValue));
        Assert.That(actualValue, Is.EqualTo(expectedValue), "Сообщение в случае ошибки");

        Assert.That(actualValue + 1, Is.Not.EqualTo(expectedValue), "Сообщение в случае ошибки");

        // Проверяем, что obj1 и obj2 указывают на один и тот же объект
        Assert.That(actualPerson, Is.SameAs(expectedPerson));
        Assert.That(new Person("Alex"), Is.Not.SameAs(expectedPerson));
    }

    [Test]
    public void TestListEquality()
    {
        List<int> expectedList = new List<int> { 1, 2, 3 };
        List<int> actualList = new List<int> { 1, 2, 3 };

        CollectionAssert.AreEqual(expectedList, actualList, "Lists should be equal.");
    }

    [Test]
    public void TestCollectionContains()
    {
        List<string> stringList = new List<string> { "apple", "banana", "cherry" };

        CollectionAssert.Contains("banana", stringList, "The collection should contain 'banana'.");
    }

    [Test]
    public void TestCollectionSubset()
    {
        List<int> expectedSubset = new List<int> { 1, 2 };
        List<int> actualList = new List<int> { 1, 2, 3, 4, 5 };

        CollectionAssert.IsSubsetOf(expectedSubset, actualList,
            "The expected subset should be present in the actual list.");
    }

    [Test]
    public void TestCollectionOrder()
    {
        List<int> expectedOrder = new List<int> { 1, 2, 3 };
        List<int> actualList = new List<int> { 1, 2, 3 };

        CollectionAssert.AreEqual(expectedOrder, actualList, "The order of elements should be the same.");
    }

    [Test]
    public void TestCollectionNoDuplicates()
    {
        List<int> noDuplicatesList = new List<int> { 1, 2, 3, 4, 5 };

        CollectionAssert.AllItemsAreUnique(noDuplicatesList, "There should be no duplicate items in the collection.");
    }

    [Test]
    public void SoftAssertTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(" ", Is.Empty, "Строка не пустая");
            Assert.That(11, Is.InRange(0, 10));
        });
    }
}