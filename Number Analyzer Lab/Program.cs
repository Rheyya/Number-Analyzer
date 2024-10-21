// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        Console.Write("Enter an integer between 1 and 100 inclusive: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 != 0 && number < 60)
        {
            // Console.WriteLine($"{number} Odd and less than 60.");
            Console.WriteLine($"{userName}, you entered {number}. It's odd and less than 60.");
        }
        else if (number % 2 == 0 && number >= 2 && number <= 24)
        {
            // Console.WriteLine("Even and less than 25.");
            Console.WriteLine($"{userName}, you entered {number}. It's even and less than 25.");
        }
        else if (number % 2 == 0 && number >= 26 && number <= 60)
        {
            //Console.WriteLine("Even and between 26 and 60 inclusive.");
            Console.WriteLine($"{userName}, you entered {number}. It's even and between 26 and 60 inclusive.");
        }
        else if (number % 2 == 0 && number > 60)
        {
            //Console.WriteLine($"{number} Even and greater than 60.");
            Console.WriteLine($"{userName}, you entered {number}. It's even and greater than 60.");
        }
        else if (number % 2 != 0 && number > 60)
        {
            // Console.WriteLine($"{number} Odd and greater than 60.");
            Console.WriteLine($"{userName}, you entered {number}. It's odd and greater than 60.");
        }
    }
}
