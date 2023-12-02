// See https://aka.ms/new-console-template for more information

using Polymorphism;

Client client = new Client();

client.CountBill(10, 10);
client.CountBill(10, 10, 10);

Individual individual1 = new Individual(1);
individual1.SendNotification();
//individual1.Address = "Individual Address";


Corporate corporate1 = new Corporate(1);
corporate1.SendNotification();
//corporate1.Address = "Office Address";


//Console.WriteLine(individual1.Address);
//Console.WriteLine(corporate1.Address);

ChildIndividual childIndividual = new ChildIndividual(10);
childIndividual.SendNotification();

ChildCorporate childCorporate = new ChildCorporate(11);
childCorporate.SendNotification();