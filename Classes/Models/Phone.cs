using System.Xml.Linq;

namespace Classes.Models;

public class Phone
{
    public string model;
    public int number;
    public double weight;
    public string name;

    public Phone()// первый конструктор
    {
    }

    public Phone(int number, string model)// второй конструктор
    {
        this.number = number;
        this.model = model;

    }

   public Phone(double weight, int number, string model) : this(number, model)// третий конструктор
    {
        this.weight = weight;

    }

    public void receiveCall(string callerName) // метод receiveCall
    {
        Console.Write($"Звонит {callerName}, ");
    }

    public int getNumber() // метод getNumber
    {
        return number;
    }

    public void sendMessage(params int[] numbers) // метод sendMessage
    {
        Console.WriteLine("Отправка сообщения следующим номерам:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}

