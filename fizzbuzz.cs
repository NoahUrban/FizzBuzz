public static void Main(string[] args)
{
    Console.WriteLine(FizzBuzz(15));
}

public static string FizzBuzz(int number)
{
    if (number % 3 == 0 && number % 5 == 0)
    {
        return "fizzbuzz";
    }
    else if (number % 3 == 0)
    {
        return "fizz";
    }
    else if (number % 5 == 0)
    {
        return "buzz";
    }
}