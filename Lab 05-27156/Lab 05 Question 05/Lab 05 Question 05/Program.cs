using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Question_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int minValue = array[0];
            int maxValue = array[0];
            int averageValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
                else if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
                averageValue += array[i];
            }
            averageValue /= array.Length;

            int temp;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            Console.WriteLine("The minimum value is " + minValue);
            Console.WriteLine("The maximum value is " + maxValue);
            Console.WriteLine("The average value is " + averageValue);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
