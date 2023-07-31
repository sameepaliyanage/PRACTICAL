using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_Question_08
{
    class Animal
    {
        public void printAnimal()
        {
            Console.WriteLine("I am an animal");
        }
    }
    class Dog:Animal
    {
        public void printDog()
        {
            Console.WriteLine("I have four legs");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.printAnimal();
            dog.printDog();
            Console.ReadLine();
        }
    }
}
