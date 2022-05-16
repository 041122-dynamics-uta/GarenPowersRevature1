using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using StoreAppDomain;
using StoreAppModel;
using StoreAppStorage;

namespace GarenPowersP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings Traveler And Welcome,You Seek A New Armor?");
            Console.WriteLine("What Name Are You Known By?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("What Family Name Were You Born Under?");
            string LastName = Console.ReadLine();
            Console.WriteLine("Whats The Secret Phrase?");
            string Credentials = Console.ReadLine();
            Console.WriteLine("And Whats A Good Email To Reach You?");
            string Email = Console.ReadLine();
            Repo R = new Repo();

            StoreAppDomainClass SADC = new StoreAppDomainClass(R);

            List<Buyer> Buyer = SADC.MembersList();

            foreach (Buyer B1 in Buyer)
            {
                Console.WriteLine($"The members data is Fname-{B1.FirstName}.....");
            }
        }
    }
}
