using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter.OOP.GUI
{
    internal class Fishsprogram
    {
            static public ShelterAnimals fishShelter = new ShelterAnimals();
            public static void CreateExistingFishs()
            {
                Whaleshark newWhaleshark = new Whaleshark("kathi", 21, "whaleshark");
                Tigershark newTigershark = new Tigershark("lilly", 4, "tigershark");
                Stingray newStingray = new Stingray("ralph", 9, "stingray");
                Toadfish newToadfish = new Toadfish("paul", 1, "toadfish");

                fishShelter.AddAnimal(newWhaleshark);
                fishShelter.AddAnimal(newTigershark);
                fishShelter.AddAnimal(newStingray);
                fishShelter.AddAnimal(newToadfish);
            }

            //static void EnterNewFish()
            //{
            //    Console.WriteLine("Please enter the species of the new animal:");
            //    string species = Console.ReadLine().ToLower();
            //    Console.WriteLine("Please enter the name of the animal:");
            //    string nameNewAnimal = Console.ReadLine().ToLower();
            //    Console.WriteLine("Please enter the age of the animal:");
            //    int ageNewAnimal = int.Parse(Console.ReadLine());   //int parse macht string in int
            //    switch (species)
            //    {
            //        case "whaleshark":
            //            Whaleshark newWhalesharkToAdd = new Whaleshark(nameNewAnimal, ageNewAnimal, species);
            //            fishShelter.AddAnimal(newWhalesharkToAdd);
            //            break;
            //        case "lion":
            //            Tigershark newTigersharkToAdd = new Tigershark(nameNewAnimal, ageNewAnimal, species);
            //            fishShelter.AddAnimal(newTigersharkToAdd);
            //            break;
            //        case "okapi":
            //            Stingray newStingrayToAdd = new Stingray(nameNewAnimal, ageNewAnimal, species);
            //            fishShelter.AddAnimal(newStingrayToAdd);
            //            break;
            //        case "cat":
            //            Toadfish newToadfishToAdd = new Toadfish(nameNewAnimal, ageNewAnimal, species);
            //            fishShelter.AddAnimal(newToadfishToAdd);
            //            break;
            //        default:
            //            Animal newAnimal = new Animal(nameNewAnimal, ageNewAnimal, species);
            //            fishShelter.AddAnimal(newAnimal);
            //            break;
            //    }
            //}
            //static void AdoptNewFish()
            //{
            //    Console.WriteLine("Please enter the name of the animal you want to adopt:");
            //    string adoptedFishName = Console.ReadLine().ToLower();
            //    fishShelter.AdoptAnimal(adoptedFishName);
            //}

            //public void GreetNewFish()
            //{
            //    Console.WriteLine("enter the name of the species you want to greet:");
            //    string fishGreet = Console.ReadLine().ToLower();
            //    fishShelter.GreetAnimal(fishGreet);
            //}
            //public void RunGameFish()
            //{
            //    //CreateExistingFishs();
            //    Console.WriteLine("Chose between: \n - add a new animal to the shelter(1) \n - adopt an animal from the shelter(2) \n - show all animals(3) \n - greet animal(4)");
            //    string selection = Console.ReadLine().ToLower();

            //    switch (selection)
            //    {
            //        case "1":
            //            EnterNewFish();
            //            break;
            //        case "2":
            //            AdoptNewFish();
            //            break;
            //        case "3":
            //            fishShelter.ShowAllAnimals();
            //            break;
            //        case "4":
            //            Fishsprogram fishprogram = new Fishsprogram();
            //            fishprogram.GreetNewFish();
            //            break;
            //    }
            //}
        }
 
}
