using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC_ARITHMETIC_OPERATIONS_ON_2_INTS
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialise variables to hold inputs and arithmetic option
            int Num1, Num2, result;
            char option;

            // get first input and convert to int
            Console.Write("Enter the First Number : ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            // get second input and convert to int
            Console.Write("Enter the Second Number : ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            // display the arithmetic operations on the console
            Console.WriteLine("OPERATIONS AVAILABLE");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the Operation you want to perform. Eg 1: ");
            // take desired option from user
            option = Convert.ToChar(Console.ReadLine());

            // run switch
            switch (option)
            {
                case '1':
                    result = Num1 + Num2;
                    Console.WriteLine("Adding {0} and {1} gives {2}.", Num1, Num2, result);
                    break;
                case '2':
                    result = Num1 - Num2;
                    Console.WriteLine("Difference of {0} and {1} gives {2}.", Num1, Num2, result);
                    break;
                case '3':
                    result = Num1 * Num2;
                    Console.WriteLine("Multiplying {0} and {1} gives {2}.", Num1, Num2, result);
                    break;
                case '4':
                    try
                    {
                        result = Num1 / Num2;
                        Console.WriteLine("The result of Division is : {0}", result);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Make sure to enter only non-zero integers...");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.WriteLine("\n\nPress any key...");
            Console.Read();
        }
    }
}
