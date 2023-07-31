using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            int vowelCount = CountVowels(input);

            Console.WriteLine($"The number of vowels in the given string is: {vowelCount}");
        }
        static int CountVowels(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count;
        }

        static bool IsVowel(char c)
        {
            char lowerChar = Char.ToLower(c);
            return lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u';
        }
    }
}
