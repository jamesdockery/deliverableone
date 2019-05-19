using System;

namespace funplacestogo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int choice;
            int people;

            // Greets user. Asks first question.
            Console.WriteLine("Hello User! I hope you're in the mood for a fantastic weekend! What are you in the mood for?");
            string[] starray = new string[]{"1) Action",
            "2) Chill times",
            "3) Danger",
            "4) Good Food"};

            string str = String.Join("\n", starray);
            Console.WriteLine(str);

            // Takes user input
            Console.Write("Enter Choice:");

            choice = Convert.ToInt32(Console.ReadLine());

            // Catches user error. Prints argument exception
            if (choice > 4)
            {
                throw new ArgumentException("Sorry, your input was not understood. Please enter 1-4");

            }

            // Program Continues
            Console.WriteLine("Great! How many people are you bringing with you?");


            Console.Write("Number of people:");

            people = Convert.ToInt32(Console.ReadLine());





            // Determines activity based on user preference
            if (choice == 1)
            {
                Console.WriteLine("Since you're in the mood for action you should go stock car racing");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Since you're in the mood for chilling you should go hiking");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Woah! Since you're in the mood for danger you should go skydiving");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Yum! Since you're in the mood for good food I'd recommend Five Guys. Cheeseburgers never dissapoint! Oh,");
            }

            // Decides how the user should travel
            if (people == 0)
            {
                Console.WriteLine("and you should travel in comfortable sneakers!");
            }
            else if (people <= 4)
            {
                Console.WriteLine("and you should travel in a Sedan!");

            }
            else if (people <= 10)
            {
                Console.WriteLine("and you should travel in a Volkswagen Bus!");

            }
            else if (people >= 11)
            {
                Console.WriteLine(" and you should travel in an airplane!");

            }
            else
            {
                throw new ArgumentException("Sorry, your input was not understood. Please enter a numerical value.");
            }


            // End of program. Wishes user Goodbye

            Console.WriteLine("Have fun! Goodbye...");



        }
    }
}

