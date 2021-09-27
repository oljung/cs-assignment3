namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblYourName = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHeightCmFoot = new System.Windows.Forms.TextBox();
            this.txtInch = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.gboxUnit = new System.Windows.Forms.GroupBox();
            this.rbtnImperial = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.gboxBMIResult = new System.Windows.Forms.GroupBox();
            this.lblNormalWeight = new System.Windows.Forms.Label();
            this.lblNormalBMI = new System.Windows.Forms.Label();
            this.lblCategoryResult = new System.Windows.Forms.Label();
            this.lblBMIResult = new System.Windows.Forms.Label();
            this.lblWeightCategory = new System.Windows.Forms.Label();
            this.lblYourBMI = new System.Windows.Forms.Label();
            this.gboxFuel = new System.Windows.Forms.GroupBox();
            this.gboxFuelResults = new System.Windows.Forms.GroupBox();
            this.lblCostPerKmResult = new System.Windows.Forms.Label();
            this.lblFuelLitSweMilResult = new System.Windows.Forms.Label();
            this.lblFuelLitImpMileResult = new System.Windows.Forms.Label();
            this.lblFuelLitKmResult = new System.Windows.Forms.Label();
            this.lblFuelKmLitResult = new System.Windows.Forms.Label();
            this.lblCostPerKm = new System.Windows.Forms.Label();
            this.lblFuelSweMil = new System.Windows.Forms.Label();
            this.FuelLitImperialMile = new System.Windows.Forms.Label();
            this.lblFuelLitKm = new System.Windows.Forms.Label();
            this.lblFuelKmLit = new System.Windows.Forms.Label();
            this.btnCalculateFuel = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFuelAmount = new System.Windows.Forms.TextBox();
            this.txtPreviousOdometer = new System.Windows.Forms.TextBox();
            this.txtCurrentOdometer = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFuelAmount = new System.Windows.Forms.Label();
            this.lblPreviosOdometer = new System.Windows.Forms.Label();
            this.lblCurrentOdometer = new System.Windows.Forms.Label();
            this.gboxBMR = new System.Windows.Forms.GroupBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblGain2 = new System.Windows.Forms.Label();
            this.lblGain1 = new System.Windows.Forms.Label();
            this.lblLose2 = new System.Windows.Forms.Label();
            this.lblLose1 = new System.Windows.Forms.Label();
            this.lblMaintain = new System.Windows.Forms.Label();
            this.lblYourBMR = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.lblBMROutput = new System.Windows.Forms.Label();
            this.btnCalculateBMR = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.gboxActivtiLevel = new System.Windows.Forms.GroupBox();
            this.rbtnExtraActive = new System.Windows.Forms.RadioButton();
            this.rbtnVeryActive = new System.Windows.Forms.RadioButton();
            this.rbtnModeratlyActive = new System.Windows.Forms.RadioButton();
            this.rbtnLightlyActivite = new System.Windows.Forms.RadioButton();
            this.rbtnSedentary = new System.Windows.Forms.RadioButton();
            this.lblYourBMRResult = new System.Windows.Forms.Label();
            this.lblMaintainResult = new System.Windows.Forms.Label();
            this.lblLose1Result = new System.Windows.Forms.Label();
            this.lblLose2Result = new System.Windows.Forms.Label();
            this.lblGain1Result = new System.Windows.Forms.Label();
            this.lblGain2Result = new System.Windows.Forms.Label();
            this.gboxUnit.SuspendLayout();
            this.gboxBMIResult.SuspendLayout();
            this.gboxFuel.SuspendLayout();
            this.gboxFuelResults.SuspendLayout();
            this.gboxBMR.SuspendLayout();
            this.gboxActivtiLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYourName
            // 
            this.lblYourName.AutoSize = true;
            this.lblYourName.Location = new System.Drawing.Point(27, 45);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(60, 13);
            this.lblYourName.TabIndex = 0;
            this.lblYourName.Text = "Your Name";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(27, 71);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(27, 97);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Name";
            // 
            // txtHeightCmFoot
            // 
            this.txtHeightCmFoot.Location = new System.Drawing.Point(127, 68);
            this.txtHeightCmFoot.Name = "txtHeightCmFoot";
            this.txtHeightCmFoot.Size = new System.Drawing.Size(66, 20);
            this.txtHeightCmFoot.TabIndex = 4;
            this.txtHeightCmFoot.Text = "cm/foot";
            // 
            // txtInch
            // 
            this.txtInch.Location = new System.Drawing.Point(199, 68);
            this.txtInch.Name = "txtInch";
            this.txtInch.Size = new System.Drawing.Size(67, 20);
            this.txtInch.TabIndex = 5;
            this.txtInch.Text = "inch";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(127, 94);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 6;
            this.txtWeight.Text = "kg/lb";
            // 
            // gboxUnit
            // 
            this.gboxUnit.Controls.Add(this.rbtnImperial);
            this.gboxUnit.Controls.Add(this.rbtnMetric);
            this.gboxUnit.Location = new System.Drawing.Point(305, 36);
            this.gboxUnit.Name = "gboxUnit";
            this.gboxUnit.Size = new System.Drawing.Size(156, 74);
            this.gboxUnit.TabIndex = 7;
            this.gboxUnit.TabStop = false;
            this.gboxUnit.Text = "Unit";
            // 
            // rbtnImperial
            // 
            this.rbtnImperial.AutoSize = true;
            this.rbtnImperial.Location = new System.Drawing.Point(26, 46);
            this.rbtnImperial.Name = "rbtnImperial";
            this.rbtnImperial.Size = new System.Drawing.Size(127, 17);
            this.rbtnImperial.TabIndex = 1;
            this.rbtnImperial.TabStop = true;
            this.rbtnImperial.Text = "Imperial (foot/inch, lb)";
            this.rbtnImperial.UseVisualStyleBackColor = true;
            this.rbtnImperial.CheckedChanged += new System.EventHandler(this.rbtnImperial_CheckedChanged);
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(26, 20);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(95, 17);
            this.rbtnMetric.TabIndex = 0;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric (cm, kg)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.Location = new System.Drawing.Point(127, 146);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(139, 32);
            this.btnCalculateBMI.TabIndex = 8;
            this.btnCalculateBMI.Text = "Calculate";
            this.btnCalculateBMI.UseVisualStyleBackColor = true;
            this.btnCalculateBMI.Click += new System.EventHandler(this.btnCalculateBMI_Click);
            // 
            // gboxBMIResult
            // 
            this.gboxBMIResult.Controls.Add(this.lblNormalWeight);
            this.gboxBMIResult.Controls.Add(this.lblNormalBMI);
            this.gboxBMIResult.Controls.Add(this.lblCategoryResult);
            this.gboxBMIResult.Controls.Add(this.lblBMIResult);
            this.gboxBMIResult.Controls.Add(this.lblWeightCategory);
            this.gboxBMIResult.Controls.Add(this.lblYourBMI);
            this.gboxBMIResult.Location = new System.Drawing.Point(34, 212);
            this.gboxBMIResult.Name = "gboxBMIResult";
            this.gboxBMIResult.Size = new System.Drawing.Size(424, 155);
            this.gboxBMIResult.TabIndex = 9;
            this.gboxBMIResult.TabStop = false;
            this.gboxBMIResult.Text = "Result for: ";
            // 
            // lblNormalWeight
            // 
            this.lblNormalWeight.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNormalWeight.Location = new System.Drawing.Point(70, 128);
            this.lblNormalWeight.Name = "lblNormalWeight";
            this.lblNormalWeight.Size = new System.Drawing.Size(300, 24);
            this.lblNormalWeight.TabIndex = 5;
            this.lblNormalWeight.Text = "Normal Weight";
            // 
            // lblNormalBMI
            // 
            this.lblNormalBMI.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNormalBMI.Location = new System.Drawing.Point(70, 98);
            this.lblNormalBMI.Name = "lblNormalBMI";
            this.lblNormalBMI.Size = new System.Drawing.Size(300, 30);
            this.lblNormalBMI.TabIndex = 4;
            this.lblNormalBMI.Text = "Normal BMI is between 18.5 and 24.9";
            // 
            // lblCategoryResult
            // 
            this.lblCategoryResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategoryResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoryResult.Location = new System.Drawing.Point(106, 59);
            this.lblCategoryResult.Name = "lblCategoryResult";
            this.lblCategoryResult.Size = new System.Drawing.Size(150, 25);
            this.lblCategoryResult.TabIndex = 3;
            this.lblCategoryResult.Text = "Weight Category Result";
            this.lblCategoryResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBMIResult
            // 
            this.lblBMIResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBMIResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMIResult.Location = new System.Drawing.Point(142, 16);
            this.lblBMIResult.Name = "lblBMIResult";
            this.lblBMIResult.Size = new System.Drawing.Size(114, 26);
            this.lblBMIResult.TabIndex = 2;
            this.lblBMIResult.Text = "BMI Result";
            this.lblBMIResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWeightCategory
            // 
            this.lblWeightCategory.AutoSize = true;
            this.lblWeightCategory.Location = new System.Drawing.Point(14, 65);
            this.lblWeightCategory.Name = "lblWeightCategory";
            this.lblWeightCategory.Size = new System.Drawing.Size(86, 13);
            this.lblWeightCategory.TabIndex = 1;
            this.lblWeightCategory.Text = "Wieght Category";
            // 
            // lblYourBMI
            // 
            this.lblYourBMI.AutoSize = true;
            this.lblYourBMI.Location = new System.Drawing.Point(14, 23);
            this.lblYourBMI.Name = "lblYourBMI";
            this.lblYourBMI.Size = new System.Drawing.Size(54, 13);
            this.lblYourBMI.TabIndex = 0;
            this.lblYourBMI.Text = "Your BMI:";
            // 
            // gboxFuel
            // 
            this.gboxFuel.Controls.Add(this.gboxFuelResults);
            this.gboxFuel.Controls.Add(this.btnCalculateFuel);
            this.gboxFuel.Controls.Add(this.txtPrice);
            this.gboxFuel.Controls.Add(this.txtFuelAmount);
            this.gboxFuel.Controls.Add(this.txtPreviousOdometer);
            this.gboxFuel.Controls.Add(this.txtCurrentOdometer);
            this.gboxFuel.Controls.Add(this.lblPrice);
            this.gboxFuel.Controls.Add(this.lblFuelAmount);
            this.gboxFuel.Controls.Add(this.lblPreviosOdometer);
            this.gboxFuel.Controls.Add(this.lblCurrentOdometer);
            this.gboxFuel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gboxFuel.Location = new System.Drawing.Point(477, 42);
            this.gboxFuel.Name = "gboxFuel";
            this.gboxFuel.Size = new System.Drawing.Size(325, 325);
            this.gboxFuel.TabIndex = 10;
            this.gboxFuel.TabStop = false;
            this.gboxFuel.Text = "Fuel";
            // 
            // gboxFuelResults
            // 
            this.gboxFuelResults.Controls.Add(this.lblCostPerKmResult);
            this.gboxFuelResults.Controls.Add(this.lblFuelLitSweMilResult);
            this.gboxFuelResults.Controls.Add(this.lblFuelLitImpMileResult);
            this.gboxFuelResults.Controls.Add(this.lblFuelLitKmResult);
            this.gboxFuelResults.Controls.Add(this.lblFuelKmLitResult);
            this.gboxFuelResults.Controls.Add(this.lblCostPerKm);
            this.gboxFuelResults.Controls.Add(this.lblFuelSweMil);
            this.gboxFuelResults.Controls.Add(this.FuelLitImperialMile);
            this.gboxFuelResults.Controls.Add(this.lblFuelLitKm);
            this.gboxFuelResults.Controls.Add(this.lblFuelKmLit);
            this.gboxFuelResults.ForeColor = System.Drawing.Color.OliveDrab;
            this.gboxFuelResults.Location = new System.Drawing.Point(20, 179);
            this.gboxFuelResults.Name = "gboxFuelResults";
            this.gboxFuelResults.Size = new System.Drawing.Size(288, 145);
            this.gboxFuelResults.TabIndex = 9;
            this.gboxFuelResults.TabStop = false;
            this.gboxFuelResults.Text = "Results";
            // 
            // lblCostPerKmResult
            // 
            this.lblCostPerKmResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCostPerKmResult.Location = new System.Drawing.Point(203, 122);
            this.lblCostPerKmResult.Name = "lblCostPerKmResult";
            this.lblCostPerKmResult.Size = new System.Drawing.Size(78, 20);
            this.lblCostPerKmResult.TabIndex = 9;
            this.lblCostPerKmResult.Text = "0.00";
            // 
            // lblFuelLitSweMilResult
            // 
            this.lblFuelLitSweMilResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelLitSweMilResult.Location = new System.Drawing.Point(203, 97);
            this.lblFuelLitSweMilResult.Name = "lblFuelLitSweMilResult";
            this.lblFuelLitSweMilResult.Size = new System.Drawing.Size(75, 21);
            this.lblFuelLitSweMilResult.TabIndex = 8;
            this.lblFuelLitSweMilResult.Text = "lit/swe mil";
            // 
            // lblFuelLitImpMileResult
            // 
            this.lblFuelLitImpMileResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelLitImpMileResult.Location = new System.Drawing.Point(202, 72);
            this.lblFuelLitImpMileResult.Name = "lblFuelLitImpMileResult";
            this.lblFuelLitImpMileResult.Size = new System.Drawing.Size(77, 19);
            this.lblFuelLitImpMileResult.TabIndex = 7;
            this.lblFuelLitImpMileResult.Text = "lit/imp mile";
            // 
            // lblFuelLitKmResult
            // 
            this.lblFuelLitKmResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelLitKmResult.Location = new System.Drawing.Point(202, 44);
            this.lblFuelLitKmResult.Name = "lblFuelLitKmResult";
            this.lblFuelLitKmResult.Size = new System.Drawing.Size(79, 19);
            this.lblFuelLitKmResult.TabIndex = 6;
            this.lblFuelLitKmResult.Text = "lit/km";
            // 
            // lblFuelKmLitResult
            // 
            this.lblFuelKmLitResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelKmLitResult.Location = new System.Drawing.Point(202, 19);
            this.lblFuelKmLitResult.Name = "lblFuelKmLitResult";
            this.lblFuelKmLitResult.Size = new System.Drawing.Size(80, 18);
            this.lblFuelKmLitResult.TabIndex = 5;
            this.lblFuelKmLitResult.Text = "km/lit";
            // 
            // lblCostPerKm
            // 
            this.lblCostPerKm.AutoSize = true;
            this.lblCostPerKm.Location = new System.Drawing.Point(13, 119);
            this.lblCostPerKm.Name = "lblCostPerKm";
            this.lblCostPerKm.Size = new System.Drawing.Size(91, 13);
            this.lblCostPerKm.TabIndex = 4;
            this.lblCostPerKm.Text = "Cost per kilometer";
            // 
            // lblFuelSweMil
            // 
            this.lblFuelSweMil.AutoSize = true;
            this.lblFuelSweMil.Location = new System.Drawing.Point(13, 95);
            this.lblFuelSweMil.Name = "lblFuelSweMil";
            this.lblFuelSweMil.Size = new System.Drawing.Size(145, 13);
            this.lblFuelSweMil.TabIndex = 3;
            this.lblFuelSweMil.Text = "Fuel consumption (lit/swe mil)";
            // 
            // FuelLitImperialMile
            // 
            this.FuelLitImperialMile.AutoSize = true;
            this.FuelLitImperialMile.Location = new System.Drawing.Point(12, 73);
            this.FuelLitImperialMile.Name = "FuelLitImperialMile";
            this.FuelLitImperialMile.Size = new System.Drawing.Size(167, 13);
            this.FuelLitImperialMile.TabIndex = 2;
            this.FuelLitImperialMile.Text = "Fuel consumption (lit/imperial mile)";
            // 
            // lblFuelLitKm
            // 
            this.lblFuelLitKm.AutoSize = true;
            this.lblFuelLitKm.Location = new System.Drawing.Point(12, 50);
            this.lblFuelLitKm.Name = "lblFuelLitKm";
            this.lblFuelLitKm.Size = new System.Drawing.Size(125, 13);
            this.lblFuelLitKm.TabIndex = 1;
            this.lblFuelLitKm.Text = "Fuel consumption (lit/km)";
            // 
            // lblFuelKmLit
            // 
            this.lblFuelKmLit.AutoSize = true;
            this.lblFuelKmLit.Location = new System.Drawing.Point(12, 20);
            this.lblFuelKmLit.Name = "lblFuelKmLit";
            this.lblFuelKmLit.Size = new System.Drawing.Size(125, 13);
            this.lblFuelKmLit.TabIndex = 0;
            this.lblFuelKmLit.Text = "Fuel consumption (km/lit)";
            // 
            // btnCalculateFuel
            // 
            this.btnCalculateFuel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalculateFuel.Location = new System.Drawing.Point(102, 134);
            this.btnCalculateFuel.Name = "btnCalculateFuel";
            this.btnCalculateFuel.Size = new System.Drawing.Size(136, 27);
            this.btnCalculateFuel.TabIndex = 8;
            this.btnCalculateFuel.Text = "Calculate";
            this.btnCalculateFuel.UseVisualStyleBackColor = true;
            this.btnCalculateFuel.Click += new System.EventHandler(this.btnCalculateFuel_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(194, 101);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(115, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "price/liter";
            // 
            // txtFuelAmount
            // 
            this.txtFuelAmount.Location = new System.Drawing.Point(194, 75);
            this.txtFuelAmount.Name = "txtFuelAmount";
            this.txtFuelAmount.Size = new System.Drawing.Size(115, 20);
            this.txtFuelAmount.TabIndex = 6;
            this.txtFuelAmount.Text = "liters tanked";
            // 
            // txtPreviousOdometer
            // 
            this.txtPreviousOdometer.Location = new System.Drawing.Point(194, 52);
            this.txtPreviousOdometer.Name = "txtPreviousOdometer";
            this.txtPreviousOdometer.Size = new System.Drawing.Size(115, 20);
            this.txtPreviousOdometer.TabIndex = 5;
            this.txtPreviousOdometer.Text = "Previous redaing";
            // 
            // txtCurrentOdometer
            // 
            this.txtCurrentOdometer.Location = new System.Drawing.Point(194, 26);
            this.txtCurrentOdometer.Name = "txtCurrentOdometer";
            this.txtCurrentOdometer.Size = new System.Drawing.Size(115, 20);
            this.txtCurrentOdometer.TabIndex = 4;
            this.txtCurrentOdometer.Text = "Current reading";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 104);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(68, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price per liter";
            // 
            // lblFuelAmount
            // 
            this.lblFuelAmount.AutoSize = true;
            this.lblFuelAmount.Location = new System.Drawing.Point(16, 78);
            this.lblFuelAmount.Name = "lblFuelAmount";
            this.lblFuelAmount.Size = new System.Drawing.Size(141, 13);
            this.lblFuelAmount.TabIndex = 2;
            this.lblFuelAmount.Text = "Amount of fuel tanked (liters)";
            // 
            // lblPreviosOdometer
            // 
            this.lblPreviosOdometer.AutoSize = true;
            this.lblPreviosOdometer.Location = new System.Drawing.Point(16, 55);
            this.lblPreviosOdometer.Name = "lblPreviosOdometer";
            this.lblPreviosOdometer.Size = new System.Drawing.Size(156, 13);
            this.lblPreviosOdometer.TabIndex = 1;
            this.lblPreviosOdometer.Text = "Previous odometer reading (km)";
            // 
            // lblCurrentOdometer
            // 
            this.lblCurrentOdometer.AutoSize = true;
            this.lblCurrentOdometer.Location = new System.Drawing.Point(16, 29);
            this.lblCurrentOdometer.Name = "lblCurrentOdometer";
            this.lblCurrentOdometer.Size = new System.Drawing.Size(149, 13);
            this.lblCurrentOdometer.TabIndex = 0;
            this.lblCurrentOdometer.Text = "Current odometer reading (km)";
            // 
            // gboxBMR
            // 
            this.gboxBMR.Controls.Add(this.lblGain2Result);
            this.gboxBMR.Controls.Add(this.lblGain1Result);
            this.gboxBMR.Controls.Add(this.lblLose2Result);
            this.gboxBMR.Controls.Add(this.lblLose1Result);
            this.gboxBMR.Controls.Add(this.lblMaintainResult);
            this.gboxBMR.Controls.Add(this.lblYourBMRResult);
            this.gboxBMR.Controls.Add(this.lblEnd);
            this.gboxBMR.Controls.Add(this.lblGain2);
            this.gboxBMR.Controls.Add(this.lblGain1);
            this.gboxBMR.Controls.Add(this.lblLose2);
            this.gboxBMR.Controls.Add(this.lblLose1);
            this.gboxBMR.Controls.Add(this.lblMaintain);
            this.gboxBMR.Controls.Add(this.lblYourBMR);
            this.gboxBMR.Controls.Add(this.lblNotice);
            this.gboxBMR.Controls.Add(this.lblBMROutput);
            this.gboxBMR.Controls.Add(this.btnCalculateBMR);
            this.gboxBMR.Controls.Add(this.txtAge);
            this.gboxBMR.Controls.Add(this.lblAge);
            this.gboxBMR.Controls.Add(this.rbtnMale);
            this.gboxBMR.Controls.Add(this.rbtnFemale);
            this.gboxBMR.Controls.Add(this.gboxActivtiLevel);
            this.gboxBMR.ForeColor = System.Drawing.Color.DarkCyan;
            this.gboxBMR.Location = new System.Drawing.Point(34, 375);
            this.gboxBMR.Name = "gboxBMR";
            this.gboxBMR.Size = new System.Drawing.Size(767, 247);
            this.gboxBMR.TabIndex = 11;
            this.gboxBMR.TabStop = false;
            this.gboxBMR.Text = "BMR ";
            // 
            // lblEnd
            // 
            this.lblEnd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnd.Location = new System.Drawing.Point(318, 190);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(423, 13);
            this.lblEnd.TabIndex = 14;
            this.lblEnd.Text = "Losing more than 1000 calories per day should be avoided";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGain2
            // 
            this.lblGain2.AutoSize = true;
            this.lblGain2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGain2.Location = new System.Drawing.Point(318, 169);
            this.lblGain2.Name = "lblGain2";
            this.lblGain2.Size = new System.Drawing.Size(103, 13);
            this.lblGain2.TabIndex = 13;
            this.lblGain2.Text = "Calories to gain 1kg:";
            // 
            // lblGain1
            // 
            this.lblGain1.AutoSize = true;
            this.lblGain1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGain1.Location = new System.Drawing.Point(318, 146);
            this.lblGain1.Name = "lblGain1";
            this.lblGain1.Size = new System.Drawing.Size(112, 13);
            this.lblGain1.TabIndex = 12;
            this.lblGain1.Text = "Calories to gain 0,5kg:";
            // 
            // lblLose2
            // 
            this.lblLose2.AutoSize = true;
            this.lblLose2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLose2.Location = new System.Drawing.Point(318, 123);
            this.lblLose2.Name = "lblLose2";
            this.lblLose2.Size = new System.Drawing.Size(102, 13);
            this.lblLose2.TabIndex = 11;
            this.lblLose2.Text = "Calories to lose 1kg:";
            // 
            // lblLose1
            // 
            this.lblLose1.AutoSize = true;
            this.lblLose1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLose1.Location = new System.Drawing.Point(318, 103);
            this.lblLose1.Name = "lblLose1";
            this.lblLose1.Size = new System.Drawing.Size(114, 13);
            this.lblLose1.TabIndex = 10;
            this.lblLose1.Text = "Calories to lose 0,5kg: ";
            // 
            // lblMaintain
            // 
            this.lblMaintain.AutoSize = true;
            this.lblMaintain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMaintain.Location = new System.Drawing.Point(317, 82);
            this.lblMaintain.Name = "lblMaintain";
            this.lblMaintain.Size = new System.Drawing.Size(138, 13);
            this.lblMaintain.TabIndex = 9;
            this.lblMaintain.Text = "Calories to maintain weight: ";
            // 
            // lblYourBMR
            // 
            this.lblYourBMR.AutoSize = true;
            this.lblYourBMR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYourBMR.Location = new System.Drawing.Point(317, 61);
            this.lblYourBMR.Name = "lblYourBMR";
            this.lblYourBMR.Size = new System.Drawing.Size(145, 13);
            this.lblYourBMR.TabIndex = 8;
            this.lblYourBMR.Text = "Your BMR (calories per day): ";
            // 
            // lblNotice
            // 
            this.lblNotice.ForeColor = System.Drawing.Color.Maroon;
            this.lblNotice.Location = new System.Drawing.Point(38, 72);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(273, 29);
            this.lblNotice.TabIndex = 7;
            this.lblNotice.Text = "Note: This calculation uses height and weight. Please enter values for height, we" +
    "ight and namein BMI part.";
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBMROutput
            // 
            this.lblBMROutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBMROutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMROutput.Location = new System.Drawing.Point(312, 33);
            this.lblBMROutput.Name = "lblBMROutput";
            this.lblBMROutput.Size = new System.Drawing.Size(433, 176);
            this.lblBMROutput.TabIndex = 6;
            this.lblBMROutput.Text = "BMR output";
            // 
            // btnCalculateBMR
            // 
            this.btnCalculateBMR.Location = new System.Drawing.Point(165, 33);
            this.btnCalculateBMR.Name = "btnCalculateBMR";
            this.btnCalculateBMR.Size = new System.Drawing.Size(105, 29);
            this.btnCalculateBMR.TabIndex = 5;
            this.btnCalculateBMR.Text = "Calculate";
            this.btnCalculateBMR.UseVisualStyleBackColor = true;
            this.btnCalculateBMR.Click += new System.EventHandler(this.btnCalculateBMR_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(106, 42);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(42, 20);
            this.txtAge.TabIndex = 4;
            this.txtAge.Text = "years";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(14, 45);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(106, 19);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 2;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(6, 19);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            this.rbtnFemale.CheckedChanged += new System.EventHandler(this.rbtnFemale_CheckedChanged);
            // 
            // gboxActivtiLevel
            // 
            this.gboxActivtiLevel.Controls.Add(this.rbtnExtraActive);
            this.gboxActivtiLevel.Controls.Add(this.rbtnVeryActive);
            this.gboxActivtiLevel.Controls.Add(this.rbtnModeratlyActive);
            this.gboxActivtiLevel.Controls.Add(this.rbtnLightlyActivite);
            this.gboxActivtiLevel.Controls.Add(this.rbtnSedentary);
            this.gboxActivtiLevel.Location = new System.Drawing.Point(6, 103);
            this.gboxActivtiLevel.Name = "gboxActivtiLevel";
            this.gboxActivtiLevel.Size = new System.Drawing.Size(231, 138);
            this.gboxActivtiLevel.TabIndex = 0;
            this.gboxActivtiLevel.TabStop = false;
            this.gboxActivtiLevel.Text = "Activity level";
            // 
            // rbtnExtraActive
            // 
            this.rbtnExtraActive.AutoSize = true;
            this.rbtnExtraActive.Location = new System.Drawing.Point(3, 108);
            this.rbtnExtraActive.Name = "rbtnExtraActive";
            this.rbtnExtraActive.Size = new System.Drawing.Size(150, 17);
            this.rbtnExtraActive.TabIndex = 4;
            this.rbtnExtraActive.TabStop = true;
            this.rbtnExtraActive.Text = "Extra active, hard exercise";
            this.rbtnExtraActive.UseVisualStyleBackColor = true;
            this.rbtnExtraActive.CheckedChanged += new System.EventHandler(this.rbtnExtraActive_CheckedChanged);
            // 
            // rbtnVeryActive
            // 
            this.rbtnVeryActive.AutoSize = true;
            this.rbtnVeryActive.Location = new System.Drawing.Point(3, 85);
            this.rbtnVeryActive.Name = "rbtnVeryActive";
            this.rbtnVeryActive.Size = new System.Drawing.Size(141, 17);
            this.rbtnVeryActive.TabIndex = 3;
            this.rbtnVeryActive.TabStop = true;
            this.rbtnVeryActive.Text = "Very active (6 to 7 times)";
            this.rbtnVeryActive.UseVisualStyleBackColor = true;
            this.rbtnVeryActive.CheckedChanged += new System.EventHandler(this.rbtnVeryActive_CheckedChanged);
            // 
            // rbtnModeratlyActive
            // 
            this.rbtnModeratlyActive.AutoSize = true;
            this.rbtnModeratlyActive.Location = new System.Drawing.Point(3, 62);
            this.rbtnModeratlyActive.Name = "rbtnModeratlyActive";
            this.rbtnModeratlyActive.Size = new System.Drawing.Size(163, 17);
            this.rbtnModeratlyActive.TabIndex = 2;
            this.rbtnModeratlyActive.TabStop = true;
            this.rbtnModeratlyActive.Text = "Moderatly active(3 to 5 times)";
            this.rbtnModeratlyActive.UseVisualStyleBackColor = true;
            this.rbtnModeratlyActive.CheckedChanged += new System.EventHandler(this.rbtnModeratlyActive_CheckedChanged);
            // 
            // rbtnLightlyActivite
            // 
            this.rbtnLightlyActivite.AutoSize = true;
            this.rbtnLightlyActivite.Location = new System.Drawing.Point(3, 39);
            this.rbtnLightlyActivite.Name = "rbtnLightlyActivite";
            this.rbtnLightlyActivite.Size = new System.Drawing.Size(150, 17);
            this.rbtnLightlyActivite.TabIndex = 1;
            this.rbtnLightlyActivite.TabStop = true;
            this.rbtnLightlyActivite.Text = "Lightly active (1 to 3 times)";
            this.rbtnLightlyActivite.UseVisualStyleBackColor = true;
            this.rbtnLightlyActivite.CheckedChanged += new System.EventHandler(this.rbtnLightlyActivite_CheckedChanged);
            // 
            // rbtnSedentary
            // 
            this.rbtnSedentary.AutoSize = true;
            this.rbtnSedentary.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtnSedentary.Location = new System.Drawing.Point(3, 16);
            this.rbtnSedentary.Name = "rbtnSedentary";
            this.rbtnSedentary.Size = new System.Drawing.Size(225, 17);
            this.rbtnSedentary.TabIndex = 0;
            this.rbtnSedentary.TabStop = true;
            this.rbtnSedentary.Text = "Sedentary (little or no exercise)";
            this.rbtnSedentary.UseVisualStyleBackColor = true;
            this.rbtnSedentary.CheckedChanged += new System.EventHandler(this.rbtnSedentary_CheckedChanged);
            // 
            // lblYourBMRResult
            // 
            this.lblYourBMRResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYourBMRResult.Location = new System.Drawing.Point(568, 61);
            this.lblYourBMRResult.Name = "lblYourBMRResult";
            this.lblYourBMRResult.Size = new System.Drawing.Size(173, 23);
            this.lblYourBMRResult.TabIndex = 15;
            this.lblYourBMRResult.Text = "BMR result";
            this.lblYourBMRResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaintainResult
            // 
            this.lblMaintainResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMaintainResult.Location = new System.Drawing.Point(568, 82);
            this.lblMaintainResult.Name = "lblMaintainResult";
            this.lblMaintainResult.Size = new System.Drawing.Size(173, 19);
            this.lblMaintainResult.TabIndex = 16;
            this.lblMaintainResult.Text = "maintain result";
            this.lblMaintainResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLose1Result
            // 
            this.lblLose1Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLose1Result.Location = new System.Drawing.Point(641, 101);
            this.lblLose1Result.Name = "lblLose1Result";
            this.lblLose1Result.Size = new System.Drawing.Size(100, 15);
            this.lblLose1Result.TabIndex = 17;
            this.lblLose1Result.Text = "lose0,5";
            this.lblLose1Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLose2Result
            // 
            this.lblLose2Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLose2Result.Location = new System.Drawing.Point(571, 117);
            this.lblLose2Result.Name = "lblLose2Result";
            this.lblLose2Result.Size = new System.Drawing.Size(170, 20);
            this.lblLose2Result.TabIndex = 18;
            this.lblLose2Result.Text = "lose 1";
            this.lblLose2Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGain1Result
            // 
            this.lblGain1Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGain1Result.Location = new System.Drawing.Point(571, 142);
            this.lblGain1Result.Name = "lblGain1Result";
            this.lblGain1Result.Size = new System.Drawing.Size(170, 17);
            this.lblGain1Result.TabIndex = 19;
            this.lblGain1Result.Text = "gain 0,5";
            this.lblGain1Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGain2Result
            // 
            this.lblGain2Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGain2Result.Location = new System.Drawing.Point(570, 163);
            this.lblGain2Result.Name = "lblGain2Result";
            this.lblGain2Result.Size = new System.Drawing.Size(171, 20);
            this.lblGain2Result.TabIndex = 20;
            this.lblGain2Result.Text = "gain 1";
            this.lblGain2Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 634);
            this.Controls.Add(this.gboxBMR);
            this.Controls.Add(this.gboxFuel);
            this.Controls.Add(this.gboxBMIResult);
            this.Controls.Add(this.btnCalculateBMI);
            this.Controls.Add(this.gboxUnit);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtInch);
            this.Controls.Add(this.txtHeightCmFoot);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblYourName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculators (BMI, BMR and Fuel) by Patrik Österljung";
            this.gboxUnit.ResumeLayout(false);
            this.gboxUnit.PerformLayout();
            this.gboxBMIResult.ResumeLayout(false);
            this.gboxBMIResult.PerformLayout();
            this.gboxFuel.ResumeLayout(false);
            this.gboxFuel.PerformLayout();
            this.gboxFuelResults.ResumeLayout(false);
            this.gboxFuelResults.PerformLayout();
            this.gboxBMR.ResumeLayout(false);
            this.gboxBMR.PerformLayout();
            this.gboxActivtiLevel.ResumeLayout(false);
            this.gboxActivtiLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYourName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHeightCmFoot;
        private System.Windows.Forms.TextBox txtInch;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.GroupBox gboxUnit;
        private System.Windows.Forms.RadioButton rbtnImperial;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.GroupBox gboxBMIResult;
        private System.Windows.Forms.Label lblCategoryResult;
        private System.Windows.Forms.Label lblBMIResult;
        private System.Windows.Forms.Label lblWeightCategory;
        private System.Windows.Forms.Label lblYourBMI;
        private System.Windows.Forms.Label lblNormalWeight;
        private System.Windows.Forms.Label lblNormalBMI;
        private System.Windows.Forms.GroupBox gboxFuel;
        private System.Windows.Forms.GroupBox gboxFuelResults;
        private System.Windows.Forms.Label lblCostPerKmResult;
        private System.Windows.Forms.Label lblFuelLitSweMilResult;
        private System.Windows.Forms.Label lblFuelLitImpMileResult;
        private System.Windows.Forms.Label lblFuelLitKmResult;
        private System.Windows.Forms.Label lblFuelKmLitResult;
        private System.Windows.Forms.Label lblCostPerKm;
        private System.Windows.Forms.Label lblFuelSweMil;
        private System.Windows.Forms.Label FuelLitImperialMile;
        private System.Windows.Forms.Label lblFuelLitKm;
        private System.Windows.Forms.Label lblFuelKmLit;
        private System.Windows.Forms.Button btnCalculateFuel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFuelAmount;
        private System.Windows.Forms.TextBox txtPreviousOdometer;
        private System.Windows.Forms.TextBox txtCurrentOdometer;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblFuelAmount;
        private System.Windows.Forms.Label lblPreviosOdometer;
        private System.Windows.Forms.Label lblCurrentOdometer;
        private System.Windows.Forms.GroupBox gboxBMR;
        private System.Windows.Forms.GroupBox gboxActivtiLevel;
        private System.Windows.Forms.Label lblBMROutput;
        private System.Windows.Forms.Button btnCalculateBMR;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnExtraActive;
        private System.Windows.Forms.RadioButton rbtnVeryActive;
        private System.Windows.Forms.RadioButton rbtnModeratlyActive;
        private System.Windows.Forms.RadioButton rbtnLightlyActivite;
        private System.Windows.Forms.RadioButton rbtnSedentary;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblGain2;
        private System.Windows.Forms.Label lblGain1;
        private System.Windows.Forms.Label lblLose2;
        private System.Windows.Forms.Label lblLose1;
        private System.Windows.Forms.Label lblMaintain;
        private System.Windows.Forms.Label lblYourBMR;
        private System.Windows.Forms.Label lblGain2Result;
        private System.Windows.Forms.Label lblGain1Result;
        private System.Windows.Forms.Label lblLose2Result;
        private System.Windows.Forms.Label lblLose1Result;
        private System.Windows.Forms.Label lblMaintainResult;
        private System.Windows.Forms.Label lblYourBMRResult;
    }
}

