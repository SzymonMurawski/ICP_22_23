// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
FizzBuzz(10);


void FizzBuzz(int n)
{
    for (int i = 1; i <= n; i++) {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}

void FizzBuzzButBetter(int n)
{
    for (int i = 1; i <= n; i++)
    {
        string output = "";

        if (i % 3 == 0)
        {
            output += "Fizz";
        }
        
        if (i % 5 == 0)
        {
            output += "Buzz";
        }

        if(output == "")
        {
            output = i.ToString();
        }
        Console.WriteLine(output);
    }
}