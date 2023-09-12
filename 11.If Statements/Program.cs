using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calling methods from the main method
            VotingAge();                //calling method 1
            Gender();                   //calling method 2
            LogicalOperators();         //method 3
            ShortHandIf1();             //calling method 4
            ShortHandIf();              //calling method 5

            //freeze the console
            Console.ReadLine();
            
        }
        static void VotingAge()
        {
            Console.WriteLine("Enter the year born in: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int age = 2023 - year;
            int votingAge = 18;
            if (age >= votingAge)
            {
                Console.WriteLine("You are eligible to vote, because you are, " + age + " which is above 18");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote, because you are " + age + " which is less than 18");
            }
        }
        static void Gender()
        {
            bool isMale = true;
            
            if (!isMale)
            {
                Console.WriteLine("female");
            }
            else
            {
                Console.WriteLine("male");
            }
        }
        static void LogicalOperators()
        {
            bool isMale = true;
            bool isTall = false;
            if (isMale &&  isTall)
            {
                Console.WriteLine("You are a tall male. ");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short guy");
            }
            else if ( !isMale && isTall)
            {
                Console.WriteLine("You are a tall lady");
            }
            else
            {
                Console.WriteLine("You neither a male or tall");
            }
        }
        static void ShortHandIf1()
        {
            Console.WriteLine("Enter your weight");
            double weight = Convert.ToDouble(Console.ReadLine());
            
            if (weight >+ 90)
            {
                Console.WriteLine("You are Overweight");
            }
            else if (weight >= 70 && weight < 90)
            {
                Console.WriteLine("You are healthy but not really in a good shape");
            }
            else
            {
                Console.WriteLine(" you are healthy and in a good shape");
            }
        }
        static void ShortHandIf()
        {
            Console.WriteLine("Enter your weight");
            double weight = Convert.ToDouble(Console.ReadLine());
            //this is a short hand if else statement still working out the short hand for if else if statement if there is any
            //line 82 - 84 and 90 to 93 can be replaced by the following line
            string results = (weight >= 90) ? "You are overweight" : "You are healthy but not really in a good shape ";
            Console.WriteLine(results);//this line prints the result on the console
        }
    }
}
