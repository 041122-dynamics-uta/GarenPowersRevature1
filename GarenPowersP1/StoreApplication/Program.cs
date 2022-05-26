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
            Console.WriteLine("Welcome To Garens Mystical Armor Shop");
            Console.WriteLine("Greetings Traveler, You Seek A New Armor?");
            Console.WriteLine("Please select from the list \n press 1 to register \n press 2 to login");
            int Option1 = Convert.ToInt32(Console.ReadLine());
            switch (Option1)
            {
                case 1:
                    Console.WriteLine("What Name Are You Known By?");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("What Family Name Were You Born Under?");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Whats The Secret Phrase?");
                    string Credentials = Console.ReadLine();
                    Console.WriteLine("And Whats A Good Email To Reach You?");
                    string Email = Console.ReadLine();
                    Console.WriteLine("What Armor Would You Like To Buy?");
                    Console.WriteLine("We Offer Armor in Plate, Scale, Leather, Chainmail, Obsidian, Ceramic, Bronze and Runic fashion.");
                    Console.WriteLine("We Also Offer Standard Knight Armor In Respect To The King!");
                    //Console.WriteLine("Type Plate for Plate Armor, Scale For Scale Armor, Leather For Leather Armor, Chainamil For Chainmail Armor, Obsidian For Obsidian Armor, Ceramic For Ceramic Armor, Runic For Runic Armor, Knight For Knight Armor.");
                    String ArmorSelection = Console.ReadLine();
                    Console.WriteLine("Understood! Thank you Come Again!");
                    Repo R = new Repo();
                    StoreAppDomainClass SADC = new StoreAppDomainClass(R);
                    List<Buyer> Buyer = SADC.MembersList(FirstName, LastName, Credentials, Email);
                    break;
                case 2:
                    Console.WriteLine("Whats Your Email And Credentials?");
                    string ExistingEmail = Console.ReadLine();
                    string ExistingCredentials = Console.ReadLine();
                    //
                    //
                    Repo R1 = new Repo();
                    StoreAppDomainClass SADC1 = new StoreAppDomainClass(R1);
                    List<Buyer> ExistingBuyers = SADC1.UnamePwordExists(ExistingEmail, ExistingCredentials);
                    break;
                default:
                    Console.WriteLine("Please try again...");
                    break;
            }
            bool loopContinue = true;
            while (loopContinue)
            {
                Console.WriteLine("Welcome User");
                Console.WriteLine("select 1 Setting Your Store Location, 2 for List of Products , 3 for Order");
                // Use TryParse when reading the user input. This will avoid an
                // Exception if the user types a letter for example.
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please Select Your City");
                        Repo MRC2 = new Repo();
                        StoreAppDomainClass SADC2 = new StoreAppDomainClass(MRC2);
                        List<StoreLocation> SL = SADC2.MyStoreLocationsList();
                        foreach (StoreLocation SL2 in SL)
                        {
                            Console.WriteLine("--------------------------");
                            Console.WriteLine($"City --- [{SL2.City}]");
                            Console.WriteLine("-------------------------");
                            Console.WriteLine("Please Select your City");
                            string SelectCity = Console.ReadLine();
                        }
                        loopContinue = true;
                        break;
                    case 2:
                        Repo MRC3 = new Repo();
                        StoreAppDomainClass SADC3 = new StoreAppDomainClass(MRC3);
                        List<StoreInventoryList> SIL1 = SADC3.StoreInventoryList();
                        foreach (StoreInventoryList SI2 in SIL1)
                        {
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine($"Item Name --- [{SI2.ItemName}]");
                            Console.WriteLine($"Item Price --- [{SI2.ItemPrice}]");
                            Console.WriteLine($"Item Description --- [{SI2.ItemDescription}]");
                            Console.WriteLine($"Item Quantity --- [{SI2.ItemQuantity}]");
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("Please Select your Item Name");
                            string ItemName = Console.ReadLine();
                            int ItemPrice = SI2.ItemPrice;
                            string ItemDescription = SI2.ItemDescription;
                            Console.WriteLine("Enter Your Quantity");
                            int ItemQuantity = Convert.ToInt32(Console.ReadLine());
                        }
                        loopContinue = true;
                        break;
                    case 3:
                        Repo MRC4 = new Repo();
                        StoreAppDomainClass SADC4 = new StoreAppDomainClass(MRC4);
                        List<BuyerOrderHistory> COH = SADC4.BuyerOrderHistoryList();
                        foreach (BuyerOrderHistory COH2 in COH)
                        {
                            Console.WriteLine($"Item Name --- [{COH2.ItemName}]");
                            Console.WriteLine($"Item Price --- [{COH2.ItemPrice}]");
                            Console.WriteLine($"Item Description --- [{COH2.ItemOrderList}]");
                            Console.WriteLine("Please Select your Item Name");
                            string ItemName = Console.ReadLine();
                            int ItemPrice = Convert.ToInt32(COH2.ItemPrice);
                            Console.WriteLine("Enter Your Quantity");
                        }
                        loopContinue = true;
                        break;
                    // not really needed, if you remove the default
                    // then your loop will not exit and you can start again
                    case 4:
                        loopContinue = false;
                        break;
                }
                Console.WriteLine("Please Select from the Following: \n 1 for Store Location \n 2 for Item List and order selection \n 3 for OrderHistory \n 4 to Exit");
            }
            {

            }
        }
    }
}