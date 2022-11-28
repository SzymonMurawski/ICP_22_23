namespace Exercise5
{
    internal class Program
    {
        // Write a program which will convert a value from PLN to USD
        static void Main(string[] args)
        {
            Console.WriteLine("How much money you want to convert?");
            Console.Write("PLN = ");
            double amountOfPLN = double.Parse(Console.ReadLine());
            double exchangeRatePLNToUSD = 0.22;
            double amountOfUSD = amountOfPLN * exchangeRatePLNToUSD;
            Console.WriteLine($"That's ${amountOfUSD}");
        }
    }
}