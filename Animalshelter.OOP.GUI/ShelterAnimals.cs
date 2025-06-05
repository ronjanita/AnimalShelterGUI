using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Animalshelter.OOP.GUI
{
    public class ShelterAnimals
    {
        public ObservableCollection<Animal> animalsInShelter = new ObservableCollection<Animal>();

        public void AddAnimal(Animal animals)   //fügt ein tier zu liste hinzu
        {
            animalsInShelter.Add(animals);
        }
        public void AdoptAnimal(Animal adoptAnimal) //entfernt ein tier anhand des namens aus der liste
        {
            animalsInShelter.Remove(adoptAnimal);
        }

        public void ShowAllAnimals(DataGrid datagrid)
        {
                datagrid.ItemsSource = animalsInShelter;
        }
        
        public string GreetAnimal(string searchingSpecies)
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
               return foundAnimals.MakeSound();
            }
            return null;
        }
    }
}
