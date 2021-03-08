using System;
using System.Collections.Generic;
using System.Text;

namespace ZootorialExercise
{
    public abstract class Animal
    {
        private string _name;
        private string _sound;
        private string _species;

        public string Name { get => _name; set => _name = value; }
        public string Sound { get => _sound; set => _sound = value; }
        public string Species { get => _species; set => _species = value; }

        public List<string> Animals;


    }
}
