delegate int RandomNumber(); // объявление делегата, который ничего не принимает на вход и возвращает тип int

class Program
{
    static void Main(string[] args)
    {
        RandomNumber randomNumberDelegate = new RandomNumber(RandomNumberGenerator); // создание экземпляра делегата и привязка к методу
        int randomNumber = randomNumberDelegate(); // вызов метода через делегат
        Console.WriteLine(randomNumber); // вывод результата
    }

    static int RandomNumberGenerator() // метод, который ничего не принимает на вход и возвращает тип int
    {
        Random random = new Random();
        return random.Next(0, 11);
    }   
}