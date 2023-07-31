using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,sum;

            Console.WriteLine("Enter a value for first number: ");
            num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for second number: ");
            num2=int.Parse(Console.ReadLine()); 

            sum=num1 + num2;
            Console.WriteLine("The sum of two numbers is: " +sum);

            Console.ReadLine();



        }
    }
}
