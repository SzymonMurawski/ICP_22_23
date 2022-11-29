namespace PigLatinTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in sentence to translate");
            string sentence = Console.ReadLine();
            string translatedSentence = TranslateSentence(sentence);
            Console.WriteLine($"In pig lating: {translatedSentence}");
        }
        static string TranslateSingleWord(string word)
        {
            string translatedWord = word.Substring(1) + word[0] + "ay";
            return translatedWord;
        }
        static string TranslateSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            string translatedSentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                translatedSentence += $" {TranslateSingleWord(words[i])}";
            }
            return translatedSentence;
        }
    }
}