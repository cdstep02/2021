//Grade ID: K5060
//Program 1
//Due Date: 2/16/2021
//Course Section: CIS199-75
//Brief Description: Windows forms application that is used for estimating the materials and labor costs for the landscaping and garden design company.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            const int YES = 1, NO = 0;
            const int FIRST_ORDER = 50; //first garden order fee
            double gardenWidthFeet; //represents the converted user input
            double gardenLengthFeet; // represents the converted user input
            double soilPrice; //represents the soil price calculation
            double squareYards; //represents the square yards conversion
            double soilCost; //represents the soil cost calculation
            double fertilizerCost; //represents the fertilizer cost calculation
            double laborCost; //represents the labor cost calculation
            double totalCost; //represents the total cost calculation
            double wastePercent; //represents the waste percentage number
            gardenWidthFeet = Convert.ToDouble(gardenWidthTxt.Text);
            gardenLengthFeet = Convert.ToDouble(gardenLengthTxt.Text);
            const double CONVERSION = 9;
            squareYards = gardenWidthFeet * gardenLengthFeet / CONVERSION;
            squareYardsOutput.Text = squareYards.ToString("F1");
            soilPrice = Convert.ToDouble(soilPriceTxt.Text);
            const double WASTE_PERCENTAGE = .10;
            wastePercent = (soilPrice * squareYards) * WASTE_PERCENTAGE;
            soilCost = soilPrice * squareYards + wastePercent;
            soilCostOutput.Text = soilCost.ToString("C2");
            const double FERTILIZER_COST = 4.25;
            fertilizerCost = FERTILIZER_COST * squareYards;
            fertilizerCostOutput.Text = fertilizerCost.ToString("C2");
            const double LABOR = 3.25; 
            laborCost = LABOR * squareYards + FIRST_ORDER;
            laborCostOutput.Text = laborCost.ToString("C2");
            totalCost = soilCost + fertilizerCost + laborCost;
            totalCostOutput.Text = totalCost.ToString("C2");

        }
    }
}

