using LINQ.models;

namespace LINQ;

public class Hotel
{
    public string Name { get; set; }
    public List<Person> Persons { get; set; }

    public Hotel(string name, List<Person> persons)
    {
        Name = name;
        Persons = persons;
    }
}