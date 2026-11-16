
using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a starting number.
        Console.Write("Enter a starting number: ");

        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
        {
            Countdown(number);
        }
        else
        {
            Console.WriteLine("Please enter a valid non-negative number.");
        }
    }

    // Recursive method that counts down to zero.
    static void Countdown(int number)
    {
        Console.WriteLine(number);

        // Base case: stop when the number reaches zero.
        if (number == 0)
        {
            Console.WriteLine("Blast Off!");
            return;
        }

        // Recursive call: decrease the number by one.
        Countdown(number - 1);
    }
}
