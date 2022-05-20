using System;
using System.Linq;
using System.Collections.Generic;

namespace cSharpSweetNSalty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the First Number");
            int a = Convert.ToInt32(Console.ReadLine()); //convert string to number
            Console.WriteLine("Please enter Last Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Results per line would you like?");
            int length = Convert.ToInt32(Console.ReadLine());

            //variables
            int range = b - a;//finding range Cameron and others helped with this
            IEnumerable<int> all = Enumerable.Range(a, range);//enumerable will allow you to use a range method
            int check = 0;//keep count of how man

            //Use to get the total number of instances
            int sw = 0; 
            int st = 0;
            int swst = 0;

            foreach(int s in all)
            {
                if(check == length)
                {
                    Console.WriteLine();
                    check = 0;
                }
                if (s % 3 == 0 && s % 5 == 0)//if divisible by 3 and 5
                {
                    Console.WriteLine("Sweet'nSalty");
                    swst++;
                } 
                else if ( s % 3 == 0) //divisible by 3
                {
                    Console.WriteLine("Sweet");
                    sw++;
                }
                else if (s % 5 == 0)//divisible by 5
                {
                    Console.WriteLine("Salty");
                st++;
                }            
                else
                {
                Console.WriteLine($"{s}");//print number
                }
                check++;                 
            }
            //result is printed 
            Console.WriteLine();
            Console.WriteLine($"The Number of Sweets is {sw}");
            Console.WriteLine($"The Number of Salty's is {st}");
            Console.WriteLine($"The Number of Sweet&Salty is {swst}");
            Console.WriteLine();
        }
    }
}