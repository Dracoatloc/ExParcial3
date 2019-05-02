using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr1Examen3.Classes;

namespace Pr1Examen3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Talk();

            Cat cat = new Cat();
            cat.Talk();

            Console.ReadKey();
            
        }
    }
}
