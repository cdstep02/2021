// Grade ID: K5060
// Program 2
// Due Date: 3/11/2021
// Course Section: CIS199-75
// Brief Description: Program calculates the order total for the customer based upon the people, distance traveled, and prep time.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //click event
        private void calcButton_Click(object sender, EventArgs e)
        {
            const int PER_PERSON = 1; //Represents per person price for company A
            const int FOUR = 4; // used to compare in if statement
            const int SEVEN = 7; // used to compare in if statement
            const double PER_PERSON3 = 0.25; //represents per person price for company C
            const int THOUSAND = 1000; //used to compare in if statement
            const int TEN = 10; //used to compare in if statement
            const int FIFTY = 50; //used to compare in if statement
            const int HUNDRED = 100; //used to compare in if statement
            const int TWO_HUNDRED = 200; //used to compare in if statement
            const double PER_MILE = .02; //represent distance per mile cost for company A
            const double PER_MILE2 = .10; //represents distance per mile cost for company B
            const double SEVEN_FIFTY = 750; //used to compare in if statemen
            const double FIVE_HUNDRED = 500; //used to compare in if statemen
            const int PREP_PRICE = 20; // represents prep cost for company A
            double compA, compB, compC; // represents the total 
            int peoplePriceCalc; //represents the people price for company A
            int prepPrice2 = 0; // represents the prep price for company B
            int prepPrice = 0; // represents the prep price for company A
            double perPerson = 0; //represents the per person variable for company A
            double perMile = 0; //represents the mile variable for comapany A
            double distancePriceCalc, distancePriceCalc2, distancePriceCalc3, deliveryPriceCalc, deliveryPriceCalc2, deliveryPriceCalc3, peoplePriceCalc3, peoplePriceCalc2;
            int numberOfPeople;//number of people input
            if (int.TryParse(peopleInput.Text, out numberOfPeople)) //tryparse to make sure an int is entered
            {
                peoplePriceCalc3 = PER_PERSON3 * numberOfPeople; //people calculation for company C
                if (numberOfPeople < TEN) //if statement to determine the per perosn rate for company B
                {
                    perPerson = 20;
                }
                else if (numberOfPeople >= TEN && numberOfPeople <= FIFTY)
                {
                    perPerson = 10;
                }
                else if (numberOfPeople < HUNDRED)
                {
                    perPerson = 5;
                }
                else if (numberOfPeople < TWO_HUNDRED)
                {
                    perPerson = 3;
                }
                else
                {
                    perPerson = .15;
                }
                peoplePriceCalc2 = perPerson * numberOfPeople; //people calcuation for company B
            }
            else
            {
                MessageBox.Show("Invalid number of people");
            }
            double numberOfMiles; //number of miles input
            if (double.TryParse(distanceInput.Text, out numberOfMiles)) //make sure double is entered if not a message box shows up
            {
                distancePriceCalc = PER_MILE * numberOfMiles; //distance calc for company A
                distancePriceCalc2 = PER_MILE2 * numberOfMiles; //distance calc for company B
                if (numberOfMiles >= THOUSAND) //if statement to determine what the per mile rate is for comp C
                {
                    perMile = 40;
                }
                else if (numberOfMiles >= SEVEN_FIFTY)
                {
                    perMile = 35;
                }
                else if (numberOfMiles >= FIVE_HUNDRED)
                {
                    perMile = 25;
                }
                else if (numberOfMiles >= TWO_HUNDRED)
                {
                    perMile = 15;
                }
                else
                {
                    perMile = 10;
                }
                distancePriceCalc3 = perMile; //distance calc for company C
            }

            else
            {
                MessageBox.Show("Invalid Distance");
            }
            int numberOfDeliveryDays; //delivery days input
            if(int.TryParse(deliveryInput.Text, out numberOfDeliveryDays)) // tryparse to make sure an int is entered. If not error occurs
            {
                if (numberOfDeliveryDays == 1)
                {
                    prepPrice = 20;
                }
                else if (numberOfDeliveryDays == 2)
                {
                    prepPrice = 17;
                }
                else if (numberOfDeliveryDays == 3)
                {
                    prepPrice = 15;
                }
                else if (numberOfDeliveryDays >= FOUR && numberOfDeliveryDays <= SEVEN)
                {
                    prepPrice = 10;
                }
                else
                {
                    prepPrice = 7;
                }
                deliveryPriceCalc3 = PREP_PRICE; //delivery price for company C
                if (numberOfDeliveryDays <= FOUR)
                {
                    prepPrice2 = 10;
                }
                else
                {
                    prepPrice2 = 7;
                }
                deliveryPriceCalc2 = prepPrice2; //delivery price for company B
            }
            else
            {
                MessageBox.Show("Invalid Delivery Days");
            }
            //the following code represents the calculations that took place to calculate the total cost of the companys. 
            peoplePriceCalc = PER_PERSON * numberOfPeople; //calc for people for company A
            distancePriceCalc = PER_MILE * numberOfMiles; //calc for distance for company A
            deliveryPriceCalc = prepPrice; //calc for delivery for company A
            compA = peoplePriceCalc + distancePriceCalc + deliveryPriceCalc; //company A calcualtion
            companyACost.Text = compA.ToString("C2");
            peoplePriceCalc2 = perPerson * numberOfPeople; //
            distancePriceCalc2 = PER_MILE2 * numberOfMiles;
            deliveryPriceCalc2 = prepPrice2;
            compB = peoplePriceCalc2 + distancePriceCalc2 + deliveryPriceCalc2;
            companyBCost.Text = compB.ToString("C2");
            peoplePriceCalc3 = PER_PERSON3 * numberOfPeople;
            distancePriceCalc3 = perMile;
            deliveryPriceCalc3 = PREP_PRICE;
            compC = peoplePriceCalc3 + distancePriceCalc3 + deliveryPriceCalc3;
            companyCCost.Text = compC.ToString("C2");
            if (compB < compA && compB < compC) //if statement to determine lowest cost of the companies
            {
                lowestCostLabel.Text = "The lowest cost company is: B";
            }
            if (compC < compA && compC < compB)
            {
                lowestCostLabel.Text = "The lowest cost company is: C";
            }
            if (compA < compB && compA < compC)
            {
                lowestCostLabel.Text = "The lowest cost company: A ";
            }



        }
    }}
