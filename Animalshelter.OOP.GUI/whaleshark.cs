using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter.OOP.GUI
{
    internal class Whaleshark:Animal
    {
        public Whaleshark(string name, int age, string species) : base(name, age, species) { }
        public override string MakeSound()
        {
            return "gluckgluck";
        }
        public override string ToString()
        {
            return $"{Species},{Name},{Age}years old.";
        }
    }
}
