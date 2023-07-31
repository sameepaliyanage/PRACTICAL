using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double batch;

            Console.WriteLine("Enter your age: ");
            name= Console.ReadLine();

            Console.WriteLine("Enter your batch: ");
            batch= double.Parse(Console.ReadLine());

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your batch is " + batch);

            Console.ReadLine();
        }
    }
}
