using System;
using NUnit.Framework;
using VirtualPets.Core;

namespace VirtualPets.Test
{
    public class VirtualPetsModelTest
    {
        //Check the algorithm works by ensuring the correct PetMood is displayed
        [TestCase(100, 100, 100, 95, VirtualPetsModel.PetMood.Unhealthy)]
        [TestCase(60, 95, 95, 95, VirtualPetsModel.PetMood.Unhappy)]
        public void
            GIVEN_a_virtual_pet_WHEN_the_game_starts_load_it_with_a_different_emotion_attribute_AND_ensure_lowest_number_wins(
                int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
                VirtualPetsModel.PetMood expectedPetMood)
        {
            //PREPARE
            //Create the different emotions for the Pet
            //Randomly select the dominant emotion
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;

            //ACT
            //Assign a number level between 1-10 to each emotion,
            //where 1 is the best state and 10 the worst
            // select an emotion
            VirtualPetsModel.PetMood actualMood = virtualPetsModel.CalculateOverallMood();
            virtualPetsModel.GetMood();
            //ASSERT
            Assert.AreEqual(expectedPetMood, actualMood);
            Assert.AreEqual(expectedPetMood, actualMood);
        }

        [TestCase(100, 100, 90, 100, VirtualPetsModel.PetMood.Hungry)]
        public void GIVEN_a_virtual_pet_WHEN_the_game_starts_load_it_with_a_different_emotion_attribute_AND_ensure_that_right_mood_is_returned(
                int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
                VirtualPetsModel.PetMood expectedPetMood)
        {
            //PREPARE
            //create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;

            //ACT
            VirtualPetsModel.PetMood actualMood = virtualPetsModel.CalculateOverallMood();
            virtualPetsModel.GetMood();

            //ASSERT
            Assert.AreNotSame(expectedPetMood, actualMood);
        }

        [TestCase(100, 90, 90, 100, VirtualPetsModel.PetMood.Hungry)]
        //What happens if the same number is returned for two moods it will take the last value of the if conditions
        public void GIVEN_a_virtual_pet_WHEN_the_game_starts_load_it_with_same_emotion_values_select_the_last_value(
            int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel, VirtualPetsModel.PetMood expectedPetMood
        )
        {
            //PREPARE
            //create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;

            //ACT
            VirtualPetsModel.PetMood result = virtualPetsModel.CalculateOverallMood();
            virtualPetsModel.GetMood();

            //ASSERT
            Assert.AreEqual(expectedPetMood, result);
        }


        [TestCase(45, 13, 11,
            15, VirtualPetsModel.PetMood.Bored)]
        public void
            GIVEN_a_virtual_pet_WHEN_the_game_starts_load_game_with_different_emotion_levels_AND_select_the_lowest_emotion_for_the_pet(
                int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
                VirtualPetsModel.PetMood expectedPetMood)
        {
            //PREPARE
            //create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;
            //ACT
            VirtualPetsModel.PetMood result = virtualPetsModel.CalculateOverallMood();
            virtualPetsModel.GetMood();
            //ASSERT
            Assert.AreEqual(expectedPetMood, result);
        }


        /// <summary>

        //Testing resetting the Bored emotion
        [TestCase(45, 13, 11,
            15, VirtualPetsModel.PetMood.Bored)]
        public void
            GIVEN_a_virtual_pet_WHEN_the_game_starts_AND_mood_set_have_different_methods_change_overall_mood_Play(
                int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
                VirtualPetsModel.PetMood expectedPetMood)
        {
            ////PREPARE
            ////create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;
            ////ACT
            //TestCase 1 worked went from bored to hungry
            VirtualPetsModel.PetMood mood1 = virtualPetsModel.CalculateOverallMood();//bored
            virtualPetsModel.GetMood();
            virtualPetsModel.PetInteraction(VirtualPetsModel.GiveAction.Play); // now notBored
            VirtualPetsModel.PetMood mood2 = virtualPetsModel.CalculateOverallMood();//hungry
            virtualPetsModel.GetMood();
            //ASSERT
            Assert.AreNotEqual(mood2, expectedPetMood);
        }

        //Testing the hungry emotion and changed to happy
        [TestCase(40, 30, 55,
           60, VirtualPetsModel.PetMood.Hungry)]
        public void
           GIVEN_a_virtual_pet_WHEN_the_game_starts_AND_mood_set_have_different_methods_change_overall_mood_Feed(
               int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
               VirtualPetsModel.PetMood expectedPetMood)
        {
            ////PREPARE
            ////create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;
            //ACT
            //TestCase 2
            VirtualPetsModel.PetMood mood3 = virtualPetsModel.CalculateOverallMood();//hungry
            virtualPetsModel.GetMood();
            virtualPetsModel.PetInteraction(VirtualPetsModel.GiveAction.Feed); // now not hungry
            VirtualPetsModel.PetMood mood4 = virtualPetsModel.CalculateOverallMood();//unhappy
            virtualPetsModel.GetMood();
            //ASSERT
            Assert.AreNotEqual(mood4, expectedPetMood);
        }


        //Testing the happy emotion
        [TestCase(20, 30, 40, 50, VirtualPetsModel.PetMood.Unhappy)]
        public void
            GIVEN_a_virtual_pet_WHEN_the_game_starts_AND_mood_set_have_different_methods_change_overall_mood_Love(
                int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
                VirtualPetsModel.PetMood expectedPetMood)
        {
            ////PREPARE
            ////create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;
            //ACT
            //TestCase 3
            VirtualPetsModel.PetMood mood5 = virtualPetsModel.CalculateOverallMood();//unhappy
            virtualPetsModel.GetMood();
            virtualPetsModel.PetInteraction(VirtualPetsModel.GiveAction.Love); // now not unhappy
            VirtualPetsModel.PetMood mood6 = virtualPetsModel.CalculateOverallMood();//hungry
            virtualPetsModel.GetMood();
            //ASSERT
            Assert.AreNotEqual(mood6, expectedPetMood);
        }


        //Testing the Healthy emotion
        [TestCase(20, 30, 50,
              15, VirtualPetsModel.PetMood.Unhealthy)]
        public void
            GIVEN_a_virtual_pet_WHEN_the_game_starts_AND_mood_set_have_different_methods_change_overall_mood_Medicine(
                int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
                VirtualPetsModel.PetMood expectedPetMood)
        {
            ////PREPARE
            ////create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;

            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;
            //ACT
            //TestCase 4
            VirtualPetsModel.PetMood mood7 = virtualPetsModel.CalculateOverallMood();//unhealthy
            virtualPetsModel.GetMood();
            virtualPetsModel.PetInteraction(VirtualPetsModel.GiveAction.Medicine); // now not unhealthy
            VirtualPetsModel.PetMood mood8 = virtualPetsModel.CalculateOverallMood();//hungry
            virtualPetsModel.GetMood();
            //ASSERT
            Assert.AreNotEqual(mood8, expectedPetMood);
        }


        //Testing the reset emotion
        [TestCase(20, 30, 50,
              15, VirtualPetsModel.PetMood.Unhealthy)]
        public void GIVEN_a_virtual_pet_WHEN_the_game_starts_AND_mood_set_have_reset_method_to_push_the_levels_back_to_100(
                    int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
                    VirtualPetsModel.PetMood expectedPetMood)
        {
            //PREPARE
            //create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;
            ///ACT
            VirtualPetsModel.PetMood mood1 = virtualPetsModel.CalculateOverallMood();//bored
            virtualPetsModel.GetMood();
            virtualPetsModel.ResetPetEmotions();
            happyEmotionLevel = virtualPetsModel.happyEmotionLevel;
            notBoredEmotionLevel = virtualPetsModel.notBoredEmotionLevel;
            notHungryEmotionLevel = virtualPetsModel.notHungryEmotionLevel;
            healthyEmotionLevel = virtualPetsModel.healthyEmotionLevel;
            VirtualPetsModel.PetMood mood9 = virtualPetsModel.GetMood();

            // ASSERT
            Assert.AreNotEqual(mood9, expectedPetMood);
        }

        //Testing the Healthy emotion
        [TestCase(20, 30, 50,
            15, VirtualPetsModel.PetMood.Unhealthy)]
        public void
            GIVEN_a_virtual_pet_WHEN_the_game_starts_Update_the_model_and_alter_the_emotional_levels(
                int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
                VirtualPetsModel.PetMood expectedPetMood)
        {
            ////PREPARE
            ////create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;

            //ACT
            //TestCase 4


            happyEmotionLevel = virtualPetsModel.happyEmotionLevel;
            notBoredEmotionLevel = virtualPetsModel.notBoredEmotionLevel;
            notHungryEmotionLevel = virtualPetsModel.notHungryEmotionLevel;
            healthyEmotionLevel = virtualPetsModel.healthyEmotionLevel;

            virtualPetsModel.UpdateEmotionLevels();
            VirtualPetsModel.PetMood mood10 = virtualPetsModel.CalculateOverallMood();//unhealthy
            virtualPetsModel.GetMood();

            //ASSERT
            Assert.AreEqual(mood10, expectedPetMood);
        }

        [TestCase(90, 90, 80,
            1, VirtualPetsModel.PetMood.Death)]
        public void
            GIVEN_a_virtual_pet_WHEN_the_game_starts_Update_the_model_and_reduce_health_emotional_level_to_death(
                int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
                VirtualPetsModel.PetMood expectedPetMood)
        {
            ////PREPARE
            ////create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;

            //ACT
            //TestCase 4
            virtualPetsModel.UpdateEmotionLevels();
            virtualPetsModel.UpdateEmotionLevels();

            VirtualPetsModel.PetMood mood10 = virtualPetsModel.CalculateOverallMood();
            virtualPetsModel.GetMood();

            //ASSERT
            Assert.AreEqual(mood10, expectedPetMood);
        }

        [TestCase(1, 90, 80,
            90, VirtualPetsModel.PetMood.Death)]
        public void
            GIVEN_a_virtual_pet_WHEN_the_game_starts_Update_the_model_and_reduce_happy_emotional_level_to_death(
                int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
                VirtualPetsModel.PetMood expectedPetMood)
        {
            ////PREPARE
            ////create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;

            //ACT
            //TestCase 4
            virtualPetsModel.UpdateEmotionLevels();
            virtualPetsModel.UpdateEmotionLevels();

            VirtualPetsModel.PetMood mood11 = virtualPetsModel.CalculateOverallMood();
            virtualPetsModel.GetMood();

            //ASSERT
            Assert.AreEqual(mood11, expectedPetMood);
        }

        [TestCase(90, 1, 80,
            90, VirtualPetsModel.PetMood.Death)]
        public void
            GIVEN_a_virtual_pet_WHEN_the_game_starts_Update_the_model_and_reduce_hungry_emotional_level_to_death(
                int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
                VirtualPetsModel.PetMood expectedPetMood)
        {
            ////PREPARE
            ////create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;

            //ACT
            //TestCase 4
            virtualPetsModel.UpdateEmotionLevels();
            virtualPetsModel.UpdateEmotionLevels();

            VirtualPetsModel.PetMood mood12 = virtualPetsModel.CalculateOverallMood();
            virtualPetsModel.GetMood();

            //ASSERT
            Assert.AreEqual(mood12, expectedPetMood);
        }


        [TestCase(90, 90, 1,
            90, VirtualPetsModel.PetMood.Death)]
        public void
            GIVEN_a_virtual_pet_WHEN_the_game_starts_Update_the_model_and_reduce_bored_emotional_level_to_death(
                int happyEmotionLevel, int notHungryEmotionLevel, int notBoredEmotionLevel, int healthyEmotionLevel,
                VirtualPetsModel.PetMood expectedPetMood)
        {
            ////PREPARE
            ////create a new instance of the VirtualPetsModel
            VirtualPetsModel virtualPetsModel = new VirtualPetsModel();
            virtualPetsModel.happyEmotionLevel = happyEmotionLevel;
            virtualPetsModel.notBoredEmotionLevel = notBoredEmotionLevel;
            virtualPetsModel.notHungryEmotionLevel = notHungryEmotionLevel;
            virtualPetsModel.healthyEmotionLevel = healthyEmotionLevel;

            //ACT
            //TestCase 4
            virtualPetsModel.UpdateEmotionLevels();
            virtualPetsModel.UpdateEmotionLevels();

            VirtualPetsModel.PetMood mood13 = virtualPetsModel.CalculateOverallMood();
            virtualPetsModel.GetMood();

            //ASSERT
            Assert.AreEqual(mood13, expectedPetMood);
        }

    }
}




