// Write a C# Sharp program to determine the eligibility for admission to a professional course based on the following criteria: 
// Marks in Math >=65 
// Marks in Physics >=55 
// Marks in Chemistry>=50 
// Total in all three subject >=180 
// or 
// Total in Math and any one of the other Subjects >=140 

using System; 
using System.Data.Common; 

namespace Hello  
{
    class Program
    {
        static void Main(string[] args)
        {
            // asking user to enter marks 

            Console.Write("Enter Your Marks in Maths: ");
            double markMath = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Your Marks in Physics: ");
            double markPhy = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Your Marks in Chemistry: ");
            double markChem = Convert.ToDouble(Console.ReadLine());

            // total of three marks 

            double totalMark = (markMath + markChem + markPhy);

            // checking the conditions 

            if (markMath >= 65 && markChem >= 50 && markPhy >= 55 && totalMark >= 180)

            {
                Console.WriteLine("Congratulations! You are eligble for the course!");
            }

            else if ((markMath + markChem) >= 140 || (markMath + markPhy) >= 140)

            {
                Console.WriteLine("Congratulations! You are eligble for the course!");
            }

            else

            {
                Console.WriteLine("Sorry! You are not eligble for the course!");
            }

        }

    }  
    
} 