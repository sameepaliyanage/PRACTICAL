using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter a value for no1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for no2: ");
            num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("The sum is " + sum);

            int subtraction = num1 - num2;
            Console.WriteLine("The subtraction is " + subtraction);

            int multiplication = num1 * num2;
            Console.WriteLine("The subtraction is " + multiplication);

            float div = num1 / num2;
            Console.WriteLine("The division is " + div);

            Console.ReadLine();

        }
    }
}
