namespace AbstractClasses.Game;

public abstract class Character : BaseCharacter
{
    public int level;
    public string name;
    

    protected Character(int level)
    {
        this.level = level;
    }

    public abstract void Move();
    public abstract void Attack();
    public abstract void UseAbility();

    public void PrintInfo()
    {
        Console.WriteLine($"{name} {level}");
    }

    public abstract string Clan { get; set; }
}