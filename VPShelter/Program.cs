using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {


            //nteractive user interface 
            //Display current status of pet
            //Display options for interacting with pet
            //Ask user what action to take
            int userChoice;

            VirtualPet userVirtualPet = new VirtualPet();

            do
            {

                Console.WriteLine(" ");
                Console.WriteLine("Welcome to the Virtual Pet Shelter");
                Console.WriteLine("Please enter a 1 if volunteer or a 2 if Manager");
                //string volunteerTY = Console.WriteLine("Thank you for volunteering!");
                //string mgrTY = Console.WriteLine("Thank you for managing!");
                //Console.WriteLine("To check it's status 3");
                Console.WriteLine("To quit, type, type 3");

                userChoice = int.Parse(Console.ReadLine());
                userVirtualPet.Tick();



                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Thank you for volunteering!");
                        Console.WriteLine("You may choose from the following:");
                        Console.WriteLine("1. Feed the pets");
                        Console.WriteLine("2. Water the pets");
                        Console.WriteLine("3. Play with a Virtual Pet, Virtually...");
                        int volChoice = int.Parse(Console.ReadLine());
                        if (volChoice == 1)
                        {
                            Console.WriteLine("The pets are fed!");
                        }
                        if (volChoice == 2)
                        {
                            Console.WriteLine("the pets have water!");
                        }
                        if (volChoice == 3)
                        {
                            Console.WriteLine("Which pet do you want to play with?");
                            Console.WriteLine("1. Maurice, the Malamute");
                            Console.WriteLine("2. Chauncey the Demon");
                            Console.WriteLine("3. Lockheed the Dragon");
                            int playChoice = int.Parse(Console.ReadLine());
                            if (playChoice == 1)
                            {
                                Console.WriteLine("You play fetch with Maurice");
                            }
                            if (playChoice == 2)
                            {
                                Console.WriteLine("You allow Chauncey 5 minutes of freedom. What could go wrong?");
                            }
                            if (playChoice == 3)
                            {
                                Console.WriteLine("You fly around with Lockheed for a bit, chasing seagulls and downing some brews.");
                            }
                            else
                            {
                                Console.WriteLine("You chose poorly...");
                            }
                        }
                        else
                        { }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Thank you for managing!");
                        Console.WriteLine("You may choose from the following:");
                        Console.WriteLine("1. Coordinate Adoption of a Virtual Pet");
                        Console.WriteLine("2. Play with a Virtual Pet, Virtually...");
                        int mgrChoice = int.Parse(Console.ReadLine());
                        if (mgrChoice == 1)
                        {
                            Console.WriteLine("Which pet is getting adopted?");
                            Console.WriteLine("1. Maurice, the Malamute");
                            Console.WriteLine("2. Chauncey the Demon");
                            Console.WriteLine("3. Lockheed the Dragon");
                            int adoptChoice = int.Parse(Console.ReadLine());
                            if (adoptChoice == 1)
                            {
                                Console.WriteLine("Maurice will be the most normal choice.");
                            }
                            if (adoptChoice == 2)
                            {
                                Console.WriteLine("Oh dear...Make sure they sign the release form. Well, Chauncey will be happy...");
                            }
                            else
                            {
                                Console.WriteLine("Lockheed will like upstate NY just fine. A school you say...?");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Which pet do you want to play with?");
                            Console.WriteLine("1. Maurice, the Malamute");
                            Console.WriteLine("2. Chauncey the Demon");
                            Console.WriteLine("3. Lockheed the Dragon");
                            int playChoice = int.Parse(Console.ReadLine());
                            if (playChoice == 1)
                            {
                                Console.WriteLine("You play fetch with Maurice");
                            }
                            if (playChoice == 2)
                            {
                                Console.WriteLine("You allow Chauncey 5 minutes of freedom. What could go wrong?");
                            }
                            if (playChoice == 3)
                            {
                                Console.WriteLine("You fly around with Lockheed for a bit, chasing seagulls and downing some brews.");
                            }
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        break;
                }

            } while (userChoice != 3);
        }
    }
}
