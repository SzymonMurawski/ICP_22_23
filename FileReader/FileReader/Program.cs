// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(@"Please provie an absolute path to file (like C:\data.txt)");
string filePath = Console.ReadLine();
StreamReader sr = new StreamReader(filePath);
int[] countOfWordsOfLength = new int[20];
int totalWordsCount = 0;
while (!sr.EndOfStream)
{
    string line = sr.ReadLine();
    string[] words = line.Split(' ');
    for(int i = 0; i < words.Length; i++)
    {
        totalWordsCount++;
        string word = words[i];
        if (word.Length < countOfWordsOfLength.Length)
        {
            countOfWordsOfLength[i] = word.Length;
        }
    }

}
sr.Close();
Console.WriteLine($"In file {filePath} there are {totalWordsCount} words:");
for (int i = 1; i < countOfWordsOfLength.Length; i++)
{
    Console.WriteLine($"{countOfWordsOfLength[i]} words of length {i},");
}