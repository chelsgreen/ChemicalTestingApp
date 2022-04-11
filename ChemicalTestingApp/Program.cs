//imports
using System;
using System.Threading;
using System.Collections.Generic;
using System.Globalization;


namespace ChemicalTestingApp
{
    class Program
    {
        // Global Variables 
        static readonly List<string> CHEMICALS = new List<string>() { "Sodium Hydroxide", "Hydrogen Peroxide",
            "Bleach", "Chlorine", "Sodium Bisulfate" };
        // Lists
        static List<int> chosenChem = new List<int>();
        static List<float> chemicalRating = new List<float>();

        //main program 
        static void Main(string[] args)
        {
            int menuChoice;
            bool flag = true;
            //Welcome Menu-Instructions-Help 
            Console.WriteLine("    --------------Welcome to Chemical Testing--------------\n" +
                "This App is used to test efficenty of Chemicals when killing bugs\n\n" +
                "*****************************************************************\n\n" +
                "   Help/Instructions:\n" +
                "1: Program Generates an amount of germs.\n" +
                "2: You need to select the chosen Chemical you would like to test. \n" +
                "3: Then after 30 seconds the amount of germs gets messured again\n" +
                "   to see how many germs are left.\n" +
                "4: Program then repeats the test 4 more times for an accurate \n" +
                "   result\n" +
                "5: Program then averages the 5 test.\n" +
                "6: You then have the option to test another chemical to find a\n " +
                "  more efficent chemical or select 2 when done.\n\n" +
                "*****************************************************************\n");
            
            //App Menu 

            while (flag)

            {
                //Player Menu 
                menuChoice = CheckInt("   App Menu:\n" +
                    "1. Continue\n" +
                    "2. Quit", 1, 2);
                Console.WriteLine("\n");

                
                if (menuChoice == 1)
                {
                    ChemicalTest();
                }
              
                else if (menuChoice == 2)
                {
                    Console.WriteLine("Thank you for Trying Chemical Testing :D ");
                    flag = false;
                }

                else
                {
                    Console.WriteLine("Invalid menu: Must be 1(Continue) or 2(Quit) \n\n");
                }

            }

        }

        //Validate Chemical Choice
        static bool CheckChemical(int chemChoice)
        {
           return chosenChem.Contains(chemChoice);
        }

       //Test For Chemical Efficency
        static void ChemicalTest()
            
        {
            bool flag3 = true;
            while (flag3)
            {
                //List of Chemicals 
                Console.WriteLine("*****************************************************************\n" +
                    "Please choose a chemical you are wanting to test with from the list:\n" +
                $"1. {CHEMICALS[0]} \n" +
                $"2. {CHEMICALS[1]} \n" +
                $"3. {CHEMICALS[2]} \n" +
                $"4. {CHEMICALS[3]} \n" +
                $"5. {CHEMICALS[4]} \n" +
                $"6. Exit Program\n" );

                int userChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("*****************************************************************");
                //Tests If Chemical Has Been Used Before
                if (userChoice == 6) 
                {
                    Console.WriteLine("Thank you for Trying Chemical Testing :D ");
                    Environment.Exit(0);
                }

                if (CheckChemical(userChoice-1))
                {
                    Console.WriteLine("\n\nError: You have already tested this chemical\n");
                }
                else 
                {
                    
                    chosenChem.Add(userChoice - 1); 
                    flag3 = false;
                }
                
            }
            
                
           
            float sumEfficency = 0;

            //Runs five times  
            for (int i = 0; i < 5; i++)
            {
                //Generates Random Number For First Test 
                Random r = new Random();
                int rInt = r.Next(200, 1000);               
                Console.WriteLine("----------------------------------------------\n");
                Console.WriteLine($"Your Random Amount of Germs Generated was {rInt}\n");
                

                //Program Delays For 30 Seconds
                Console.WriteLine($"           Please Wait 30 seconds\n" +
                    $"              ----------------\n"); 
                System.Threading.Thread.Sleep(30000);
                

                //Generates Random Number For Second Test
                Random j = new Random();
                int jInt = j.Next(10, 199);
                Console.WriteLine($"   The Second Messurement of Germs is {rInt-jInt} ");

                //Efficency Of The Test
                float efficency = (rInt-jInt) /30;
                Console.WriteLine($"   The Efficency of {CHEMICALS[chosenChem[chosenChem.Count - 1]]} is {efficency}\n");
                Console.WriteLine("----------------------------------------------");
                
                sumEfficency += efficency;
            }

            float average = sumEfficency / 5;

            //Average Of Chemical Efficency 
            Console.WriteLine($"   The average Efficeny {CHEMICALS[chosenChem[chosenChem.Count - 1]]}      \n " +
                $"                   {average}");


            //The Final Efficiency Rating Of All 5 Tests 
            float finalEffRate = (float)Math.Round(average / 5, 2);
            chemicalRating.Add(finalEffRate);


            Console.WriteLine(
            $"   The average efficiency rate of the 5 \n" +
            $"                tests is: {finalEffRate}\n\n" +

            "----------------------------------------------");
           
            
        }
            //check The Interger For App Menu 
            static int CheckInt(string question, int min, int max)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine(question);
                        int user_choice = Convert.ToInt32(Console.ReadLine());

                        if (user_choice >= min && user_choice <= max)

                        {
                            return user_choice;
                        }

                        else

                        {
                            Console.WriteLine($"Error:Please pick a number between {min} and {max}");
                        }

                    }

                    catch

                    {
                        Console.WriteLine($"\nError:Please pick a number between  {min} and {max}");
                    }

                }
            }
        }
    }

 