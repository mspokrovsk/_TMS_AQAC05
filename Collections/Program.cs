using Collections;
using Collections.IDictionary;
using Collections.IList;
using Collections.ISet;

// -==================== IList ====================-
// -==================== ArrayList
// new ArrayListExample().Run();

// -==================== List<T>
// new ListExample().Run();

// -==================== LinkedList<T>
// new LinkedListExample().Run();

// -==================== IDictionary ====================-
// -==================== Dictionary<TKey, TValue>
// new DictionaryExample().Run();

// -==================== SortedList<TKey, TValue>
// new SortedListExample().Run();

// -==================== SortedDictionary<TKey, TValue>
// new SortedDictionaryExample().Run();

// -==================== HashSet<TKey, TValue>
// new HashSetExample().Run();

// -==================== Stack<T>
// new StackExample().Run();

// -==================== Queue<T>
// new QueueExample().Run();

// -==================== Пример
// new Example().Run();

// -==================== Equals and GetHashCode
Person person1 = new Person()
{
    FirstName = "Alex",
    LastName = "Trostyanko"
};

Person person2 = new Person()
{
    FirstName = "Alex",
    LastName = "Trostyanko"
};

Console.WriteLine(person1.GetHashCode());
Console.WriteLine(person2.GetHashCode());
Console.WriteLine(person1.Equals(person2));

// -==================== yield
IEnumerable<int> GenerateNumbers(int count)
{
    for (int i = 0; i < count; i++)
    {
        yield return i;
    }
}

foreach (var number in GenerateNumbers(5))
{
    Console.WriteLine(number);
}