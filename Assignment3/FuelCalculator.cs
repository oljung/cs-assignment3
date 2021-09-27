using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{/// <summary>
/// This class serves as a server class, storing input data in instance variables
/// and handles calculations on fuel consumption and cost for driving a car. 
/// </summary>
    class FuelCalculator
    {
        private double currReading;//current odometer
        private double prevReading;//previous odometer
        private double fuelAmount;//fuel in gas tanked (considered "used" in calculations)
        private double unitPrice;//price per units in cost/liter

        #region setters and getters
        public void SetCurrReading(double value)
        {
            if(value > 0)//Current reading can't be 0, as what is the point in calculating on a car tha thas never moved
            {
                currReading = value;
            }
        }

        public double GetCurrReading()//returns current reading
        {
            return currReading;
        }

        public void SetPrevReading(double value)//set value of previous reading
        {
            if(value >= 0)//can't be negative but may be 0
            {
                prevReading = value;
            }
        }

        public double GetPrevReading()// returns previous meter value
        {
            return prevReading;
        }
        //the rest follow the same structure
        public void SetFuelAmount(double value)
        {
            if(value > 0)
            {
                fuelAmount = value;
            }
        }

        public double GetFuelAmount()
        {
            return fuelAmount;
        }

        public void SetUnitPrice(double value)
        {
            if(value > 0)
            {
                unitPrice = value;
            }
        }

        public double GetUnitPrice()
        {
            return unitPrice;
        }
        #endregion

        public bool ValidateOdometers()
        {//Checks if the current reading is greater then previous reading
            bool ok;
            if(currReading > prevReading)//currnt must be greater than previous
            {
                ok = true;
            }
            else
            {
                ok = false;
            }
            return ok;//returns true if current reading is greater than previous reading
        }

        public double CalcConsumptionKmPerLiter()
        {//Calculate how many km you can drive on 1 liter
            double km = currReading - prevReading;//gets distance travelled
            //calculates how many km the car ran per liter
            double result = km / fuelAmount;
            return result;//returns value of calculation
        }

        public double CalcConsumptionPerKm()
        {//calculates fuel consumption in liters per km
            double km = currReading - prevReading;//distance travelled
            //how many liters the car consumes every km
            double result = fuelAmount / km;
            return result;//value of fuel consumption per km
        }

        public double CalcConsumptionPerImpMile()
        {//Method for calculating consumption per mile
            const double kmToMileFactor = 0.621371192;//factor for converting km to mile
            //uses method for calculating consumption per km
            double perKm = CalcConsumptionPerKm();
            //divides by conversion factor
            double result = perKm / kmToMileFactor;
            return result;//returns the consumption in miles
        }

        public double CalcConsumptionPerSweMil()
        {//method for calculating consumption per swedish mil
            double perKm = CalcConsumptionPerKm();//consumption per km
            //multiply by 10 (10 km per mil)
            double result = perKm * 10;
            return result;//returns consumption per mil
        }

        public double CalcCostPerKm()
        {//Calculates price per km depending on consumption and unit price
            double litPerKm = CalcConsumptionPerKm();//Caltulates liters per km (consumption)
            double cost = litPerKm * unitPrice;//multiplies by unitprice
            return cost;//returns cost per km
        }
    }


}
