public class PrimeNumbers
{
    public static bool IsPrimeNumber(int number)
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

        int primeNumberCount = 0;
        int number = 2;
        while (primeNumberCount < userInput)
        {
            bool isPrime = IsPrimeNumber(number);
            if (isPrime)
            {
                primeNumberCount++;
                Console.WriteLine($"{primeNumberCount}: {number}");
            }
            number++;
        }


        /*for (int i = 2; i < userInput; i++)
        {
            if (IsPrimeNumber(i))
            {
                Console.WriteLine(i);
            }
        }*/
    }
}