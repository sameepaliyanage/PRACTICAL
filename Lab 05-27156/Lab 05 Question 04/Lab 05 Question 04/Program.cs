using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Question_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello sayHello = new SayHello();
            sayHello.sayHello();
        }
    }
    class SayHello
    {
        public void sayHello()
        {
            Console.WriteLine("Hello world!");
            Console.ReadKey();
        }
    }
}
