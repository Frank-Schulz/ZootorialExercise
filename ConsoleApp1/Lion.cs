using System;
using System.Collections.Generic;
using System.Text;

namespace Zootorial
{
    public class Lion : Animal
    {
        public override string GetSound()
        {
            return "Roar";
        }

        public override string GetSpecies()
        {
            return "Lion";
        }
    }
}
