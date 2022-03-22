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
            "Sodium Hypochlorite", "Chlorine", "Sodium Bisulfate" };
  
        static List<int> chosenChem = new List<int>();
        static List<float> chemicalRating = new List<float>();

        static void Main(string[] args)

        {
            int menuChoice;
            bool flag = true;
            //Welcome Menu-Instructions-Help 
            Console.WriteLine("    --------------Welcome to Chemical Testing--------------\n" +
                "This App is used to test efficenty of Chemicals when killing bugs\n\n" +
                "Help:\n" +
                "1. Program Generates an amount of germs.\n" +
                "2. You need to enter the the Chemical you would like to test \n" +
                "3. Then after 30 seconds the amount of germs gets messured agaian\n" +
                "   to see how many germs are left\n");


            //App Menu 
            while (flag)

            {
                //Player Menu 
                menuChoice = CheckInt("App Menu\n" +
                    "1. Continue\n" +
                    "2. Quit", 1, 2);

                if (menuChoice == 1)
                {
                    ChemicalTest();
                }

                else if (menuChoice == 2)
                {
                    Console.WriteLine("Thank you for Trying Chemical Testing");
                    flag = false;
                }

                else
                {
                    Console.WriteLine("Invalid menu choice.\nChoice must be 1,2 or \n\n");
                }

            }

        }

        //main program 
        static void ChemicalTest()

        {
            //List of Chemicals 
            Console.WriteLine("Please choose a chemical you are wanting to test with from the list:\n" +
            $"1. {CHEMICALS[0]} \n" +
            $"2. {CHEMICALS[1]} \n" +
            $"3. {CHEMICALS[2]} \n" +
            $"4. {CHEMICALS[3]} \n" +
            $"5. {CHEMICALS[4]} \n"
            );

            chosenChem.Add(Convert.ToInt32(Console.ReadLine()) - 1);

            float sumEfficency = 0;

            //Runs five times  
            for (int i = 0; i < 5; i++)
            {
                Random r = new Random();
                int rInt = r.Next(200, 1000);
                Console.WriteLine($"Your Random Amount of Germs Generated was {rInt}");

                Console.WriteLine($"Please Wait 30 seconds");
                System.Threading.Thread.Sleep(30);

                Random j = new Random();
                int jInt = j.Next(10, 200);
                int Germs = rInt - jInt;

                Console.WriteLine($"The Second Messurement of Germs is {Germs} ");

                var efficency = (Germs) / 30;
                Console.WriteLine($"The Efficency of {CHEMICALS[chosenChem[chosenChem.Count - 1]]} is {efficency}\n");

                sumEfficency += efficency;
            }

            float average = sumEfficency / 5;

            //Average of Chemical Efficency 
            Console.WriteLine($"The average Efficeny of this Chemcial {average}");


            //Final Efficiency Rating of all 5 tests 
            float finalEffRate = (float)Math.Round(average / 5, 2);
            chemicalRating.Add(finalEffRate);


            Console.WriteLine(

            $"The average efficiency rate of the 5 tests is: {finalEffRate}\n" +

            "--------------------------------------------------------------");

        }
            //check the interger 

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
                            Console.WriteLine($"Error:Please pick a number between{min} and {max}");
                        }

                    }

                    catch

                    {
                        Console.WriteLine($"Error:Please pick a number between{min} and {max}");
                    }

                }

            }

        }

    }

 