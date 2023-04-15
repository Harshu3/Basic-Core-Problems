using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problems
{
    internal class Factors
    {
        public void fact()
        {
            Console.WriteLine("Enter the number to find prime factor");
            int n = int.Parse(Console.ReadLine());
            int number = n;
            Console.WriteLine("Prime Factors are");
            for (int i = 2; number >= i * i; i = i)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                    number = number / i;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(number);
        }
    }
}
