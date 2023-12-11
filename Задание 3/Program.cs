// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Задание_3;

Bus bus = new Bus("Екатеринбург", 1, new DateTime(2023, 12, 10, 10, 00, 00), 40);
Console.WriteLine("Вид транспорта: " + bus.TransportType);
Console.WriteLine("Destination: " + bus.Destination);
Console.WriteLine("Number: " + bus.Number);
Console.WriteLine("Departure Time: " + bus.DepartureTime);
Console.WriteLine("Seats: " + bus.Seats);
Trolleybus trolleybus = new Trolleybus("Машинострителей", 6, new DateTime(2023, 12, 25, 06, 00, 00), 36);
Train train = new Train("Киров", 3, new DateTime(2023, 12, 09, 20, 00, 00), 200);

Transport[] transportArray = new Transport[6];
transportArray[0] = new Bus("Екатеринбург", 1, new DateTime(2023, 12, 10, 10, 00, 00), 40);
transportArray[1] = new Bus("Серов", 2, new DateTime(2023, 12, 11, 15, 30, 00), 25);
transportArray[2] = new Train("Киров", 3, new DateTime(2023, 12, 09, 20, 00, 00), 200);
transportArray[3] = new Train("Москва", 4, new DateTime(2023, 12, 15, 08, 00, 00), 145);
transportArray[4] = new Trolleybus("Трансагенство", 5, new DateTime(2023, 12, 23, 07, 00, 00), 26);
transportArray[5] = new Trolleybus("Машинострителей", 6, new DateTime(2023, 12, 25, 06, 00, 00), 36);

Array.Sort(transportArray, (x, y) => x.Seats.CompareTo(y.Seats));

foreach (var transport in transportArray)
{
    Console.WriteLine($"Destination: {transport.Destination}, Number: {transport.Number}, Departure Time: {transport.DepartureTime}, Seats: {transport.Seats}, Transport Type: {transport.GetTransportType()}");
}

Console.Write("Введите время отправления (гггг.мм.дд чч:мм:сс): ");
DateTime timeInput = DateTime.Parse(Console.ReadLine());
Console.Write("Введите пункт назначения: ");
string destinationInput = Console.ReadLine();

Transport foundTransport = null;
foreach (var transport in transportArray)
{
    if (transport.DepartureTime == timeInput && transport.Destination == destinationInput)
    {
        foundTransport = transport;
        break;
    }
}

if (foundTransport != null)
{
    Console.WriteLine($"Найденный транспорт - Пункт назначения: {foundTransport.Destination}, Номер: {foundTransport.Number}, Время отправления: {foundTransport.DepartureTime}, Количество мест: {foundTransport.Seats}, Тип транспорта: {foundTransport.GetTransportType()}");
}
else
{
    Console.WriteLine("Транспорт, соответствующий заданным параметрам, не найден.");
}
// Поиск списка транспорта, отправляющегося после заданного времени
List<Transport> departingTransport = new List<Transport>();

foreach (Transport transport in transportArray)
{
    if (transport.DepartureTime <= timeInput)
    {
        departingTransport.Add(transport);
    }
}
// Вывод списка транспорта, отправляющегося после заданного времени
Console.WriteLine("Список транспорта, отправляющегося после заданного времени:");
foreach (Transport transport in departingTransport)
{
    Console.WriteLine($"{transport.GetTransportType()}, {transport.Destination}, {transport.Number}, {transport.Seats} мест");
}
// Вызов метода PrintTransportType для каждого объекта
TransportService transportService = new TransportService();
transportService.PrintTransportType(bus);
transportService.PrintTransportType(trolleybus);
transportService.PrintTransportType(train);