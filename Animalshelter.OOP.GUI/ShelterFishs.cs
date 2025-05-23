using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter.OOP.GUI
{
    public class ShelterFishs
    {
        public List<Animal> fishsInShelter = new List<Animal>();

        public void AddAnimal(Animal fishs)   //fügt ein tier zu liste hinzu
        {
            fishsInShelter.Add(fishs);
        }
        public void AdoptAnimal(string searchingName) //entfernt ein tier anhand des namens aus der liste
        {
            Animal foundFishs = null;
            foreach (Animal fishsToCheck in fishsInShelter)  // rückwerts durch lsite itieren?
            {
                if (fishsToCheck.Name == searchingName)
                {
                    foundFishs = fishsToCheck;
                }
            }
            if (foundFishs != null)
            {
                fishsInShelter.Remove(foundFishs);
            }

            //Animal searchedAnimal = animalsInShelter.FirstOrDefault(animalToCheck => animalToCheck.Name == searchingName);
            //animalsInShelter.Remove(searchedAnimal);
        }
        public void ShowAllAnimals()
        {
            foreach (Animal animal in fishsInShelter)
            {
                Console.WriteLine($"here are all animals currently in the shelter: {animal}");
            }
        }

        public void GreetAnimal(string searchingSpecies)
        {
            Animal foundFishs = null;
            foreach (Animal animalToCheck in fishsInShelter)
            {
                if (animalToCheck.Species == searchingSpecies)
                {
                    foundFishs = animalToCheck;
                }
            }
            if (foundFishs != null)
            {
                foundFishs.MakeSound();
            }
        }
    }
}
