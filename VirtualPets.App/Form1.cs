 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualPets.Core;

namespace VirtualPets.App
{
    public partial class Form1 : Form
    {
        VirtualPetsModel model = new VirtualPetsModel();
        public Form1()
        {
            InitializeComponent();
        }
        //Title
        private void label2_Click(object sender, EventArgs e)
        {
        }
        //What do you want to do with Pet label
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void PetGame_Paint(object sender, PaintEventArgs e)
        {
        }
        //Images
        // image 0 happy
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxMood.Image = imageListMoods.Images[0];
        }
        //image 3 hungry - tears
        private void btnFeed_Click(object sender, EventArgs e)
        {
            model.PetInteraction(VirtualPetsModel.GiveAction.Feed);
           // pictureBoxMood.Image = imageListMoods.Images[8];
        }
        //image 2 - Play inquisitive
        private void btnPlay_Click(object sender, EventArgs e)
        {
            model.PetInteraction(VirtualPetsModel.GiveAction.Play);
            //pictureBoxMood.Image = imageListMoods.Images[7];
        }


        //unhappy image 4
        private void btnGiveLove_Click(object sender, EventArgs e)
        {
            model.PetInteraction(VirtualPetsModel.GiveAction.Love);
            //pictureBoxMood.Image = imageListMoods.Images[6];
        }
        //sick image 1
        private void btnMedicine_Click(object sender, EventArgs e)
        {
            model.PetInteraction(VirtualPetsModel.GiveAction.Medicine);
            //pictureBoxMood.Image = imageListMoods.Images[5];
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            model.ResetPetEmotions();
            //pictureBoxMood.Image = imageListMoods.Images[0];
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
                    labelMood.Text = "I am bored!";
                    break;

                case VirtualPetsModel.PetMood.Hungry:
                    pictureBoxMood.Image = imageListMoods.Images[3];
                    labelMood.Text = "I am Hungry!";
                    break;

                case VirtualPetsModel.PetMood.Unhappy:
                    pictureBoxMood.Image = imageListMoods.Images[4];
                    labelMood.Text = "I am Sad!";
                    break;

                case VirtualPetsModel.PetMood.Unhealthy:
                    pictureBoxMood.Image = imageListMoods.Images[1];
                    labelMood.Text = "I am Sick!";
                    break;

                case VirtualPetsModel.PetMood.Okay:
                    pictureBoxMood.Image = imageListMoods.Images[0];
                    break;
                case VirtualPetsModel.PetMood.Death:
                    pictureBoxMood.Image = imageListMoods.Images[9];
                    labelMood.Text = "You Killed me!";
                    break;
            }

        }

        
    }
}
