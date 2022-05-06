public class PrimeNumbers
{
    public static bool IsPrime(int number)
    {
        for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        Console.WriteLine("Enter a positive integer: ");
        int userInput = int.Parse(Console.ReadLine());
        Console.WriteLine("Prime numbers:");

        for (int i = 2; i < userInput; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}