// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"I roll a 1d6 die and get {rollDice("1d6")}");
Console.WriteLine($"I roll a 1d6 die and get {rollDice("1d6")}");
Console.WriteLine($"I roll a 2d5 die and get {rollDice("2d5")}");
Console.WriteLine($"I roll a 3d20 die and get {rollDice("3d20")}");
Console.WriteLine($"I roll a 15d7 die and get {rollDice("15d7")}");

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