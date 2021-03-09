using System;
using System.Collections.Generic;
using System.Text;

namespace Zootorial
{
    public class Tiger : Animal
    {
        public override string GetSound()
        {
            return "Snarl";
        }
        public override string GetSpecies()
        {
            return "Tiger";
        }
    }
}
