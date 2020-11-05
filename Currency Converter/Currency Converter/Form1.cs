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
        decimal dollarAmount;
        decimal rate = 0.74M;
        decimal euroAmount; 

        
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            euroAmount = numericUpDown1.Value;
            dollarAmount= euroAmount / rate;
        }

        private void input(object sender, EventArgs e)
        {
            NumericUpDown output = sender as NumericUpDown;
            if (output != null)
            {
                int lengthOfAnswer = output.Value.ToString().Length;
                output.Select(0, lengthOfAnswer);
            }
        }

        private void output(object sender, MouseEventArgs e)
        {
            
            numericUpDown2.Value = dollarAmount;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void output2(object sender, KeyPressEventArgs e)
        {
            numericUpDown2.Value = dollarAmount;
        }


    }
}
