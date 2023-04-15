using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problems
{
    internal class EvenOdd
    {
        public void oddEven()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write(" Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write(" Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
