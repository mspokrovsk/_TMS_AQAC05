using System.Collections;
using LINQ.models;

namespace LINQ;

public class TestObjectSet : IEnumerable<Person>
{
    public IEnumerator<Person> GetEnumerator()
    {
        
        var list = new List<Person>()
        {
            new Person("Michel", 18),
            new Person("Oleg", 23),
            new Person("Alex", 45),
            new Person("Olga", 25),
            new Person("Olga", 36),
            new Person("Stanislav", 36),
            new Person("Tom", 45),
        };

        foreach (Person s in list)
        {
            yield return s;
        }
    }

    public List<Hotel> List { get; } = new()
    {
        new Hotel("Sharaton", new List<Person>()
        {
            new Person("Marina", 23),
            new Person("Ivan", 28),
            new Person("Boris", 33)
        }),
        new Hotel("Hilton", new List<Person>()
        {
            new Person("Slava", 25),
            new Person("Petr", 17),
            new Person("Tonya", 34)
        })
    };

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}