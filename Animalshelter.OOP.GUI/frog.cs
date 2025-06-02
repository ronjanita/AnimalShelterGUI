using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animalshelter.OOP.GUI
{
    internal class Frog:Animal
    {
        public Frog(string name, int age, string species) : base(name, age, species) { }
        public override string MakeSound()
        {
            return "quackquack";
        }
        public override string ToString()
        {
            return $"{Species},{Name},{Age}years old.";
        }
    }
}
