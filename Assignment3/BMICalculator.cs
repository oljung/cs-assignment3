using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{/// <summary>
/// This class servers as a server class string input data in instance variables and
/// caltulates BMI and normal weight. Setter methods and getter methods do not manipulate
/// data, client class is responibel for any necessary unitconversions. unit variable is
/// used to determine which formula to use for BMI calculation
/// </summary>
    class BMICalculator
    {
        private string name = "No Name";//Name of user
        private double height = 0;//User height, will be in correct type on assignemnt
        private double weight = 0;//User height, will be in correct type on assignemnt
        private UnitTypes unit; //Reference to the UnitTypes enum to determine units

        #region Getters and Setters
        public void SetName(string value)//Sets the value of name as input by the user is string is not empty
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }

        public string GetName()//Returns the value of name
        {
            return name;
        }

        public void SetHeight(double value)//Sets the value if height if inputvalue is 0 or higher
        {
            if (value >= 0)
            {
                height = value;
            }
        }

        public double GetHeight()//Returns value of height
        {
            return height;
        }

        public void SetWeight(double value)//Sets weight if inputvalue is 0 or higher
        {
            if (value >= 0)
            {
                weight = value;
            }
        }

        public double GetWeight()//Returns value of weight
        {
            return weight;
        }

        public void SetUnit(UnitTypes value)//Sets the unittype
        {
            unit = value;
        }

        public UnitTypes GetUnit()//Returns the unittype
        {
            return unit;
        }
        #endregion

        public double CalculateBMI()//Calculates the BMI using height and weight differently depending on unit
        {//Needs no parameters as it uses instance variables
         //If not done with the if statement, two separate methods would be needed.
            double result = 0;
            if (unit == UnitTypes.American)//If units are set to imperial
            {
                result = (weight * 703) / (height * height);//Formula for imperial units
            }
            else
            {
                result = weight / (height * height);//Metric version
            }
            return result;
        }

        public string BMIWeightCategory()//Determines BMI Category based on result from CalculateBMI()
        {
            double bmi = CalculateBMI();//Calculates BMI
            string stringOut = string.Empty;
            if (bmi < 18.5)//Compares bmi variable to BMI categories
            {//I know the {} are not necessary when you only have 1 statement, but i find it 
             //makes the code easier to follow
                stringOut = "Underweight";
            }
            //The suggestion in the help document does not work, as it starts with
            // bmi > 40 and else if bmi < 40, which is every other possible value,
            //hence everythin that is not class III will be class II.
            else if (bmi < 25)
            {
                stringOut = "Normal weight";
            }
            else if (bmi < 30)
            {
                stringOut = "Overweight (Pre-obesity)";
            }
            else if (bmi < 35)
            {
                stringOut = "Overweight (Obesity class I)";
            }
            else if (bmi < 40)
            {
                stringOut = "Overweight (Obesity class II)";
            }
            else
            {
                stringOut = "Overweight (Obesity class III)";
            }
            return stringOut;//Returns the string matching calculated bmi value
        }

        public string NormalWeight()
        {
            double weight1 = 0;
            double weight2 = 0;
            if(unit == UnitTypes.American)//If units are imperial
            {//imperial calculation for normal weight
                weight1 = (18.5 / 703) * (height * height);
                weight2 = (24.9 / 703) * (height * height);
            }
            else//Metric calculation for normal weight
            {
                weight1 = 18.5 * height * height;
                weight2 = 24.9 * height * height;
            }
            //Creates an interpolated string to return
            string stringOut = $"Normal weight should be between {weight1:f2} and {weight2:f2}";
            return stringOut;
        }
    }
}
