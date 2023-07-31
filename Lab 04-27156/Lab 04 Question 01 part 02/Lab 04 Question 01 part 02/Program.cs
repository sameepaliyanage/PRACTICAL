using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Question_01_part_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues convertValues = new ConvertValues();

            Console.WriteLine("Enter the kilometer value:");
            double kilometerValue = Convert.ToDouble(Console.ReadLine());

            convertValues.kilometerTOmeter(kilometerValue);
        }
    }
    class ConvertValues
    {
        public void kilometerTOmeter(double kilometerValue)
        {
            double meterValue = kilometerValue;
            Console.WriteLine("The meter value is " + meterValue);
            Console.ReadKey();
        }
    }
}
