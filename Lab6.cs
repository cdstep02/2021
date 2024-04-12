//Grade ID: K5060
//Lab 6
//Due Date: 3/21/2021
//Course Section: CIS199-75-4212
//Brief Description: Using loops the code is able to present 4 different patterns of asterisks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ONE = 1; //constant is used for setting up the loops
            const int MAX_ROWS = 10; //this constant is used for setting up the loops
            Console.WriteLine("Pattern A");
            for (int row = 1; row <= MAX_ROWS; ++row) //this for loop sets the amount of iterations for the outer loop
            { 
                for (int star = 1; star <= row; ++star) //sets the iterations for the inner loop
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pattern B"); 
            for (int row2 = MAX_ROWS; row2 >= ONE; --row2) // this loop sets the number of iterations for the outer loop
            {
                for (int star2 = 1; star2 <= row2; ++star2) //this loop sets the iterations for the inner loop
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pattern C");
            for (int row3 = 10; row3 >= ONE; --row3) //this loop sets the number of iterations for the outer loop
            {
                for (int space = 1; space <= MAX_ROWS - row3; ++space) //this loop sets the number of iterations for the  1st inner loop
                {
                    Console.Write(" ");
                }
                for ( int star3 = 1; star3 <= row3; ++star3) //this loop sets the number of iterations for the 2nd inner loop
                {
                    Console.Write("*");
                }
                Console.WriteLine();            
            }
            Console.WriteLine("Pattern D");
            for ( int row4 = ONE; row4 <= MAX_ROWS; ++row4) //this loop sets the number of iterations for the outer loop
            {
                for (int space2 = 1; space2 <= MAX_ROWS - row4; ++space2) //this loop sets the number of iterations for the 1st inner loop
                {
                    Console.Write(" ");
                }
                for(int star4 = 1; star4 <= row4; ++star4) //this loop sets the number of iterations for the 2nd inner loop
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}