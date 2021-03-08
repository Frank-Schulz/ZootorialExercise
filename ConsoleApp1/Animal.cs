using System;
using System.Collections.Generic;
using System.Text;

namespace Zootorial
{
    public abstract class Animal
    {
        private string _name;
        private string _sound;
        private string _species;

        public string Name { get => _name; set => _name = value; }
        public string Sound { get => _sound; set => _sound = value; }
        public string Species { get => _species; set => _species = value; }

        protected abstract Animal addAnimal()
        {
            
        }

    }
}
