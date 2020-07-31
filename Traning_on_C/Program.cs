using System;

namespace Traning_on_C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to enter their name
            Console.WriteLine("Enter your name");

            // read the user name
            String userName = Console.ReadLine();

            // ask the users weather or not they want to play a game
            Console.WriteLine("hello {0} do you want to play a game? Y or N",userName);
            String userResponce = Console.ReadLine();

            // check the user responce
                while(userResponce=="Y")
            {
                // call the fonction game

                int correctNumber = 4;
                // ask the user to guess a number
                Console.WriteLine(" guess a number between 1 and 10");
                int userGuessNumber = Int32.Parse(Console.ReadLine());

                // check if its the correct Number
                while (userGuessNumber != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Incorerct Guess, please try again");
                    Console.ForegroundColor = ConsoleColor.Black;
                    userGuessNumber = Int32.Parse(Console.ReadLine());
                }

                // user got the right answer
                // chnage color to green
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Good Job!you're correct");
                // change color back to black
                Console.ForegroundColor = ConsoleColor.Black;
                // 
                // ask the users weather or not they want to play a game
                Console.WriteLine("{0} do you want to  continue playing? Y or N", userName);
                userResponce = Console.ReadLine();
            }
             Console.WriteLine("Thank you , Have a good day "); 




        }
    }
}
