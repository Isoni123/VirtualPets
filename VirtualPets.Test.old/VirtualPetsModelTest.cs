using System;
using NUnit.Framework;
using VirtualPets.Core;

namespace VirtualPets.Test
{
    public class VirtualPetsModelTest
    {
        [TestCase(100,100,100,95)]
        public void Given_a_virtual_pet_WHEN_the_game_starts_randomly_load_it_with_a_different_emotion_attribute(int happyEmotionLevel, int notHungryEmotionLevel,int notBoredEmotionLevel, int healthyEmotionLevel)
        {
           // //PREPARE
           // //Create the different emotions for the Pet
           // //Randomy select the dominant emotion

           // VirtualPetsModel virtualPetsModel = new VirtualPetsModel();

           // //ACT
           // //Assign a number level between 1-10 to each emotion,
           // //where 1 is the best state and 10 the worst
           // // select an emotion

           // Enum selectedEmotion = virtualPetsModel.CalculateOverallMood();

           // selectedEmotion = virtualPetsModel.GetMood();
           //// int emotionalLevel = virtualPetsModel.GetEmotionalLevel();
            
           // //ASSERT
           // Assert.AreNotSame(selectedEmotion,healthyEmotionLevel);
        }
    }
}
