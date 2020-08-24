using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            //Compiler Error since there wasnt a semi-colon
            int i = 0;

            // loop through the numbers 1 through 10
            // By declaring allNumbers Outside of the loop we can access it.
            string allNumbers = null;
            for (i = 1; i < 10; ++i)
            {
               
                // declare string to hold all numbers
                //By declaring allNumbers Outside of the loop we can access it.

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                // by putting a comma after the "/" solves the bug
                
                Console.Write(i + "/", + i - 1 + " = ");

                // output the calculation based on the numbers
                // Console.WriteLine(i / (i - 1));
                // It threw an error, trying to divide by 0

                Console.WriteLine(i / (i - 2));

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                i = i + 1;

                
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            //Syntax Error: allNumbers Is a For-Loop Exclusive.
            //By making it a string, we can still set it to null
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}
