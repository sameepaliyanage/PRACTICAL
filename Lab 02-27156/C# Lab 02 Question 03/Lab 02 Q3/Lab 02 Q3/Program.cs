using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;

            Console.WriteLine("Enter the radius value: ");
            radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Area of circle is " + (3.14 * radius * radius));
            Console.WriteLine("Circumferance is " + (2 * 3.14 * radius));


            Console.ReadLine();
        }
    }
}
