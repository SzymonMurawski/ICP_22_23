namespace Exercise5
{
    internal class Program
    {
        // Write a simple calculator, which will allow for basic arithmetic’s (+, -, *, /) on two numbers
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write an operation in form `X + Y`. You can use the following operators: +-*/." +
                    "Type empty input to finish");
                Console.Write("operation: ");
                string rawUserInput = Console.ReadLine();
                if(string.IsNullOrEmpty(rawUserInput))
                {
                    Console.WriteLine("No input, closing the application");
                    break;
                }
                string[] elements = rawUserInput.Split(' ');
                double x = double.Parse(elements[0]);
                string arithmeticOperator = elements[1];
                double y = double.Parse(elements[2]);
                double result = 0;
                switch (arithmeticOperator)
                {
                    case "+": result = x + y; break;
                    case "-": result = x - y; break;
                    case "*": result = x * y; break;
                    case "/": result = x / y; break;
                    default: Console.WriteLine($"Unhandled operator `{arithmeticOperator}`, please try again"); continue;
                }
                Console.WriteLine($"{x} {arithmeticOperator} {y} = {result}");
            }
        }
    }
}