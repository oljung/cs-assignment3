using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {//instance variables needed in main form are objects of the 3 server classes
        BMICalculator bmiCalc = new BMICalculator();
        FuelCalculator fuelCalc = new FuelCalculator();
        BMRCalculator bmrCalc = new BMRCalculator();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();//initialize default values
        }

        private void InitializeGUI()
        {
            ClearTextBoxes();
            ClearOutputLabels();
            rbtnImperial.Checked = true;//sets default unittype to imperial
            lblHeight.Text = "Height (feet, inch";//as default is imperial
            lblWeight.Text = "Weight (lb)";//like above
            rbtnFemale.Checked = true;//sets default gender in bmrCalc to female
            rbtnSedentary.Checked = true;//sets default activitylevel
        }

        private void ClearTextBoxes()//Clear the input txt fields from text used in designer to 
                                     //show what goes where
        {
            //Input controls
            txtName.Text = string.Empty;
            txtHeightCmFoot.Text = string.Empty;
            txtInch.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtCurrentOdometer.Text = string.Empty;
            txtFuelAmount.Text = string.Empty;
            txtPreviousOdometer.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtAge.Text = string.Empty;
            
        }

        private void ClearOutputLabels()//clears all the labels used for handling output
        {
            lblBMIResult.Text = string.Empty;
            lblCategoryResult.Text = string.Empty;
            lblNormalWeight.Text = string.Empty;
            lblCostPerKmResult.Text = string.Empty;
            lblFuelKmLitResult.Text = string.Empty;
            lblFuelLitImpMileResult.Text = string.Empty;
            lblFuelLitSweMilResult.Text = string.Empty;
            lblFuelLitKmResult.Text = string.Empty;
            lblBMROutput.Text = string.Empty;
            lblGain1Result.Text = string.Empty;
            lblGain2Result.Text = string.Empty;
            lblLose1Result.Text = string.Empty;
            lblLose2Result.Text = string.Empty;
            lblMaintainResult.Text = string.Empty;
            lblYourBMRResult.Text = string.Empty;
        }

        #region BMICalculator part

        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMetric.Checked)//If the Metric option is chosen
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                txtInch.Enabled = false;//disables the 2nd height text to avoid confusion
                bmiCalc.SetUnit(UnitTypes.Metric);
            }
        }

        private void rbtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnImperial.Checked)//If the imperial system is chosen
            {
                lblHeight.Text = "Height (feet, inch)";
                lblWeight.Text = "Weight (lb)";
                txtInch.Enabled = true;//enables the 2nd height text
                bmiCalc.SetUnit(UnitTypes.American);
            }
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            //clears the output labels so as not to view result when invalid input is given
            lblBMIResult.Text = string.Empty;
            lblCategoryResult.Text = string.Empty;
            lblNormalWeight.Text = string.Empty;
            
            bool ok = ReadInputBMI();//Reads the input values from fields used in BMI calculation
            if (ok)
            {
                DisplayOutputBMI();
            }
        }

        private bool ReadInputBMI()
        {
            ReadName();
            bool heightOk = ReadHeight();
            bool weightOk = ReadWeight();

            return heightOk && weightOk;
        }

        private void ReadName()
        {//Reads name from txtName and sets name to input value, if empty sets name to "Unknown"
            if (string.IsNullOrEmpty(txtName.Text))
            {
                bmiCalc.SetName("Unknown");
            }
            else
            {
                bmiCalc.SetName(txtName.Text);
            }
        }
        /// <summary>
        /// This is broken down into two parts, mainly due to the feet and inches construction
        /// Reads the input from txtHeightCmFoot (and txtInch optionally) and if input 
        /// is valid sets the height using SetHeight() and converts to correct unit.
        /// </summary>
        /// <returns>ok if input are valid</returns>
        private bool ReadHeight()
        {
            bool ok;
            if(bmiCalc.GetUnit() == UnitTypes.American)//They really should adopt the metric...
            {
                ok = ReadImperialHeight();//See method for explanation
            }
            else//If metric
            {
                //tries to parse text in txtHeightCmFoot to double and stores in outValue
                ok = double.TryParse(txtHeightCmFoot.Text, out double outValue);
                if (ok)//If valid number
                {
                    if(outValue > 0)//Can not be 0 or negative
                    {
                        bmiCalc.SetHeight(outValue / 100);//cm to m
                    }
                    else
                    {
                        ok = false;
                    }
                }
                if (!ok)//To inform user of what went wrong
                {
                    MessageBox.Show("Invalid height value!", "Error");
                }
            }
            return ok;
        }
        /// <summary>
        /// The feetOk and inchOk are results of TryParse from the
        ///txtHeightCmFoot and txtInch(optional and only enabled if imperial is chosen)
        ///the ok bool is true only if both work.If both are ok the value of feet is over 0
        ///height is set using the SetHeight, with feet multiplied by 12 and inches added(even if 0)
        ///rest follows the standard ReadNumber form.
        /// </summary>
        /// <returns>bool ok if input is successfully read</returns>
        private bool ReadImperialHeight()//Decided to make this its own method or the ReadHight() would get to long
        {//This whole unit thing is just irritating, don't you think?
            
            bool feetOk = double.TryParse(txtHeightCmFoot.Text, out double feet);
            bool inchOk = double.TryParse(txtInch.Text, out double inch);
            bool ok = feetOk && inchOk;
            if (ok)
            {
                if(feet > 0)//Inch can be 0, as it is just added and won't cause issues
                {
                    bmiCalc.SetHeight((feet * 12) + inch);
                }
                else
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Invalid height value!", "Error");
            }
            return ok;
        }

        private bool ReadWeight()//Works like the metric part of ReadHeight()
        {   //Tries to parse input from tctWeight and stores value in outValue variable
            bool ok = double.TryParse(txtWeight.Text, out double outValue);
            if (ok)//If a valid input is given to txtWeight
            {
                if(outValue > 0)//weight can't be 0
                {
                    bmiCalc.SetWeight(outValue);//Sets the weight to value of txtWeight
                }
                else
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Invalid weight input!", "Error");
            }
            return ok;

        }
        private void DisplayOutputBMI()
        {
            lblBMIResult.Text = bmiCalc.CalculateBMI().ToString("f2");
            lblCategoryResult.Text = bmiCalc.BMIWeightCategory();
            lblNormalWeight.Text = bmiCalc.NormalWeight();
            gboxBMIResult.Text = $"Result for {bmiCalc.GetName()}:";
        }
        #endregion

        #region FuelCalculator part

        private void btnCalculateFuel_Click(object sender, EventArgs e)
        {
            //clears all output labels to avoid showing result on invalid input
            lblCostPerKmResult.Text = string.Empty;
            lblFuelKmLitResult.Text = string.Empty;
            lblFuelLitImpMileResult.Text = string.Empty;
            lblFuelLitSweMilResult.Text = string.Empty;
            lblFuelLitKmResult.Text = string.Empty;

            //reads all input and is true if all input are valid
            bool inputOk = ReadInputFuel();//handles all input
            bool kmOk = fuelCalc.ValidateOdometers();//validates the odometers, true if 
                                                     //current is greater than previous
            if (!kmOk)
            {
                MessageBox.Show("Current reading must be greater than previous reading", "Error");
            }
            bool ok = inputOk && kmOk;

            if (ok)
            {
                DisplayOutputFuel();
            }


        }

        private bool ReadInputFuel()
        {//Handles input from textboxes in individual methods, see ReadCurrentOdometer() comments for details
            bool currentOk = ReadCurrentOdometer();
            bool prevOk = ReadPreviousOdometer();
            bool amountOk = ReadFuelAmount();
            bool priceOk = ReadPrice();

            return currentOk && prevOk && amountOk && priceOk;//returns true if all input are valid
        }
        /*
         *The following methods follow the exakt same structure. I value from the
          corresponding textbox is sent to a double.TryParse. If the value is valid,
          it is tested to make sure it is greater than 0. If valid and greater it is 
          sent to correspinging setter method of the FuelCalculator class. If not valid
          error message is shown tu user informing of what went wrong.
         */
        private bool ReadCurrentOdometer()//Reads input in txtCurrentOdometer
        {
            bool ok = double.TryParse(txtCurrentOdometer.Text, out double outValue);
            if (ok)//If input in textbox is a valid number
            {
                if(outValue > 0)//must be greater than 0 or calculations will not work
                {
                    fuelCalc.SetCurrReading(outValue);//sets value if valied and above 0
                                                      //to the correct instance variable
                }
                else//not an accepted value
                {
                    ok = false;
                }
            }
            if (!ok)//Something went wrong, input invalid
            {
                MessageBox.Show("Current odometer input is invalid", "Error");
            }
            return ok;
        }

        private bool ReadPreviousOdometer()
        {
            bool ok = double.TryParse(txtPreviousOdometer.Text, out double outValue);
            if (ok)//If input in textbox is a valid number
            {
                if (outValue >= 0)//must be greater than or equal to 0 or calculations will not work
                {
                    fuelCalc.SetPrevReading(outValue);//sets value if valied and above 0
                                                      //to the correct instance variable
                }
                else//not an accepted value
                {
                    ok = false;
                }
            }
            if (!ok)//Something went wrong, input invalid
            {
                MessageBox.Show("Previous odometer input is invalid", "Error");
            }
            return ok;
        }

        private bool ReadFuelAmount()
        {
            bool ok = double.TryParse(txtFuelAmount.Text, out double outValue);
            if (ok)//If input in textbox is a valid number
            {
                if (outValue > 0)//must be greater than 0 or calculations will not work
                {
                    fuelCalc.SetFuelAmount(outValue);//sets value if valied and above 0
                                                      //to the correct instance variable
                }
                else//not an accepted value
                {
                    ok = false;
                }
            }
            if (!ok)//Something went wrong, input invalid
            {
                MessageBox.Show("Fuel amount input is invalid", "Error");
            }
            return ok;
        }

        private bool ReadPrice()
        {
            bool ok = double.TryParse(txtPrice.Text, out double outValue);
            if (ok)//If input in textbox is a valid number
            {
                if (outValue > 0)//must be greater than 0 or calculations will not work
                {
                    fuelCalc.SetUnitPrice(outValue);//sets value if valied and above 0
                                                      //to the correct instance variable
                }
                else//not an accepted value
                {
                    ok = false;
                }
            }
            if (!ok)//Something went wrong, input invalid
            {
                MessageBox.Show("Price input is invalid", "Error");
            }
            return ok;
        }
        private void DisplayOutputFuel()
        {
            lblFuelKmLitResult.Text = fuelCalc.CalcConsumptionKmPerLiter().ToString("f2");
            lblFuelLitKmResult.Text = fuelCalc.CalcConsumptionPerKm().ToString("f2");
            lblFuelLitImpMileResult.Text = fuelCalc.CalcConsumptionPerImpMile().ToString("f2");
            lblFuelLitSweMilResult.Text = fuelCalc.CalcConsumptionPerSweMil().ToString("f2");
            lblCostPerKmResult.Text = fuelCalc.CalcCostPerKm().ToString("f2");
        }




        #endregion

        #region BMR part
        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFemale.Checked)//true if checked
            {
                bmrCalc.SetGender(true);//sets gender to female
            }
            
        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMale.Checked)//true if checked
            {
                bmrCalc.SetGender(false);//sets gender to male
            }
            
        }
        //values sent to SetActivityLevel corresponds to table value in assignment info
        //as well as the values in the GetActivityfactor() method
        private void rbtnSedentary_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSedentary.Checked)//true if checked
            {
                bmrCalc.SetActivityLevel(0);//sets activity level to lowest value/sedentary
            }
        }

        private void rbtnLightlyActivite_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLightlyActivite.Checked)
            {
                bmrCalc.SetActivityLevel(1);//sets level to lightly active
            }
        }

        private void rbtnModeratlyActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnModeratlyActive.Checked)
            {
                bmrCalc.SetActivityLevel(2);//sets level to moderatly active
            }
        }

        private void rbtnVeryActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnVeryActive.Checked)
            {
                bmrCalc.SetActivityLevel(3);//sets level to very active
            }
        }

        private void rbtnExtraActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnExtraActive.Checked)
            {
                bmrCalc.SetActivityLevel(4);//sets level to extra active
            }
        }

        private void btnCalculateBMR_Click(object sender, EventArgs e)
        {
            lblBMROutput.Text = string.Empty;//clears labels so no output is given on invalid input
            lblGain1Result.Text = string.Empty;
            lblGain2Result.Text = string.Empty;
            lblLose1Result.Text = string.Empty;
            lblLose2Result.Text = string.Empty;
            lblMaintainResult.Text = string.Empty;
            lblYourBMRResult.Text = string.Empty;
            bool ok = ReadBMRValues();//method for reading and setting needed values to instance variables

            if (ok)
            {
                DisplayOutputBMR();//method for displaying output
            }
        }

        private bool ReadBMRValues()//Method for reading and setting needed values for 
                                    //BMR calculations
        {
            bool ageOk = ReadAge();//read and set age
            bool heightOk = ReadBMRHeight();//read and set height
            bool weightOk = ReadBMRWeight();//read and set weight
            return ageOk && heightOk && weightOk;//returns true if all readings are ok
        }

        private bool ReadAge()//this works much like the methods in fuel part
        {
            bool ok = int.TryParse(txtAge.Text, out int outValue);
            if (ok)//If input in textbox is a valid number
            {
                if (outValue > 0)//must be greater than  0 or calculations will not work
                {
                    bmrCalc.SetAge(outValue);//sets value if valied and above 0
                                                      //to the correct instance variable
                }
                else//not an accepted value
                {
                    ok = false;
                }
            }
            if (!ok)//Something went wrong, input invalid
            {
                MessageBox.Show("Age input is invalid", "Error");
            }
            return ok;
        }
        /// <summary>
        /// This method makes use of the BMICalculator class and the previously used 
        /// ReadHeight methods. Using the GetHeight and converting if needed to cm
        /// it will always send correct units to the SetHeight method in the BMRCalculator class
        /// </summary>
        /// <returns>true if the input for height in BMI part is valid</returns>
        private bool ReadBMRHeight()
        {
            bool ok = ReadHeight();//Sets height in bmiCalc object
            double height = bmiCalc.GetHeight();//Gets height from bmiCalc object, in meters or inches
            double outvalue;//value to be sent to setter method
            if (ok)
            {
                if (bmiCalc.GetUnit() == UnitTypes.American)//will always have a value due to initialization
                {
                    //if height is given in inches, converts to cm
                    outvalue = height * 2.54f;//there are 2.54 cm to an inch
                }
                else
                {
                    outvalue = height * 100;//ReadHeight is set to m, this converts to cm
                }
                bmrCalc.SetHeight(outvalue);//sets height in bmrCalc object
                //No else and message needed, the ReadHeight method already does that
            }
            return ok;

        }
        //this works exactly like ReadBMRHeight but with another factor for unitconversion
        private bool ReadBMRWeight()
        {
            bool ok = ReadWeight();//Sets weight in bmiCalc object
            double weight = bmiCalc.GetWeight();//Gets weight from bmiCalc object in lb or kg
            double outvalue;
            if (ok)
            {
                if (bmiCalc.GetUnit() == UnitTypes.American)//will always have a value due to initialization
                {
                    //if weight is given in lb, converts to kg
                    outvalue = weight * 0.45359237f;//factor for converting lb to kg
                }
                else
                {
                    outvalue = weight;
                }
                bmrCalc.SetWeight(outvalue);//sets weight in bmrCalc object
            }//like ReadBMRHeight, no error handling is needed, already taken care of in ReadWeight()
            return ok;
        }
        /// <summary>
        /// This method displays all the output values to form. The form has a label
        /// with labels in it. This solution is not as clean as I wanted, but I was unable
        /// to get new lines to work properly in the lblBMROutput satisfactory.However the method
        /// sets label texts by calling methods from the BMRCalculator class and converts returned
        /// double value with .ToString() in assignment statement, not using variables to temporarily
        /// store the values.
        /// </summary>
        private void DisplayOutputBMR()
        {
            ReadName();//Reads name to be used for headline
            //Sets headline for the output box
            lblBMROutput.Text = $"BMR RESULTS FOR {bmiCalc.GetName()}:";
            //calls the CalculateBMR() and sets the returned value as the label text using .ToString()
            lblYourBMRResult.Text = bmrCalc.CalculateBMR().ToString("f1");//double to string
            //calls the MaintainweightCalories() and sets the returned value as the label text using .ToString()
            lblMaintainResult.Text = bmrCalc.MaintainWeightCalories().ToString("f1");//double to string
            //calls the LoseOrGainWeightCalories() and sets the returned value as the label text using .ToString()
            //Called 4 times to get the different values for losin o,5kg/1kg or gaining equal amount.
            lblLose1Result.Text = bmrCalc.LoseOrGainWeightCalories(500, true).ToString("f1");
            lblLose2Result.Text = bmrCalc.LoseOrGainWeightCalories(1000, true).ToString("f1");//all values double to string
            lblGain1Result.Text = bmrCalc.LoseOrGainWeightCalories(500, false).ToString("f1");
            lblGain2Result.Text = bmrCalc.LoseOrGainWeightCalories(1000, false).ToString("f1");
        }
        #endregion

    }
}
