using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problems
{
    internal class HarmonicNumber
    {
        public void HarmonicNum()
        {
            Console.WriteLine("Enter the Nth number");
            int N = int.Parse(Console.ReadLine());
            float harmonic = 1;
            for (int i = 2; i <= N; i++)
            {
                Console.Write("1/{0} + ", i);
                harmonic += 1 / (float)i;
            }
            Console.WriteLine("\nSum of harmonic numbers upto {0} terms: {1}\n", N, harmonic);
        }
    }
}
