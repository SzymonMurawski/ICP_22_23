// See https://aka.ms/new-console-template for more information
using MonsterSlayerGame;

Console.Write("What is your name hero? ");
string playerName = Console.ReadLine();
int playerHealth = 100;
string playerWeapon = "2d6";
string playerBlock = "1d20";
Monster monster = new Monster("Goblin", 15, "1d6");

while (true)
{
    Console.WriteLine($"{playerName} with {playerHealth}hp fights {monster.Name} with {monster.Health}hp");
    Console.Write($"Given choice between ATTACK and BLOCK {playerName} decides to ");
    string choice = Console.ReadLine();
    int monsterAttackValue = rollDice(monster.Weapon);
    switch (choice)
    {
        case "ATTACK":
            int playerAttackValue = rollDice(playerWeapon);
            playerHealth -= monsterAttackValue;
            monster.Health -= playerAttackValue;
            Console.WriteLine($"{playerName} attacks for {playerAttackValue}, but {monster.Name} responds with a hit for {monsterAttackValue}");
            break;
        case "BLOCK":
            int playerBlockValue = rollDice(playerBlock);
            // this is a bug/feature - if block value is higher than attack value, player will be healed
            playerHealth -= monsterAttackValue - playerBlockValue;
            Console.WriteLine($"{monster.Name} tries to hit for {monsterAttackValue}, but {playerName} blocks {playerBlockValue}");
            break;
        default:
            playerHealth -= monsterAttackValue;
            Console.WriteLine($"While {playerName} tries in vain to {choice}, {monster.Name} takes a swing for {monsterAttackValue}");
            break;
    }
    if (monster.Health <= 0)
    {
        Console.WriteLine($"{playerName} defeated {monster.Name}!");
        break;
    } else if (playerHealth <= 0)
    {
        Console.WriteLine($"{playerName} was vanquished by {monster.Name}");
        break;
    }
}

// dice is in form xdy: x-numer of dices to roll, y-number of sides on a dice
int rollDice(string dice)
{
    string[] diceElements = dice.Split('d');
    int numberOfDicesToRoll = int.Parse(diceElements[0]);
    int numberOfSides = int.Parse(diceElements[1]);
    int result = 0;
    Random random = new Random();
    for(int i = 0; i < numberOfDicesToRoll; i++)
    {
        result += random.Next(1, numberOfSides);
    }
    return result;
}