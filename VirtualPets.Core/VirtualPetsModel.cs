using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VirtualPets.Core
{
    //CyberPet attributes
    public class VirtualPetsModel
    {
        //Baseline of Moods in the Constructor where 0 is the highest level and 10 is the lowest
        //Here all the Pet is at the highest Mood level
        public int healthyEmotionLevel = 100;
        public int happyEmotionLevel = 100;
        public int notHungryEmotionLevel = 100;
        public int notBoredEmotionLevel = 100;
        public int noEmotionLevel = 0;

        /// Create different Mood levels for a Pet with scores
        public enum PetMood
        {
            Okay,
            Unhealthy, //Emotion is Healthy level 100, 0 is Unhealthy
            Unhappy, //Emotion is Happy level 100, 0 is Unhappy
            Hungry, //Emotion is notHungry level 100, 0 is Hungry
            Bored, //Emotion is NotBored level 100, 0 is Bored
            Death //Pet is killed off
        }

        public enum GiveAction
        {
            Medicine,
            Love,
            Feed,
            Play,
            NoAction
        }

        //Random method 
        public Random random = new Random();

        public void 
            UpdateEmotionLevels()
        {
            //For each emotion calculate a gradual random decrease in emotion
            //where 100 is the max value and 0 is the minimum
            int healthEmotionReduction = random.Next(0, 5);
            healthyEmotionLevel = healthyEmotionLevel - healthEmotionReduction;
            if (healthyEmotionLevel < 0)
            {
                healthyEmotionLevel = 0;
            }

            int happyEmotionReduction = random.Next(0, 5);
            happyEmotionLevel = happyEmotionLevel - happyEmotionReduction;
            if (happyEmotionLevel < 0)
            {
                happyEmotionLevel = 0;
            }

            int hungryEmotionReduction = random.Next(0, 5);
            notHungryEmotionLevel = notHungryEmotionLevel - hungryEmotionReduction;
            if (notHungryEmotionLevel < 0)
            {
                notHungryEmotionLevel = 0;
            }

            int boredEmotionReduction = random.Next(0, 5);
            notBoredEmotionLevel = notBoredEmotionLevel - boredEmotionReduction;
            if (notBoredEmotionLevel < 0)
            {
                notBoredEmotionLevel = 0;
            }
        }

        ////Calculate the random emotion
        ////Present the Pet with the highest Emotion number to the 
        ////the overall Pet mood
        public PetMood CalculateOverallMood()
        {
            //Happy vs Not Hungry levels, if happylevel< notHungryLevel, Mood=Unhappy
            //in this method create enum happyVsnothungry
            //create happyvshealthy int emotional level


            PetMood happyVsNotHungryMoodOutcome;
            int happyVsNotHungryEmotionLevel;

            if (happyEmotionLevel < notHungryEmotionLevel)
            {
                happyVsNotHungryMoodOutcome = PetMood.Unhappy;
                happyVsNotHungryEmotionLevel = happyEmotionLevel;
            }
            else
            {
                happyVsNotHungryMoodOutcome = PetMood.Hungry;
                happyVsNotHungryEmotionLevel = notHungryEmotionLevel;
            }

            //NotBored vs Healthy levels, if notBoredlevel < healthlylevel, Mood = Bored
            // in this method create enum notBoredvs healthy
            //in this method create int notboredvshealthy emotional level

            PetMood notBoredvsHealthyEmotionOutcome;
            int notBoredVsHealthyEmotionLevel;
            if (notBoredEmotionLevel < healthyEmotionLevel)
            {
                notBoredvsHealthyEmotionOutcome = PetMood.Bored;
                notBoredVsHealthyEmotionLevel = notBoredEmotionLevel;
            }
            else
            {
                notBoredvsHealthyEmotionOutcome = PetMood.Unhealthy;
                notBoredVsHealthyEmotionLevel = healthyEmotionLevel;
            }

            //int happyVsContentLowestLevel = 0;
            //NotBored or healthy e+-motional level <than happy/hungry level mood == bored or unhealthy
            //in this method create enum overall emotion
            PetMood overallEmotionOutcome;

            if (notBoredVsHealthyEmotionLevel < happyVsNotHungryEmotionLevel)
            {

                overallEmotionOutcome = notBoredvsHealthyEmotionOutcome;
            }
            else
            {
                overallEmotionOutcome = happyVsNotHungryMoodOutcome;
            }

            if (notBoredVsHealthyEmotionLevel <= 0 || happyVsNotHungryEmotionLevel <= 0)
            {
                overallEmotionOutcome = PetMood.Death;
            }

            return overallEmotionOutcome;
        }

        public PetMood petMood;
        public PetMood GetMood()
        {
            return petMood;
        }

        public void PetInteraction(GiveAction action)
        {
            switch (action)
            {
                case GiveAction.Feed:
                    notHungryEmotionLevel = 100;
                    break;
                case GiveAction.Love:
                    happyEmotionLevel = 100;
                    break;

                case GiveAction.Medicine:
                    healthyEmotionLevel = 100;
                    break;

                case GiveAction.Play:
                    notBoredEmotionLevel = 100;
                    break;
                case GiveAction.NoAction:
                    noEmotionLevel = 0;
                    break;
            }
        }

        public PetMood ResetPetEmotions()
        {
            PetMood resetPetMood;
            healthyEmotionLevel = 100;
            happyEmotionLevel = 100;
            notHungryEmotionLevel = 100;
            notBoredEmotionLevel = 100;
            resetPetMood = PetMood.Okay;
            return resetPetMood;
        }
    }
}
