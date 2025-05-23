using System;

namespace Animalshelter.OOP.GUI
{
    public class Animal
    {
        public string Name;
        public int Age;
        public string Species;
        public Animal(string name, int age, string species)
        {
            Name = name; 
            Age = age;
            Species = species;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
        public override string ToString()
        {
            return $"{Species},{Name},{Age}years old.";

        }
    }

}
