using System;

namespace Basic_Core_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Problems!");
            Console.WriteLine("Checking Vowel or Consonant");
                    VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
                    vowelOrConsonant.alphabet();
            }
        }
    }
}