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
using VirtualPets.Core;

namespace VirtualPets.AppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VirtualPetsModel model = new VirtualPetsModel();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            model.ResetPetEmotions();
        }

        private void Feed_Click(object sender, RoutedEventArgs e)
        {
            model.PetInteraction(VirtualPetsModel.GiveAction.Feed);
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            model.PetInteraction(VirtualPetsModel.GiveAction.Play);
        }

        private void GiveLove_Click(object sender, RoutedEventArgs e)
        {
            model.PetInteraction(VirtualPetsModel.GiveAction.Love);
        }

        private void Medicine_OnClick(object sender, RoutedEventArgs e)
        {
            model.PetInteraction(VirtualPetsModel.GiveAction.Medicine);
        }

        private void timerUpdateMood_Tick(object sender, EventArgs e)
        {
            model.UpdateEmotionLevels();
            levelHappy.Value = model.happyEmotionLevel;
            levelHealthy.Value = model.healthyEmotionLevel;
            levelBored.Value = model.notBoredEmotionLevel;
            levelHungry.Value = model.notHungryEmotionLevel;


            var mood = model.CalculateOverallMood();
            switch (mood)
            {
                case VirtualPetsModel.PetMood.Bored:
                    pictureBoxMood.Image = imageListMoods.Images[2];
                    //labelMood.Text = "I am bored!";
                    break;

                case VirtualPetsModel.PetMood.Hungry:
                    pictureBoxMood.Image = imageListMoods.Images[3];
                    //labelMood.Text = "I am Hungry!";
                    break;

                case VirtualPetsModel.PetMood.Unhappy:
                    pictureBoxMood.Image = imageListMoods.Images[4];
                   // labelMood.Text = "I am Sad!";
                    break;

                case VirtualPetsModel.PetMood.Unhealthy:
                    pictureBoxMood.Image = imageListMoods.Images[1];
                   // labelMood.Text = "I am Sick!";
                    break;

                case VirtualPetsModel.PetMood.Okay:
                    pictureBoxMood.Image = imageListMoods.Images[0];
                    break;

                case VirtualPetsModel.PetMood.Death:
                    pictureBoxMood.Image = imageListMoods.Images[9];
                    //labelMood.Text = "You Killed me!";
                    break;
            }
        }
    }
}
