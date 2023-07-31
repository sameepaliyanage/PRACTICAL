using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_Question_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[arraySize];
            int[] array2 = new int[arraySize];

            for (int i = 0; i < arraySize; i++) 
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int scalarSum = 0;
            for (int i = 0; i < arraySize; i++)
            {
                scalarSum += array1[i] + array2[i];
            }
            int[] vectorSum = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                vectorSum[i] = array1[i] + array2[i];
            }
            int[] vectorProduct = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                vectorProduct[i] = array1[i] * array2[i];
            }
            int scalarProduct = 0;
            for (int i = 0; i < arraySize; i++)
            {
                scalarProduct += array1[i] * array2[i];
            }
            Console.WriteLine("The scalar sum is " + scalarSum);
            Console.WriteLine("The vector sum is " + vectorSum);
            Console.WriteLine("The vector product is " + vectorProduct);
            Console.WriteLine("The scalar product is " + scalarProduct);
            Console.ReadKey();


        }
    }
}
