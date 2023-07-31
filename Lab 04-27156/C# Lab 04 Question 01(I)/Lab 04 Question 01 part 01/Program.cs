using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Question_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues convertvalues = new ConvertValues();

            Console.WriteLine("Enter the kilometer value: ");
            double kilometerValue = Convert.ToDouble(Console.ReadLine());
            convertvalues.kilometerTOmeter(kilometerValue);

        }
    }
    class ConvertValues
    {
        public void kilometerTOmeter(double kilometerValue)
        {
            double meterValue = kilometerValue * 1000;
            Console.WriteLine("The meter value is " + meterValue);
            Console.ReadKey();
        }
    }
}

