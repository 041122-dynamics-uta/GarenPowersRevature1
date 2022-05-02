using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /**
                YOUR CODE HERE.
            **/
        }

        public static string GetName()
        {
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();
            return name;
        }

        public static string GreetFriend(string name)
        {
            return "Hello, " + name + ". " + "You are my friend.";
        }

        public static double GetNumber()
        {
            Console.WriteLine("What Is Your Number");
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }

        public static int GetAction()
        {
            Console.WriteLine("What Is your Action");
            int action = Convert.ToInt32(Console.ReadLine());
            return action;
        }

        public static double DoAction(double x, double y, int action)
        {
            switch (action)
            {
                case 1:
                    return x + y;
                case 2:
                    return Math.Abs(x - y);
                case 3:
                    return x * y;                   
                case 4:
                    return x / y; 
                default:
                    throw new FormatException("Wrong Format Type");
                    break;
            }   
        }
    }
}