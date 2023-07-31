using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Enter the Numbers :");
            int numbers = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; numbers > 0; i++)
            {

                int digit = numbers % 10;
                sum += digit;
                numbers /= 10;
            }
            Console.WriteLine("The sum of the digits is: {0}", sum);
            Console.ReadLine();
        }
    }
    
}
