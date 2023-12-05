namespace Interfaces;

public interface IImplementable
{
    public const int minSpeed = 0; // минимальная скорость
    private static int maxSpeed = 60; // максимальная скорость

    // находим время, за которое надо пройти расстояние distance со скоростью speed
    static double GetTime(double distance, double speed) => distance / speed;

    static int MaxSpeed
    {
        get => maxSpeed;
        set
        {
            if (value > 0) maxSpeed = value;
        }
    }
}