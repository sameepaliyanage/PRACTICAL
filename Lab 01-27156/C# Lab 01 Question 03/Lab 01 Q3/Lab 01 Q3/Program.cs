using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;

            Console.WriteLine("Enter the number:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number:");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine("The sum is " + sum);
            sum = int.Parse(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
