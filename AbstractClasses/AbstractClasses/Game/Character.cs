namespace AbstractClasses.Game;

public abstract class Character
{
    public int level;
    public string name;

    public Character(int level)
    {
        this.level = this.level;
    }
    
    public abstract void Move();
    public abstract void Attack();
    public abstract void UseAbility();
}