//Grade ID: K5060
//Lab 3
//Due Date: 2/14/2021
//Course Section: CIS 199-75
//Brief Description: Windows Forms Application calculates and displays the volume, diameter, and surface area values of a sphere given its user entered radius.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //This click event calculates the geometric values of a sphere given the user entered radius
        private void calcButton_Click(object sender, EventArgs e)
        {
            //In the following code constants will be named and variables will be declared
            const double TWO = 2;
            const double THREE = 3;
            const double FOUR = 4;
            double convertedRadius; //This variable represents the user input being converted into a double
            double diameter; //This variable represents the calculation for the diameter of the sphere
            double surfaceArea; //This variable represents the calculation for the surface area of the sphere
            double volume; //This variable represents the calculation for the volume of the sphere
            
            //In the following code the input will be collected and the calculations will be made
            convertedRadius = Convert.ToDouble(radiusInputValue.Text);
            diameter = convertedRadius * TWO;
            diameterValue.Text = diameter.ToString("F2");
            surfaceArea = FOUR * Math.PI * Math.Pow(convertedRadius, TWO);
            surfaceAreaValue.Text = surfaceArea.ToString("F2");
            volume = FOUR * Math.PI * Math.Pow(convertedRadius, THREE) / THREE;
            volumeValue.Text = volume.ToString("F2");
        }
    }
}
