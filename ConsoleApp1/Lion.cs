﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zootorial
{
    public class Lion : Animal
    {
        public override void AddAnimal()
        {
            return "Roar";
        }

        public override string GetSpecies()
        {
            return "Lion";
        }
    }
}
