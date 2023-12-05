// See https://aka.ms/new-console-template for more information

using AbstractClasses.Game;

Console.WriteLine("Hello, World!");

Character[] characters = new Character[3];

characters[0] = new Wizard(1);
characters[1] = new Warrior(1);
characters[2] = new Warrior(2);

foreach (var character in characters)
{
    character.Move();
    character.Attack();
    character.UseAbility();
}

//