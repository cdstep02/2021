//Grade ID: K5060
//Program 4
//Due Date: 4/18/2021
//Course Seection: CIS199-75
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog4
{
    class Program
    {
        static void Main(string[] args)
        { 
            RepairRecord[] array = new RepairRecord[7];//array of references
            RepairRecord test = new RepairRecord(100000  , "Ford GT  ", "AE00000090  ", 2020  , 180  , "Peter Parker  ", true); //test
            WriteLine(test.ToString()); //Was not able to output on separate lines
            WriteLine(test.ToString()); //was not able to output on seperate lines
            WriteLine(test.ToString());
            WriteLine(test.ToString());
            WriteLine(test.ToString());
            WriteLine(test.ToString());

        }
        public static void OutputRepairRecords(ref RepairRecord[] arr)
        {
            foreach(RepairRecord test in arr)
            {
                WriteLine(test.ToString());

            }
            //could not invoke CalcCost
                //CalcCost
            
        }
    }
}
