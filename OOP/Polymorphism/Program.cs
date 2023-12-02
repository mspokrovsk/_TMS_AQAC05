// See https://aka.ms/new-console-template for more information

Individual individual1 = new Individual(1);
individual1.SendNotification();
individual1.Address = "Individual Address";


Corporate corporate1 = new Corporate(1);
corporate1.SendNotification();
corporate1.Address = "Office Address";


Console.WriteLine(individual1.Address);
Console.WriteLine(corporate1.Address);