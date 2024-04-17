using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linear_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void covertingButton_Click(object sender, EventArgs e)
        {
            double answer;

            int conversion = Convert.ToInt32(choiceBox.Text);
            double value = Convert.ToInt32(valueBox.Text);

            switch (conversion)
            {
                case 1:
                    answer = InchesToCm(value);
                    outputLabel.Text = $"The answer is: {answer}";
                    break;
                case 2:
                    answer = feetToCm(value);
                    outputLabel.Text = $"The answer is: {answer}";
                    break;
                case 3:
                    answer = yardsToM(value);
                    outputLabel.Text = $"The answer is: {answer}";
                    break;
                case 4:
                    answer = milesToKm(value);
                    outputLabel.Text = $"The answer is: {answer}";
                    break;

            }
        }
        public double InchesToCm(double value)
        {
            double inchToCm = 2.54;
            double answer = value * inchToCm;

            return answer;
        }

        public double feetToCm(double value)
        {
            double feetToCm = 30.48;
            double answer = value * feetToCm;

            return answer;
        }

        public double yardsToM(double value)
        {
            double yardsToM = 0.91;
            double answer = value * yardsToM;

            return answer;
        }

        public double milesToKm(double value)
        {
            double milestoKm = 1.6;
            double answer = value * milestoKm;

            return answer;
        }
    }
}   
        
   





