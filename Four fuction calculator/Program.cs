using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_fuction_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1;
           num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an opretor: ");
            string op = Console.ReadLine();
            Console.Write("Enter the second number: ");
            double num2;
            num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
        
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2); 
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2); 
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
            Console.ReadLine();

        }
    }
}
