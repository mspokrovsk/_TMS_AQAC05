// See https://aka.ms/new-console-template for more information

using AbstractClasses;
using AbstractClasses.Game;

// AbstractClassTemplate abstractClassTemplate = new AbstractClassTemplate(); - Ошибка

Warrior warrior = new Warrior(1);
warrior.name = "Tor";
warrior.level = 20;

Wizard wizard = new Wizard(1);

warrior.Move();
warrior.Attack();
warrior.UseAbility();
warrior.Test();

wizard.Move();
wizard.Attack();
wizard.UseAbility();

warrior.PrintInfo();
wizard.PrintInfo();

//Character character = new Character(); 
Character[] characters = new Character[3];

characters[0] = new Wizard(1);
characters[0].Clan = "Бобры";

characters[1] = new Warrior(1); 
characters[2] = new Warrior(10); 

foreach(var character in characters)
{
    character.Move();
    character.PrintInfo();
}