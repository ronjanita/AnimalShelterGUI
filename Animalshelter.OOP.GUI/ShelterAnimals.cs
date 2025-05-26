using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Animalshelter.OOP.GUI
{
    public class ShelterAnimals
    {
        public List<Animal> animalsInShelter = new List<Animal>();

        public void AddAnimal(Animal animals)   //fügt ein tier zu liste hinzu
        {
            animalsInShelter.Add(animals);
        }
        public void AdoptAnimal(string searchingName) //entfernt ein tier anhand des namens aus der liste
        {
            Animal foundAnimals = null;
            foreach (Animal animalsToCheck in animalsInShelter)  // rückwerts durch lsite itieren?
            {
                if (animalsToCheck.Name == searchingName)
                {
                    foundAnimals = animalsToCheck;
                }
            }
            if (foundAnimals != null)
            {
                animalsInShelter.Remove(foundAnimals);
            }
            //Animal searchedAnimal = animalsInShelter.FirstOrDefault(animalToCheck => animalToCheck.Name == searchingName);
            //animalsInShelter.Remove(searchedAnimal);
        }

        public void ShowAllAnimals(DataGrid datagrid)
        {
            foreach (Animal animal in animalsInShelter)
            {
                //Console.WriteLine($"here are all animals currently in the shelter: {animal}");
                datagrid.ItemsSource = animalsInShelter;
            }
        }
        
        public void GreetAnimal(string searchingSpecies)
        {
            Animal foundAnimals = null;
            foreach (Animal animalToCheck in animalsInShelter)
            {
                if (animalToCheck.Species == searchingSpecies)
                {
                    foundAnimals = animalToCheck;
                }
            }
            if (foundAnimals != null)
            {
                foundAnimals.MakeSound();
            }
        }
    }
}
