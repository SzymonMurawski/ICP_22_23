namespace Exercise2
{
    internal class Program
    {
        // Write a program which will calculate an area of a rectangle with dimensions stored in variables a and b.
        // Store the result in an additional variable before printing it to the console.
        static void Main(string[] args)
        {
            double a = 12;
            double b = 4.5;
            double areaOfRectangle = a * b;
            Console.WriteLine($"a * b = {areaOfRectangle}");
        }
    }
}