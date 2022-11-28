namespace Exercise1
{
    internal class Program
    {
        // Write a program checking if a number given by the user is even or odd.
        static void Main(string[] args)
        {
            Console.Write("Please provide an integer number.\n x =");
            int x = int.Parse(Console.ReadLine());
            if(x % 2 == 0)
            {
                Console.WriteLine($"{x} is even");
            } else
            {
                Console.WriteLine($"{x} is odd");
            }
        }
    }
}