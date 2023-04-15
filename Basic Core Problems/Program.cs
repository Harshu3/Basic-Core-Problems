using System;

namespace Basic_Core_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Problems!");
            Console.WriteLine("Please choose any one program from below options:");
            Console.WriteLine("1.Flip Coin\n2.Leap Year");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin fc = new FlipCoin();
                    fc.flipCoin();
                    break;
                case 2:
                    LeapYear ly = new LeapYear();
                    ly.Year();
                    break;
            }
        }
    }
}