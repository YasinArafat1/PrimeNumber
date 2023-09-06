using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter any number to see the number is prime or not ");
            number = Convert.ToInt32(Console.ReadLine());

            int count=0;

            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0)
                { 
                
                count++;
                } 
            }
            if (count==2)
            {
                Console.WriteLine("its a prime number");
            }
           else 
            {
                Console.WriteLine("its not a prime number");
            }




            Console.ReadKey();
        }
    }
}
