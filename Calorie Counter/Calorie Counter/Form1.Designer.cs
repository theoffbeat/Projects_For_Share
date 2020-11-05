namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lblMale = new System.Windows.Forms.Label();
            this.lblFemale = new System.Windows.Forms.Label();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMetric = new System.Windows.Forms.Label();
            this.lblImperial = new System.Windows.Forms.Label();
            this.radioImperial = new System.Windows.Forms.RadioButton();
            this.radioMetric = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioSedentary = new System.Windows.Forms.RadioButton();
            this.radioLightly = new System.Windows.Forms.RadioButton();
            this.radioModerately = new System.Windows.Forms.RadioButton();
            this.radioVery_Active = new System.Windows.Forms.RadioButton();
            this.radioExtremely = new System.Windows.Forms.RadioButton();
            this.lblExtremely_Active = new System.Windows.Forms.Label();
            this.lblVery_Active = new System.Windows.Forms.Label();
            this.lblModerately_Active = new System.Windows.Forms.Label();
            this.lblLightly_Active = new System.Windows.Forms.Label();
            this.lblSedentary = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblUnits = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeight = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCalc = new System.Windows.Forms.Button();
            this.nudCalories = new System.Windows.Forms.NumericUpDown();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalories)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMale.Location = new System.Drawing.Point(6, 7);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(51, 24);
            this.lblMale.TabIndex = 0;
            this.lblMale.Text = "Male";
            // 
            // lblFemale
            // 
            this.lblFemale.AutoSize = true;
            this.lblFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemale.Location = new System.Drawing.Point(6, 46);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(74, 24);
            this.lblFemale.TabIndex = 1;
            this.lblFemale.Text = "Female";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(86, 53);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(14, 13);
            this.radioFemale.TabIndex = 2;
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Checked = true;
            this.radioMale.Location = new System.Drawing.Point(86, 13);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(14, 13);
            this.radioMale.TabIndex = 3;
            this.radioMale.TabStop = true;
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioMale);
            this.panel1.Controls.Add(this.radioFemale);
            this.panel1.Controls.Add(this.lblFemale);
            this.panel1.Controls.Add(this.lblMale);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 85);
            this.panel1.TabIndex = 4;
            // 
            // lblMetric
            // 
            this.lblMetric.AutoSize = true;
            this.lblMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric.Location = new System.Drawing.Point(7, 5);
            this.lblMetric.Name = "lblMetric";
            this.lblMetric.Size = new System.Drawing.Size(61, 24);
            this.lblMetric.TabIndex = 5;
            this.lblMetric.Text = "Metric";
            // 
            // lblImperial
            // 
            this.lblImperial.AutoSize = true;
            this.lblImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImperial.Location = new System.Drawing.Point(7, 46);
            this.lblImperial.Name = "lblImperial";
            this.lblImperial.Size = new System.Drawing.Size(76, 24);
            this.lblImperial.TabIndex = 6;
            this.lblImperial.Text = "Imperial";
            // 
            // radioImperial
            // 
            this.radioImperial.AutoSize = true;
            this.radioImperial.Location = new System.Drawing.Point(90, 52);
            this.radioImperial.Name = "radioImperial";
            this.radioImperial.Size = new System.Drawing.Size(14, 13);
            this.radioImperial.TabIndex = 7;
            this.radioImperial.TabStop = true;
            this.radioImperial.UseVisualStyleBackColor = true;
            this.radioImperial.CheckedChanged += new System.EventHandler(this.radioImperial_CheckedChanged);
            // 
            // radioMetric
            // 
            this.radioMetric.AutoSize = true;
            this.radioMetric.Checked = true;
            this.radioMetric.Location = new System.Drawing.Point(90, 8);
            this.radioMetric.Name = "radioMetric";
            this.radioMetric.Size = new System.Drawing.Size(14, 13);
            this.radioMetric.TabIndex = 8;
            this.radioMetric.TabStop = true;
            this.radioMetric.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.radioMetric);
            this.panel3.Controls.Add(this.radioImperial);
            this.panel3.Controls.Add(this.lblImperial);
            this.panel3.Controls.Add(this.lblMetric);
            this.panel3.Location = new System.Drawing.Point(12, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 85);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioSedentary);
            this.panel2.Controls.Add(this.radioLightly);
            this.panel2.Controls.Add(this.radioModerately);
            this.panel2.Controls.Add(this.radioVery_Active);
            this.panel2.Controls.Add(this.radioExtremely);
            this.panel2.Controls.Add(this.lblExtremely_Active);
            this.panel2.Controls.Add(this.lblVery_Active);
            this.panel2.Controls.Add(this.lblModerately_Active);
            this.panel2.Controls.Add(this.lblLightly_Active);
            this.panel2.Controls.Add(this.lblSedentary);
            this.panel2.Location = new System.Drawing.Point(151, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 176);
            this.panel2.TabIndex = 11;
            // 
            // radioSedentary
            // 
            this.radioSedentary.AutoSize = true;
            this.radioSedentary.Checked = true;
            this.radioSedentary.Location = new System.Drawing.Point(160, 15);
            this.radioSedentary.Name = "radioSedentary";
            this.radioSedentary.Size = new System.Drawing.Size(14, 13);
            this.radioSedentary.TabIndex = 13;
            this.radioSedentary.TabStop = true;
            this.radioSedentary.UseVisualStyleBackColor = true;
            // 
            // radioLightly
            // 
            this.radioLightly.AutoSize = true;
            this.radioLightly.Location = new System.Drawing.Point(160, 47);
            this.radioLightly.Name = "radioLightly";
            this.radioLightly.Size = new System.Drawing.Size(14, 13);
            this.radioLightly.TabIndex = 14;
            this.radioLightly.TabStop = true;
            this.radioLightly.UseVisualStyleBackColor = true;
            // 
            // radioModerately
            // 
            this.radioModerately.AutoSize = true;
            this.radioModerately.Location = new System.Drawing.Point(160, 83);
            this.radioModerately.Name = "radioModerately";
            this.radioModerately.Size = new System.Drawing.Size(14, 13);
            this.radioModerately.TabIndex = 12;
            this.radioModerately.TabStop = true;
            this.radioModerately.UseVisualStyleBackColor = true;
            this.radioModerately.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioVery_Active
            // 
            this.radioVery_Active.AutoSize = true;
            this.radioVery_Active.Location = new System.Drawing.Point(160, 115);
            this.radioVery_Active.Name = "radioVery_Active";
            this.radioVery_Active.Size = new System.Drawing.Size(14, 13);
            this.radioVery_Active.TabIndex = 7;
            this.radioVery_Active.TabStop = true;
            this.radioVery_Active.UseVisualStyleBackColor = true;
            // 
            // radioExtremely
            // 
            this.radioExtremely.AutoSize = true;
            this.radioExtremely.Location = new System.Drawing.Point(160, 146);
            this.radioExtremely.Name = "radioExtremely";
            this.radioExtremely.Size = new System.Drawing.Size(14, 13);
            this.radioExtremely.TabIndex = 6;
            this.radioExtremely.TabStop = true;
            this.radioExtremely.UseVisualStyleBackColor = true;
            // 
            // lblExtremely_Active
            // 
            this.lblExtremely_Active.AutoSize = true;
            this.lblExtremely_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtremely_Active.Location = new System.Drawing.Point(3, 138);
            this.lblExtremely_Active.Name = "lblExtremely_Active";
            this.lblExtremely_Active.Size = new System.Drawing.Size(150, 24);
            this.lblExtremely_Active.TabIndex = 5;
            this.lblExtremely_Active.Text = "Extremely Active";
            // 
            // lblVery_Active
            // 
            this.lblVery_Active.AutoSize = true;
            this.lblVery_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVery_Active.Location = new System.Drawing.Point(3, 107);
            this.lblVery_Active.Name = "lblVery_Active";
            this.lblVery_Active.Size = new System.Drawing.Size(105, 24);
            this.lblVery_Active.TabIndex = 4;
            this.lblVery_Active.Text = "Very Active";
            // 
            // lblModerately_Active
            // 
            this.lblModerately_Active.AutoSize = true;
            this.lblModerately_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModerately_Active.Location = new System.Drawing.Point(3, 75);
            this.lblModerately_Active.Name = "lblModerately_Active";
            this.lblModerately_Active.Size = new System.Drawing.Size(103, 24);
            this.lblModerately_Active.TabIndex = 3;
            this.lblModerately_Active.Text = "Moderately";
            // 
            // lblLightly_Active
            // 
            this.lblLightly_Active.AutoSize = true;
            this.lblLightly_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLightly_Active.Location = new System.Drawing.Point(3, 39);
            this.lblLightly_Active.Name = "lblLightly_Active";
            this.lblLightly_Active.Size = new System.Drawing.Size(119, 24);
            this.lblLightly_Active.TabIndex = 2;
            this.lblLightly_Active.Text = "Lightly Active";
            // 
            // lblSedentary
            // 
            this.lblSedentary.AutoSize = true;
            this.lblSedentary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSedentary.Location = new System.Drawing.Point(3, 7);
            this.lblSedentary.Name = "lblSedentary";
            this.lblSedentary.Size = new System.Drawing.Size(95, 24);
            this.lblSedentary.TabIndex = 1;
            this.lblSedentary.Text = "Sedentary";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.nudAge);
            this.panel4.Controls.Add(this.nudHeight);
            this.panel4.Controls.Add(this.lblAge);
            this.panel4.Controls.Add(this.lblHeight);
            this.panel4.Controls.Add(this.nudWeight);
            this.panel4.Controls.Add(this.lblWeight);
            this.panel4.Location = new System.Drawing.Point(352, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 176);
            this.panel4.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblUnitName);
            this.panel6.Controls.Add(this.lblUnits);
            this.panel6.Location = new System.Drawing.Point(7, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 32);
            this.panel6.TabIndex = 8;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(4, 4);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(56, 24);
            this.lblUnits.TabIndex = 0;
            this.lblUnits.Text = "Units:";
            // 
            // nudAge
            // 
            this.nudAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAge.Location = new System.Drawing.Point(89, 140);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(120, 29);
            this.nudAge.TabIndex = 7;
            this.nudAge.Enter += new System.EventHandler(this.inputTab);
            this.nudAge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputTab);
            // 
            // nudHeight
            // 
            this.nudHeight.DecimalPlaces = 2;
            this.nudHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHeight.Location = new System.Drawing.Point(89, 97);
            this.nudHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 29);
            this.nudHeight.TabIndex = 6;
            this.nudHeight.Enter += new System.EventHandler(this.inputTab);
            this.nudHeight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputTab);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(3, 142);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 24);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(3, 99);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(65, 24);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 2;
            this.nudWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWeight.Location = new System.Drawing.Point(89, 51);
            this.nudWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(120, 29);
            this.nudWeight.TabIndex = 3;
            this.nudWeight.ValueChanged += new System.EventHandler(this.nudWeight_ValueChanged);
            this.nudWeight.Enter += new System.EventHandler(this.inputTab);
            this.nudWeight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputTab);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(3, 53);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(69, 24);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnCalc);
            this.panel5.Controls.Add(this.nudCalories);
            this.panel5.Controls.Add(this.lblCalories);
            this.panel5.Location = new System.Drawing.Point(12, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(572, 78);
            this.panel5.TabIndex = 13;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(429, 18);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(96, 46);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click_1);
            // 
            // nudCalories
            // 
            this.nudCalories.DecimalPlaces = 2;
            this.nudCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCalories.Location = new System.Drawing.Point(193, 25);
            this.nudCalories.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudCalories.Name = "nudCalories";
            this.nudCalories.Size = new System.Drawing.Size(120, 29);
            this.nudCalories.TabIndex = 7;
            this.nudCalories.ThousandsSeparator = true;
            this.nudCalories.ValueChanged += new System.EventHandler(this.nudCalories_ValueChanged);
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.Location = new System.Drawing.Point(3, 27);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(149, 24);
            this.lblCalories.TabIndex = 0;
            this.lblCalories.Text = "Calories Per Day";
            // 
            // lblUnitName
            // 
            this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.Location = new System.Drawing.Point(67, 4);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(100, 23);
            this.lblUnitName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 298);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Harris-Benedict Formula";
            this.Activated += new System.EventHandler(this.OnLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMetric;
        private System.Windows.Forms.Label lblImperial;
        private System.Windows.Forms.RadioButton radioImperial;
        private System.Windows.Forms.RadioButton radioMetric;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLightly_Active;
        private System.Windows.Forms.Label lblSedentary;
        private System.Windows.Forms.Label lblExtremely_Active;
        private System.Windows.Forms.Label lblVery_Active;
        private System.Windows.Forms.Label lblModerately_Active;
        private System.Windows.Forms.RadioButton radioModerately;
        private System.Windows.Forms.RadioButton radioVery_Active;
        private System.Windows.Forms.RadioButton radioExtremely;
        private System.Windows.Forms.RadioButton radioSedentary;
        private System.Windows.Forms.RadioButton radioLightly;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Button btnCalc;
        public System.Windows.Forms.NumericUpDown nudCalories;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblUnitName;

    }
}

