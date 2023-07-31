using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (count <= 9)
            {

                Console.Write("Enter the Number :");

                int n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Entered number is an Even");
                }
                else
                {
                    Console.WriteLine("Entered number is an Odd");
                }

                count++;


            }
            Console.ReadLine();
        }

    }
}