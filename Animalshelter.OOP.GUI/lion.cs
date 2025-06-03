using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter.OOP.GUI
{
    internal class Lion:Animal
    {
        public Lion(string name, int age, string species) : base(name, age, species) { }
        public override string MakeSound()
        {
            return "rawr";  
        }
    
    }
}
