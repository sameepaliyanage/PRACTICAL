using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Question_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateValues calculateValues = new CalculateValues();

            int choice = Convert.ToInt32(Console.ReadLine());
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int answer;
            switch (choice)
            {
                case 1:
                    answer = calculateValues.addition(number1, number2);
                    break;
                case 2:
                    answer = calculateValues.subtraction(number1, number2);
                    break;
                case 3:
                    answer = calculateValues.multiplication(number1, number2);
                    break;
                case 4:
                    answer = calculateValues.division(number1, number2);
                    break;
                default:
                    answer = 0;
                    break;
            }
            Console.WriteLine("The answer is " + answer);
        }
    }
    class CalculateValues
    {
        public int addition(int number1, int number2)
        {
            return number1 + number2;
        }
        public int subtraction(int number1, int number2)
        {
            return number1 - number2;
        }
        public int multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
        public int division(int number1, int number2)
        {
            return number1 / number2;
            Console.ReadKey();
        }
        
    }
}
