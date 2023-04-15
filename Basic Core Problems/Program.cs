﻿using System;

namespace Basic_Core_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Problems!");
            Console.WriteLine("Please choose any one program from below options:");
            Console.WriteLine("1.Flip Coin\n2.Leap Year\n3.Power of 2\n4.Harmonic Number\n5.Factors");
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
                case 3:
                    PowerOf2 powerOf2 = new PowerOf2();
                    powerOf2.powOf2();
                    break;
                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.HarmonicNum();
                    break;
                case 5:
                    Factors factors = new Factors();
                    factors.fact();
                    break;
            }
        }
    }
}