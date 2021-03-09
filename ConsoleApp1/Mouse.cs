using System;
using System.Collections.Generic;
using System.Text;

namespace Zootorial
{
    public class Mouse : Animal
    {
        public override string GetSound()
        {
            return "Squeak";
        }
        public override string GetSpecies()
        {
            return "Mouse";
        }
    }
}
