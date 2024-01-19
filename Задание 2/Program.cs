using Задание_2;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        CalculationDelegate circumferenceDelegate = calculator.CalculateCircumference;
        CalculationDelegate areaDelegate = calculator.CalculateArea;
        CalculationDelegate volumeDelegate = calculator.CalculateVolume;

        double R = 5.0;

        Console.WriteLine("Длина окружности: " + circumferenceDelegate(R));
        Console.WriteLine("Площадь круга: " + areaDelegate(R));
        Console.WriteLine("Объем шара: " + volumeDelegate(R));
    }
}
