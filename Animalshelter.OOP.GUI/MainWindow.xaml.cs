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
        public MainWindow()
        {
            
            InitializeComponent();
            bool playAgain = true;
            Mammalprogram programmammal = new Mammalprogram();
            Mammalprogram.CreateExistingMammal();
            Amphibiansprogram programamphibian = new Amphibiansprogram();
            Amphibiansprogram.CreateExistingAmphibians();
            Fishsprogram programfish = new Fishsprogram();
            Fishsprogram.CreateExistingFishs();
            while (playAgain)
            {
                Console.WriteLine("Welcome to the Animal shelter, choose between the three animalshelters to continue. \n -Mammalshelter (1) \n -Amphibianshelter(2) \n -Fishshelter(3)");
                string userChoose = Console.ReadLine();
                switch (userChoose)
                {
                    case "1":
                        programmammal.RunGameMammal();
                        break;
                    case "2":
                        programamphibian.RunGameAmphibian();
                        break;
                    case "3":
                        programfish.RunGameFish();
                        break;
                }
                Console.WriteLine("Do you want to end this program? y/n");
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    playAgain = false;
                }
            }
        }
    }
}
