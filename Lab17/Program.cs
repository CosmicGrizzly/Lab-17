using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            bool intIsSuccess = false;

            Console.WriteLine("Let's locate some primes!\n");
            Console.WriteLine("This application will find you any prime, in order, from the first prime number on.");

            while (proceed)
            {
                intIsSuccess = false;
                int getPrime = 0;
                while (!intIsSuccess)
                {
                    Console.Write("Which prime number are you looking for? ");
                    intIsSuccess = int.TryParse(Console.ReadLine(), out getPrime);
                }
                
                int myPrime = PrimeNumberGenerator.GetPrimeNumber(getPrime);
                Console.WriteLine($"The number {getPrime} prime is {myPrime}.\n");
                Console.Write("Do you want to find another prime number? (y/n): ");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    proceed = true;
                }
                else
                {
                    proceed = false;
                }
            }

            Console.WriteLine("Thank you and good-bye!");
           

        }
    }
}
