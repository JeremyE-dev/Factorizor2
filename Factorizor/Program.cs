using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromUser();

            Calculator.PrintFactors(number);
            Calculator.IsPerfectNumber(number);
            Calculator.IsPrimeNumber(number);

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

       
        static int GetNumberFromUser()
        {
            int num;
            while (true)
            {

                Console.Write("Please enter a number:  ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out num)) {
                    break;
                }

                else
                {
                    Console.WriteLine("That was not a number");
                }


            }

            return num;

       
        }
    }

    class Calculator
    {
        /// <summary>
        /// Given a number, print the factors per the specification
        /// </summary>
        public static void PrintFactors(int number)
        {
            int[] array = new int[number];
            int index = 0;
         
            for(int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    array[index] = i;
                    index++;

                }
            }

            Array.Resize(ref array, index);


            string s = string.Join(" ", array);

          
            Console.WriteLine("the factors of {0} are {1}", number, s);

        }

        /// <summary>
        /// Given a number, print if it is perfect or not
        /// </summary>
        public static void IsPerfectNumber(int number)
        {
            

            int sum = 0;
            for (int i = 1; i < number; i++)
            {   
                
                if (number % i == 0)
                {

                    sum += i;
                }

            }

            if(sum == number)
            {
                Console.WriteLine("{0}  is a perfect number", number);
            }

            else
            {
                Console.WriteLine("{0} is not a perfect number", number);
            }


        }

        /// <summary>
        /// Given a number, print if it is prime or not
        /// </summary>
        public static void IsPrimeNumber(int number)
        {
           

            if(number == 0 || number == 1)
            {
                Console.WriteLine("{0} is a not a prime number", number);
                return;
            }

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0 && i != 1 && i != number)
                {
                    Console.WriteLine("{0} is a not a prime number", number);
                    return;

                }
            }

            Console.WriteLine("{0} is a prime number", number);


        }
    }
}
