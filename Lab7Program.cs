//Grade ID: K5060
//Lab number: 7
//Due Date: 4/4/2021
//Course section: CIS199-75
//Brief Description: Program prompts user to enter a positive integer, validates the users input to make sure its correct, and then outputs a square based upon the users input. If the user enters an incorrect value they will be prompted to enter another number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctUserInput; //used to validate the users input
            int convertedNum; //represents the users converted input
            Write("Enter positive number:");
            correctUserInput = (int.TryParse(ReadLine(), out convertedNum) && convertedNum > 0); //tryparse validates the users input 
            while (!correctUserInput) //the while loops purpose is to decide the course of action after the tryparse statement whether the input is correct or incorrect
            {
                Write("Incorrect input. Please enter positive number:");
                correctUserInput = (int.TryParse(ReadLine(), out convertedNum) && convertedNum > 0); //body of while loop will loop until user enters a correct input
            }
            ShowSquareOfStars(convertedNum); //invokes the method if the user input is correct



        }
        private static void ShowSquareOfStars(int input) //method declaration
        {
            for(int x = 0; x < input; ++x) //sets the number of iterations for the loop
            {
                for(int y = 0; y < input; ++y) //sets the number of asterisks outputted
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}
