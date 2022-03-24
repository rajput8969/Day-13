            //Given 3 Integers find the maximum//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            // set the value of the three numbers
            Console.WriteLine("Enter the first number : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            num3 = int.Parse(Console.ReadLine());
          

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the Maximum!\n");
                }
                else
                {
                    Console.Write("Number three is the Maximum!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the Maximum!\n");
            else
                Console.Write("Number three is the Maximum!\n");
        }
    }
}
