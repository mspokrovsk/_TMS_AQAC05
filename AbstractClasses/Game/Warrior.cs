namespace AbstractClasses.Game;

public class Warrior : Character
{
    public Warrior(int level) : base(level)
    {
    }
    
    public override void Move()
    {
        Console.WriteLine("Warrior is moving to...");
    }

    public override void Attack()
    {
        Console.WriteLine("Warrior is attacking to...");
    }

    public override void UseAbility()
    {
        Console.WriteLine("Warrior is using ability to...");
    }

    public override string Clan { get; set; }

    public void Test()
    {
        Console.WriteLine("Test");
    }
}