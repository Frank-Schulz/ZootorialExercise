using System;
using System.Collections.Generic;
using System.Text;

namespace Zootorial
{
    public class Mouse : Animal
    {
        public override void AddAnimal()
        {
            return "Squeak";
        }
        public override string GetSpecies()
        {
            return "Mouse";
        }
    }
}
