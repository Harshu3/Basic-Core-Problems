using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problems
{
    internal class Division
    {
        public void divide()
        {
            Console.WriteLine("Enter the dividend number");
            int divid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor number");
            int diviso = int.Parse(Console.ReadLine());

            int Quotient = divid / diviso;
            int remainder = divid % diviso;
            Console.WriteLine(" Quotient = " + Quotient + "\nRemainder = " + remainder);
        }
    }
}
