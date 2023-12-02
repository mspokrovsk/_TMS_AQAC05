// See https://aka.ms/new-console-template for more information

using Properties;

Person person = new Person();
person.SetName("Alex");
Console.WriteLine($"{person.GetName()}");

person.Name = "Alex1";
person.Age = 45;
//person.Surname = "Trostyanko";  - Ошибка
//person.Address = "asdasd";  - Ошибка

Console.WriteLine($"{person.Name}");
// Console.WriteLine($"{person.Age}"); - Ошибка
Console.WriteLine($"{person.Surname}");
Console.WriteLine($"{person.Fullname}");
Console.WriteLine($"{person.Address}");
Console.WriteLine($"{person.Salary}");

// Блок init
// Первый способ
//person.ID = "YYY-721"; - Ошибка
Console.WriteLine(person.ID);

// Второй способ
/*
Person person1 = new Person("YYY-721");
Console.WriteLine(person1.ID);

Person person2 = new Person() { ID = "CCC-123" };
Console.WriteLine(person2.ID);
*/

//Person person3 = new Person() { Passport = "MC1234567"};
//Person person4 = new Person("MC1234567"); // Ошибка