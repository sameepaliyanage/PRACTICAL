using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;

            Console.WriteLine("Enter the radius value: ");
            radius = double.Parse(Console.ReadLine());  

            Console.WriteLine("Area of the circle " +(3.14*radius*radius));

            Console.ReadLine();
        }
    }
}
