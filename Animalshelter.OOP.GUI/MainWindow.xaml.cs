using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animalshelter.OOP.GUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Fishsprogram programfish = new Fishsprogram();
        Amphibiansprogram programamphibian = new Amphibiansprogram();
        Mammalprogram programmammal = new Mammalprogram();
        ShelterAnimals mammalShelter = new ShelterAnimals();
        ShelterAnimals amphibianShelter = new ShelterAnimals();
        ShelterAnimals fishShelter = new ShelterAnimals();  
        public string nameNewAnimal { get; set; } 
        public string species { get; set; }
        public string ageNewAnimal { get; set; }
        public ShelterAnimals currentshelter;

        public MainWindow()
        {
            InitializeComponent();
            Mammalprogram.CreateExistingMammal();
            Amphibiansprogram.CreateExistingAmphibians();
            Fishsprogram.CreateExistingFishs();
        }

        public void shelters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string userChoose = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;
            switch (userChoose)
            {
                case "Amphibianshelter":
                    amphibianShelter = currentshelter;
                    currentshelter.ShowAllAnimals(animalList);
                    break;
                case "Fishshelter":
                    fishShelter = currentshelter;
                    currentshelter.ShowAllAnimals(animalList);
                    break;
                case "Mammalshelter":
                    mammalShelter = currentshelter;
                    currentshelter.ShowAllAnimals(animalList);
                    break;
            }
        }

        public void animalList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        public void adopt_Click(object sender, RoutedEventArgs e)
        {
            Animal adoptAnimal = sender as Animal;
            string adoptedAnimal = adoptAnimal.ToString();
            currentshelter.AdoptAnimal(adoptedAnimal); 
        }

        public void add_Click(object sender, RoutedEventArgs e)
        {
            nameNewAnimal = enterName.Text.Trim();
            species = enterSpecies.Text.Trim();
            ageNewAnimal = enterAge.Text.Trim();
            int AgeNewAnimal = int.Parse(ageNewAnimal);
            Animal newAnimal = new Animal(nameNewAnimal, AgeNewAnimal, species);
            currentshelter.AddAnimal(newAnimal);
        }

        public void greet_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(currentshelter.GreetAnimal(species), "Greeting animal", MessageBoxButton.OK, MessageBoxImage.Information); 
        }
    }
}
