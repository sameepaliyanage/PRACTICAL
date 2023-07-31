using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Question_02
{
    class Program
    {
        static void Main(string[] args)
        {
            FindValues findValues = new FindValues();

            Console.WriteLine("Enter the radius value: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = findValues.findArea(radius);
            double circumference = findValues.findCircumference(radius);

            Console.WriteLine("The area of the circle is " + area);
            Console.WriteLine("The circumference of the circle is " + circumference);

        }
    }
    class FindValues
    {
        public double findArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
        public double findCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
           
        }
    }
}
