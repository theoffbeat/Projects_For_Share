using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public decimal weightKG;
        decimal weightPound;
        decimal weightMultiplier;
        decimal weightFormula;

        decimal heightCM;
        const decimal heightInches = 2.54M;
        decimal heightMultiplier;
        decimal heightFormula;

        decimal age;
        decimal ageMultiplier;
        decimal ageFormula;

        const decimal sedentary = 1.2M;
        const decimal lightlyActive = 1.375M;
        const decimal moderately = 1.55M;
        const decimal veryActive = 1.725M;
        const decimal extremelyActive = 1.9M;

        public decimal maleVar;
        public decimal femaleVar;

        class weight
        {
            public void test()
            {
                
            }
        }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        public void nudCalories_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void inputTab(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lenghtOfAnswer = answerBox.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }
        }

        private void inputTab(object sender, MouseEventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lenghtOfAnswer = answerBox.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }            
        }

        private void nudWeight_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public decimal gender()
        {
            if (radioMale.Checked)
            {
                if (radioMetric.Checked)
                    nudCalories.Value = 66 + (13.7M * nudWeight.Value) + (5 * nudHeight.Value) - (6.8M * nudAge.Value);
                else if (radioImperial.Checked)
                    nudCalories.Value = 66 + (13.7M * (nudWeight.Value * 0.453592M)) + (5 * (nudHeight.Value * heightInches)) - (6.8M * nudAge.Value);
            }
            else if (radioFemale.Checked)
            {
                if (radioMetric.Checked)
                    nudCalories.Value = 655 + (9.6M * nudWeight.Value) + (1.8M * nudHeight.Value) - (4.7M * nudAge.Value);
                else if (radioImperial.Checked)
                    nudCalories.Value = 655 + (9.6M * (nudWeight.Value * 0.453592M)) + (1.8M * (nudHeight.Value * heightInches)) - (4.7M * nudAge.Value);
            }
            return nudCalories.Value;
        }

        private void btnCalc_Click_1(object sender, EventArgs e)
        {
            if (radioSedentary.Checked)
            {
                nudCalories.Value = gender();
                nudCalories.Value *= sedentary;
            }
            else if (radioLightly.Checked)
            {
                nudCalories.Value = gender();
                nudCalories.Value *= lightlyActive;
            }
            else if (radioModerately.Checked)
            {
                nudCalories.Value = gender();
                nudCalories.Value *= moderately;
            }
            else if (radioVery_Active.Checked)
            {
                nudCalories.Value = gender();
                nudCalories.Value *= veryActive;
            }
            else if (radioExtremely.Checked)
            {
                nudCalories.Value = gender();
                nudCalories.Value *= extremelyActive;
            }
        }

        private void radioImperial_CheckedChanged(object sender, EventArgs e)
        {
            if (radioImperial.Checked)
                lblUnitName.Text = "Imperial";
            else
                lblUnitName.Text = "Metric";
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (radioImperial.Checked)
                lblUnitName.Text = "Imperial";
            else
                lblUnitName.Text = "Metric";
        }
    }
}
