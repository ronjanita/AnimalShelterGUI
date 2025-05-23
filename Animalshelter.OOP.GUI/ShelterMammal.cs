using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter.OOP.GUI
{
    public class ShelterMammal
    {
        public List<Animal> mammalsInShelter = new List<Animal>();
        
        public void AddAnimal(Animal mammal)   //fügt ein tier zu liste hinzu
        {
            mammalsInShelter.Add(mammal);
        }
        public void AdoptAnimal(string searchingName) //entfernt ein tier anhand des namens aus der liste
        {
            Animal foundMammal = null;
            foreach (Animal mammalToCheck in mammalsInShelter)  // rückwerts durch lsite itieren?
            {
                if (mammalToCheck.Name == searchingName)   
                {
                    foundMammal = mammalToCheck;
                }
            }
            if (foundMammal != null)
            {
                mammalsInShelter.Remove(foundMammal);
            }

            //Animal searchedAnimal = animalsInShelter.FirstOrDefault(animalToCheck => animalToCheck.Name == searchingName);
            //animalsInShelter.Remove(searchedAnimal);
        }
        public void ShowAllAnimals()
        {
            foreach(Animal animal in mammalsInShelter)
            {
                Console.WriteLine($"here are all animals currently in the shelter: {animal}");
            }
        } 
        
        public void GreetAnimal(string searchingSpecies)
        {
            Animal foundMammal = null;
            foreach(Animal animalToCheck in mammalsInShelter)
            {
                if (animalToCheck.Species == searchingSpecies)
                {
                    foundMammal = animalToCheck;
                }
            }
            if (foundMammal != null)
            {
                foundMammal.MakeSound();
            }
        }
    }
}
