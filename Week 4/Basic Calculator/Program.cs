// Write a program that prompts users to enter two numbers and operator (-,+,*,/) 
// and performs operations accordingly. 

using System; 
using System.Data.Common; 
namespace Hello  

{  
    class Program  
    {
        static void Main(string[] args)

        {
            // asking user to enter two number 

            Console.Write("Enter the first number: ");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");

            double num2 = Convert.ToDouble(Console.ReadLine());

            // asking use to input operator 

            Console.Write("Enter a single Operator (-,+,*,/): ");

            char Operator = Convert.ToChar(Console.ReadLine());

            // checking for valid operator 

            // doing operations 

            if (Operator == '-')

            {
                Console.WriteLine("Answer is : " + (num1 - num2));
            }

            else if (Operator == '+')

            {
                Console.WriteLine("Answer is : " + (num1 + num2));
            }

            else if (Operator == '*')
            {
                Console.WriteLine("Answer is : " + (num1 * num2));
            }

            else if (Operator == '/')
            {
                Console.WriteLine("Answer is : " + (num1 / num2));
            }

            else
            {
                Console.WriteLine("Please, enter a valid operator");
            }
        }  
        
    }  

} 