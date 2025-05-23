using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter.OOP.GUI
{
    internal class Stingray : Animal
    {
        public Stingray(string name, int age, string species) : base(name, age, species) { }
        public override void MakeSound()
        {
            Console.WriteLine("clickclick");
        }
        public override string ToString()
        {
            return $"{Species},{Name},{Age}years old.";
        }
    }

}
