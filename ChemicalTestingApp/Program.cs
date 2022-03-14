using System;

namespace ChemicalTestingApp
{
    class Program
    {

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

            while (flag)
            {
                // Game Menu


                //Player Menu
                menuChoice = CheckInt("App Menu\n" +
                    "1. Continue\n" +
                    "2. Quit" ,1,2); 
                   
                if (menuChoice == 1)
                {
                    ChemicalTest(1);
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

        static void ChemicalTest(int gametype)
        {
            //Generate Random Number of Germs 
            Random r = new Random();
            int rInt = r.Next(1,1000);
            Console.WriteLine($"Your Random Amount of Germs Generated was {rInt}\n");

            Console.WriteLine("Please Enter The Chemical you would like to test");
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
            {

            }
            else
            {

            }
            Console.WriteLine($"Please Wait");
            Random j = new Random();
            int jInt = j.Next(10,200);
            Console.WriteLine($"{rInt}");



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
