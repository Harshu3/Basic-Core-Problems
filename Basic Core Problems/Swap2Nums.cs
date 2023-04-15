using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problems
{
    internal class Swap2Nums
    {
        public void swap()
        {
            Console.WriteLine("Enter the two numbers");
            Console.WriteLine("1st number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("2nd number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swap a = " + a + "  b = " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.Write("After swap a = " + a + "  b = " + b);
        }
    }
}
