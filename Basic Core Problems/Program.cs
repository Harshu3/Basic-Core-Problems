using System;

namespace Basic_Core_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Problems!");
            Console.WriteLine("Flipping a Coin");
            FlipCoin fc = new FlipCoin();
                    fc.flipCoin();
        }
    }
}