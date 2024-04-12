//Grade ID: K5060
//Lab 5
// Due Date: 3/07/2021
// Course Section: CIS199-75
// Brief Description: Program prompts user to enter temperatures within a specified range then finds the mean of the temperatures. If temperature is not in specified range an error will occure. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab5
{
    class Program
    {
        public static void Main(string[] args)
        {
            const double SENTINEL = 999; // Constant ends the loop. Sentinel value
            const double HIGH = 130; // Costant represents high temperature
            const double LOW = -20; // constant represents low temperature
            double temp; // represents the input converted to a double
            string inputString;
            double correctTemp = 0; //represent the amount of correct temperatures entered
            double total = 0; //represents the temperatures added together
            double mean; // represents the mean calculation
            WriteLine("Enter temperature from -20 to 130 (999 to stop)");
            Write("Enter temperature:");
            inputString = ReadLine();
            if (double.TryParse(inputString, out temp)) //ensure only numbers are entered 
            {
                while (temp != SENTINEL) //when the temperature entered is not the sentinel value
                {
                    while (temp <= HIGH && temp >= LOW) // make sure temperature is within specified range.
                    {
                        correctTemp = correctTemp + 1;
                        total = total + temp;
                        Write("Enter temperature:");
                        inputString = ReadLine();
                        temp = double.Parse(inputString);
                    }
                    WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
                }
                WriteLine("You entered {0} valid temperatures.", correctTemp);
                mean = total / correctTemp; //mean calculation
                WriteLine("The mean temperature is {0} degrees", mean.ToString("F1"));
            }
            else
            {
                WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
            }
        }
    }
}
