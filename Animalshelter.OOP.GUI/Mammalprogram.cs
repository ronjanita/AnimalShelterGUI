using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalshelter.OOP.GUI
{
    internal class Mammalprogram
    {
        static public ShelterAnimals mammalShelter = new ShelterAnimals();
        public static void CreateExistingMammal()
        {
            Dog newDog = new Dog("leo", 1, "dog");
            //Console.WriteLine(newDog);
            Lion newLion = new Lion("rocky", 14, "lion");
            //Console.WriteLine(newLion);
            Okapi newOkapi = new Okapi("rudolf mc donald", 8, "okapi");
            //Console.WriteLine(newOkapi);
            Cat newCat = new Cat("sissi", 12, "cat");
            //Console.WriteLine(newCat);
            
            mammalShelter.AddAnimal(newDog);
            mammalShelter.AddAnimal(newLion);
            mammalShelter.AddAnimal(newOkapi);
            mammalShelter.AddAnimal(newCat);
        }

        //static void EnterNewMammal()
        //{
        //    Console.WriteLine("Please enter the species of the new animal:");
        //    string species = Console.ReadLine().ToLower();
        //    Console.WriteLine("Please enter the name of the animal:");
        //    string nameNewAnimal = Console.ReadLine().ToLower();
        //    Console.WriteLine("Please enter the age of the animal:");
        //    int ageNewAnimal = int.Parse(Console.ReadLine());   //int parse macht string in int
        //    switch (species)
        //    {
        //        case "dog":
        //            Dog newDogToAdd = new Dog(nameNewAnimal, ageNewAnimal, species);
        //            mammalShelter.AddAnimal(newDogToAdd);
        //            break;
        //        case "lion":
        //            Lion newLionToAdd = new Lion(nameNewAnimal, ageNewAnimal, species);
        //            mammalShelter.AddAnimal(newLionToAdd);
        //            break;
        //        case "okapi":
        //            Okapi newOkapiToAdd = new Okapi(nameNewAnimal, ageNewAnimal, species);
        //            mammalShelter.AddAnimal(newOkapiToAdd);
        //            break;
        //        case "cat":
        //            Cat newCatToAdd = new Cat(nameNewAnimal, ageNewAnimal, species);
        //            mammalShelter.AddAnimal(newCatToAdd);
        //            break;
        //        default:
        //            Animal newAnimal = new Animal(nameNewAnimal, ageNewAnimal, species);
        //            mammalShelter.AddAnimal(newAnimal);
        //            break;
        //    }
        //}
        //static void AdoptNewMammal()
        //{
        //    Console.WriteLine("Please enter the name of the animal you want to adopt:");
        //    string adoptedMammalName = Console.ReadLine().ToLower();
        //    mammalShelter.AdoptAnimal(adoptedMammalName);
        //}

        //public void GreetNewMammal()
        //{
        //    Console.WriteLine("enter the name of the species you want to greet:");
        //    string mammalGreet = Console.ReadLine().ToLower();
        //    mammalShelter.GreetAnimal(mammalGreet);
        //}
        //public void RunGameMammal()
        //{
        //    /*CreateExistingMammal();*/ //this call doubles the entries
        //    Console.WriteLine("Chose between: \n - add a new animal to the shelter(1) \n - adopt an animal from the shelter(2) \n - show all animals(3) \n - greet animal(4)");
        //    string selection = Console.ReadLine().ToLower();

        //    switch (selection)
        //    {
        //        case "1":
        //            EnterNewMammal();
        //            break;
        //        case "2":
        //            AdoptNewMammal();
        //            break;
        //        case "3":
        //            mammalShelter.ShowAllAnimals();
        //            break;
        //        case "4":
        //            Mammalprogram mammalprogram = new Mammalprogram();
        //            mammalprogram.GreetNewMammal();
        //            break;
        //    }
        //}
    }
}
