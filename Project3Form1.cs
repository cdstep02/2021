//Grade ID:K5060
//Program 3
//Due date: 4/1/2021 April Fools Day!
//Course Section: CIS199-75
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //the following are my arrays declared outside the method so they must be constants and static
        static string[] regions = {"NE", "NW", "SE", "SW"};
        static double[] shipmentRates = { .06, .0717, .07, .0874 };
        static double[] items = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };
        static double[] costPerPound = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };
        static double[] pounds = { 0, 6, 11, 21 };
        static double[] discounts = { 0, .05, .1, .15 };
        
        private void calcButton_Click(object sender, EventArgs e)
        {
            const int ZERO = 0; // this constant is used to make sure the users weight isn't below or at 0
            //bool values will be used later for the if statements and loops that will search/range check arrays
            bool correctItem = false; //
            bool correctWeight = false;
            bool correctState = false;
            const int TENTHOUSAND1 = 10001; //this constant is used so I can compare the user item input to the lowest it could be
            const int TENTHOUSAND7 = 10007; //this constant is used to compare the user item input number to the highest it could be
            

            if(farmComboBox.SelectedIndex >= 0) //this if statement makes sure user selects a region
            {
               // int selectedIndex = farmComboBox.SelectedIndex;  //discarded code that I didn't need, figured out a new way
                //double selectedShipmentFee = shipmentRates[selectedIndex]; //discarded code that I didn't need, figured out a new way
                //the following tryparse ensures that the correct item number is entered, if not the GUI will display a message box
                if (int.TryParse(itemInput.Text, out int convertItemInput) && convertItemInput >= TENTHOUSAND1 && convertItemInput <= TENTHOUSAND7) 
                {
                    //the following tryparse ensures that the correct quantity is entered, if not the GUI will display a message box
                    if(int.TryParse(quantityInput.Text, out int convertPounds) && convertItemInput >= ZERO)
                    {
                        double perPound = 0; //will hold corresponding array value
                        //the following for loop searches the items array for the correct item
                        for( int x = 0; x < items.Length && !correctItem; ++x) 
                        {
                            //the following if statement matches the user input to an item number, than it goes and finds the corresponding value in the costPerPound array
                            if(items[x] == convertItemInput)
                            {
                                correctItem = true;
                                perPound = costPerPound[x]; 
                            }
                        }
                        double shipmentFee = 0; //will hold corresponding array value
                        //the following for loop searches the shipments array
                        for (int y = 0; y < shipmentRates.Length && !correctState; ++y)
                        {
                            //the following if statement matches the user selected region withe the corresponding shipment rate
                            if(regions[y] == farmComboBox.Text)
                            {
                                correctState = true;
                                shipmentFee = shipmentRates[y];
                            }
                            
                        }
                        //code below performs a lower limit range check 
                        double discountPercentages = 0; // this variable will hold the corresponding array value to the users input
                        int rangeCheck = pounds.Length - 1; 
                        //the following while statment searches for the user inputted quantity
                        while(rangeCheck >= 0 && !correctWeight)
                        {
                            //if statement 
                            if(convertPounds >= pounds[rangeCheck])
                            {
                                correctWeight = true;
                            }
                            else
                            {
                                --rangeCheck;
                            }
                        }
                        //if statement matches the the rangechecked value to the corresponding spot in the discounts array
                        if(correctWeight) 
                        {
                            discountPercentages = discounts[rangeCheck];
                        }
                        //the following code performs the calculations for the initial cost, discounted cost, shipment cost, and total price
                        double initalCost = convertPounds * perPound; //performs the initial cost calculation
                        double discountedCost = (1 - discountPercentages) * initalCost; //performs the discounted cost calculation
                        double shipmentCost = shipmentFee * discountedCost; //performs the shipment cost calculation
                        double totalPrice = discountedCost + shipmentCost; //performs the total price calculation
                        //the following code outputs the values from the calculations
                        intitalCostOutput.Text = initalCost.ToString("C2");
                        discountedCostOutput.Text = discountedCost.ToString("C2");
                        shipmentCostOutput.Text = shipmentCost.ToString("C2");
                        totalPriceOutPut.Text = totalPrice.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Quantity Entered"); // message is displayed when an incorrect quantity is entered
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect Item Number Entered"); //message is displayed when an incorrect item number is entered
                }
            }
            else
            {
                MessageBox.Show("Please Select Region"); //message is displayed if the user doesn't select a region
            }
        }
    }
}
