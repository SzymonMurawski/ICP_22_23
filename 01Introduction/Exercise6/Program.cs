namespace Exercise6
{
    internal class Program
    {
        /* Write a program which will compute the value of a quadratic function y = ax2 + bx + c at a given
        point x.The coefficients a, b, c and point x should be provided by the user during the execution.
        Make sure the program has a reasonably clear interface.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic function analyzer y = ax^2 + bx + c");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            double y = a * Math.Pow(x, 2) + b * x + c;
            Console.WriteLine($"{a}*{x}^2 + {b}*{x} + {c} = {y}");
        }
    }
}