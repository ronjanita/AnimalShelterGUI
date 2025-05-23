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
        ShelterAmphibians shelterAmphibian = new ShelterAmphibians();
        ShelterFishs shelterFishs = new ShelterFishs();
        ShelterMammal shelterMammal = new ShelterMammal();
        public string nameNewAnimal { get; set; }
        public string species { get; set; }
        public string ageNewAnimal { get; set; }

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
                    programamphibian.RunGameAmphibian();
                    break;
                case "Fishshelter":
                    programfish.RunGameFish();
                    break;
                case "Mammalshelter":
                    programmammal.RunGameMammal();
                    break;
            }
        }

        public void animalList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string userChoose = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;
            switch (userChoose)
            {
                case "Amphibianshelter":
                    shelterAmphibian.ShowAllAnimals();
                    break;
                case "Fishshelter":
                    shelterFishs.ShowAllAnimals();
                    break;
                case "Mammalshelter":
                    shelterMammal.ShowAllAnimals();
                    break;
            }
        }

        public void adopt_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void add_Click(object sender, RoutedEventArgs e)
        {
            nameNewAnimal = enterName.Text.Trim();
            species = enterSpecies.Text.Trim();
            ageNewAnimal = enterAge.Text.Trim();
            int AgeNewAnimal = int.Parse(ageNewAnimal);
            
            Animal newAnimal = new Animal(nameNewAnimal, AgeNewAnimal, species);
            ComboBox comboBox = sender as ComboBox;
            string userChoose = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;
            switch (userChoose)
            {
                case "Amphibianshelter":
                    shelterAmphibian.AddAnimal(newAnimal);
                    break;
                case "Fishshelter":
                    shelterFishs.AddAnimal(newAnimal);
                    break;
                case "Mammalshelter":
                    shelterMammal.AddAnimal(newAnimal);
                    break;
            }
        }
    }
}
