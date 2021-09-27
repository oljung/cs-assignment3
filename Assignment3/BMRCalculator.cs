using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /// <summary>
    /// This class handles caltulations for BMR and calories needed to maintain, gain or lose
    /// weight. Methods for setting value does not manipulate values according to units,
    /// but rather handles all inputs as entered in correct units (cm and kg). Unit conversion
    /// is done, if needed, by client class
    /// </summary>
    class BMRCalculator
    {
        private int activityLevel;
        private int age;
        private double height;
        private double weight;
        private bool isFemale;

        #region setters and getters
        /*
         * All setter methods with number works the same way, checks if value is 
         * greater than 0 and then sets value to instance variable, except for 
         * activitylevel where 0 is accepted value.
         */
        public void SetActivityLevel(int value)
        {
            if(value >= 0)
            {
                activityLevel = value;
            }
        }

        public void SetAge(int value)
        {
            if(value > 0)
            {
                age = value;
            }
        }

        public void SetHeight(double value)
        {
            if(value > 0)
            {
                height = value;
            }
        }

        public void SetWeight(double value)
        {
            if (value > 0)
            {
                weight = value;
            }
        }
        //Sets gender booloean "isFemale" to true or false
        public void SetGender(bool value)
        {
            isFemale = value;
        }

        public int GetAge()
        {
            return age;
        }

        public double GetHeight()
        {
            return height;
        }

        public double GetWeight()
        {
            return weight;
        }

        private double GetActivityLevelFactor()//determines the factor based on activity level
        {//this method assumes that client class sets a default activity level
            double activityLevelfactor = 0;
            switch (activityLevel)//switch statement is based on instance variable for activity level
            {
                //Cases correspond to table of different activity levels
                case 0:
                    activityLevelfactor = 1.2f;
                    break;
                case 1:
                    activityLevelfactor = 1.375f;
                    break;
                case 2:
                    activityLevelfactor = 1.550f;
                    break;
                case 3:
                    activityLevelfactor = 1.725f;
                    break;
                case 4:
                    activityLevelfactor = 1.9f;
                    break;
            }
            return activityLevelfactor;//returns the activity level factor corresponding to activiy level
        }
        #endregion

        public double CalculateBMR()//Calculates the BMR based on height, weight and age
        {//formula for BMR, parenthesis for clarity
            double bmr = weight * 10 + 6.25f * height - (age * 5);
            double output;
            if (isFemale)//If gender is female
            {
                output = bmr - 161;//women need less, I suppose
            }
            else//gender is male
            {
                output = bmr + 5;//and men can eat an extra cookie
            }
            return output;
        }

        public double MaintainWeightCalories()//determines calories needed to keep current weight
        {//uses CalculateBMR() to caltulate BMR value
            double bmr = CalculateBMR();//calculates BMR
            //multiplies by activityfactor
            double output = bmr * GetActivityLevelFactor();//method returns a double value
            return output;//returns calories needed to maintain weight
        }
        /// <summary>
        /// This method takes the weight the person wishes to lose/gain and subtracts/adds
        /// from/to the amount of calories needed to maintain weight. It uses the 
        /// MaintainWeightCalories() method and uses returned value in caltulation
        /// </summary>
        /// <param name="weight">weight in grams person wishes to lose/gain</param>
        /// <param name="lose">If true, lose weight. False, gain weight</param>
        /// <returns>amount of calories needed for loss/gain</returns>
        public double LoseOrGainWeightCalories(double weight, bool lose)
        {
            //caltulates the calories to maintain weight
            double amountToMaintain = MaintainWeightCalories();
            double output;
            if (lose)//if bool lose argument is true
            {
                output = amountToMaintain - weight;//less calories to lose weight
            }
            else//if bool lose argument is false
            {
                output = amountToMaintain + weight;//more calories to gain weight
            }
            return output;//calories needed to lose/gain weight
        }

    }
}
