using System;
using System.Collections.Generic;
using System.Text;

namespace Zootorial
{
    public class Tiger : Animal
    {
        public override void AddAnimal()
        {
            return "Snarl";
        }
        public override string GetSpecies()
        {
            return "Tiger";
        }
    }
}
