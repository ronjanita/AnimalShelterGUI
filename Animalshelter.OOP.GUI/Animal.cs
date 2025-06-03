using System;

namespace Animalshelter.OOP.GUI
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public Animal(string name, int age, string species)
        {
            Name = name; 
            Age = age;
            Species = species;
        }
        public virtual string MakeSound()
        {
            return "";
        }
      
    }

}
