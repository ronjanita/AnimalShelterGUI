﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animalshelter.OOP.GUI
{
    internal class Caecilian:Animal
    {
        public Caecilian(string name, int age, string species) : base(name, age, species) { }
        public override string MakeSound()
        {
            return "I prefeer to stay silent.";
        }
      
    }
}
