using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;


            String answer;


            Console.WriteLine("Welcome to calculator!");
            Console.WriteLine("Please enter first number");

            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What tipe of operation u want?");
            Console.WriteLine("Please Enter a for addition, s for subtraction, m for multiplication or d for division.");

            answer = Console.ReadLine();

            if (answer == "a") 

            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;

            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else 
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thanks for using calculator");

            Console.ReadKey();

        }
    }
}
