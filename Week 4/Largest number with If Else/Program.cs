// Write a C# Sharp program to find the largest number among three numbers entered by the user.

using System; 
using System.ComponentModel.Design; 

namespace Program 

{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            Console.Write("Enter a number 1 : "); 
            double number1 = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Enter a number 2 : "); 
            double number2 = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Enter a number 3 : "); 
            double number3 = Convert.ToDouble(Console.ReadLine());

            // compare three number 
            if (number1 > number2 && number1 > number3)

            {
                Console.WriteLine("Number one is the largest.");
            }

            else if (number2 > number1 && number2 > number3)

            {
                Console.WriteLine("Number two is the largest.");
            }

            else

            {
                Console.WriteLine("Number three is the largest.");
            } 

        } 

    } 

} 