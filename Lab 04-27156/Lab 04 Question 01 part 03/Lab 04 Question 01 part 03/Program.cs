using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Question_01_part_03
{
     class Program
    {
        static void Main(string[] args)
        {
            ConvertValues convertValues = new ConvertValues();

            Console.WriteLine("Enter the kilometer value: ");
            double kilometerValue = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();
            double meterValue = convertValues.kilometerTOmeter(kilometerValue);

            Console.WriteLine("The meter value is " + meterValue);
        }
    }
    class ConvertValues
    {
        public double kilometerTOmeter(double kilometerValue)
        {
            double meterValue = kilometerValue * 1000;
            return meterValue;
        }
    }
}
