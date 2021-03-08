using System;
using System.Collections.Generic;
using System.Text;

namespace Zootorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var zoo = new Zoo();
            zoo.GetAnimals();
            Console.WriteLine("Welcome to the zoo!");
            Console.WriteLine("Here is our current list of animals we have here:");
            foreach (var animal in zoo.AnimalList)
            {
                Console.WriteLine(animal + "");
            }

        }
    }
}
