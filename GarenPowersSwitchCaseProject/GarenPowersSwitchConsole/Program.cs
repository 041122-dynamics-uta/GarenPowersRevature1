using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4DataStructures
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type A Number To Get A Primary Color");
            Console.WriteLine("1, 2, or 3");

            // int red = 1;
            // int blue = 2;
            // int green = 3;
            int X = Convert.ToInt32(Console.ReadLine());


            switch (X)
            {
                case 1:
                    Console.WriteLine("Red");
                    break;
                case 2:
                    Console.WriteLine("Blue");
                    break;
                case 3:
                    Console.WriteLine("Yellow");
                    break;

                default:
                    Console.WriteLine("Choose Another Primary Color");
                    string day = Console.ReadLine();
                    break;
            }

        }
    }
}