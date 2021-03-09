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
            var animalList = zoo.AnimalList;
            var lion = new Lion();
            var tiger = new Tiger();
            var mouse = new Mouse();
            lion.Name = "Cleopatra";
            tiger.Name = "Paprika";
            mouse.Name = "Hercules";


            animalList.Add(lion);
            animalList.Add(tiger);
            animalList.Add(mouse);
            Console.WriteLine("Welcome to the zoo!");
            Console.WriteLine("Here is our current list of animals we have here:");
            foreach (Animal i in zoo.AnimalList)
            {
                Console.WriteLine(i.Name + " the " + i.GetSpecies() + " can " + i.GetSound());
            }

        }
    }
}
