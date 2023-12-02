// See https://aka.ms/new-console-template for more information

using Abstraction;

Individual individual1 = new Individual(1);
individual1.PhoneNumber = "+375 29 12345678";
individual1.Email = "individual@test.com";
individual1.Firstname = "Иван";
individual1.Lastname = "Иванов";
individual1.Activate();

Individual individual2 = new Individual(2);
Console.WriteLine(individual1.PhoneNumber); //"+375 29 12345678";
Console.WriteLine(individual2.PhoneNumber); //""

Corporate corporate1 = new Corporate(1);
corporate1.PhoneNumber = "+375 29 10000001";
corporate1.Email = "corporate1@test.com";
corporate1.INN = "123123123";
corporate1.UNP = "321321321";
corporate1.Activate();
corporate1.Pause();
