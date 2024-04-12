//Grade ID: K5060
//Lab 4
//Due date: 2/21/2021
//Course Section: CIS199-75
//Breif Description: Program makes decisions for fake university based on GPA and admission test score

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //variables for running totals
        int runningTotal1 = 0;
        int runningTotal2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //click handle event below
        private void decisionButton_Click(object sender, EventArgs e)
        {
            const double GPA = 3; //used in if else decisions below
            const  int TEST_SCORE1 = 60; //test score for if statement below
            const int TEST_SCORE2 = 80; //test score for if else statment below
            double gpa; //represents the user input being converted to double
            int testScore; //represents user input being converted to an integer
            //these represent conversions
            gpa = double.Parse(gpaInput.Text);
            testScore = int.Parse(testScoreInput.Text);
            //if else statement below make the accept reject decisons
            if (gpa >= GPA && testScore >= TEST_SCORE1)
            {
                admissionOutput.Text = ("Accept");
            }
            else if (gpa < GPA && testScore >= TEST_SCORE2)
            {
                admissionOutput.Text = ("Accept");
            }
            else
            {
                admissionOutput.Text = ("Reject");
            }
            if (double.TryParse(gpaInput.Text, out gpa) && (gpa >= 0) && (gpa <= 4)) 
            {
                
            }
            else
            {
                MessageBox.Show("Invalid input value");
            }
            if (int.TryParse(testScoreInput.Text, out testScore) && (testScore >= 0) && (testScore <= 100))
                {

                }
            else
            {
                MessageBox.Show("Invalid input value");
            }
        }
    }
}
