namespace Exercise6
{
    internal class Program
    {
        // Write a program which calculates the factorial of a number from range <1,10> given by the user
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= n;
            }
            Console.WriteLine($"{n}! = {result}");
        }
    }
}