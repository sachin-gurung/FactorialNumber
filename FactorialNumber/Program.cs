using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    //Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
    //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;

            for (int i = 1; i <=number ; i++)
            
                factorial = factorial * i;
                Console.WriteLine("Factorial of " + number + " is :" + factorial);           
         
        }
    }
}
/*
Enter any number: 6
Factorial of 6 is :720
Press any key to continue . . .
*/
