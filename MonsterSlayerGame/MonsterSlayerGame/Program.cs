// See https://aka.ms/new-console-template for more information
Console.Write("What is your name hero? ");
string playerName = Console.ReadLine();
int playerHealth = 100;
string playerWeapon = "2d6";
string playerBlock = "1d20";

string monsterName = "Goblin";
int monsterHealth = 15;
string monsterWeapon = "1d6";

while (true)
{
    Console.WriteLine($"{playerName} with {playerHealth}hp fights {monsterName} with {monsterHealth}hp");
    Console.Write($"Given choice between ATTACK and BLOCK {playerName} decides to ");
    string choice = Console.ReadLine();
    int monsterAttackValue = rollDice(monsterWeapon);
    switch (choice)
    {
        case "ATTACK":
            int playerAttackValue = rollDice(playerWeapon);
            playerHealth -= monsterAttackValue;
            monsterHealth -= playerAttackValue;
            Console.WriteLine($"{playerName} attacks for {playerAttackValue}, but {monsterName} responds with a hit for {monsterAttackValue}");
            break;
        case "BLOCK":
            int playerBlockValue = rollDice(playerBlock);
            // this is a bug/feature - if block value is higher than attack value, player will be healed
            playerHealth -= monsterAttackValue - playerBlockValue;
            Console.WriteLine($"{monsterName} tries to hit for {monsterAttackValue}, but {playerName} blocks {playerBlockValue}");
            break;
        default:
            playerHealth -= monsterAttackValue;
            Console.WriteLine($"While {playerName} tries in vain to {choice}, {monsterName} takes a swing for {monsterAttackValue}");
            break;
    }
    if (monsterHealth <= 0)
    {
        Console.WriteLine($"{playerName} defeated {monsterName}!");
        break;
    } else if (playerHealth <= 0)
    {
        Console.WriteLine($"{playerName} was vanquished by {monsterName}");
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