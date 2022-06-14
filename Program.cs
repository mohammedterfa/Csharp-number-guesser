using System;

namespace myproject
{
    class prgram
    {
        static void Main(string[] args)
        {
           string appName = "number guesser";
           string appVersion = "1.0.0";
           string appAuthor = "Mohammed Terfa";

           Console.ForegroundColor = ConsoleColor.Green;
        
           Console.WriteLine("{0} : version {1} by {2}", appName, appVersion, appAuthor);

           Console.ResetColor();

        Console.WriteLine("What is your name ? ");

        string inputName = Console.ReadLine();

        Console.WriteLine("hello {0}, let`s play a game ...", inputName);

        while(true) {

        

        //int correctNumber = 7;

        Random random = new Random();

        int correctNumber = random.Next(1, 10);

        int guess = 0;

        Console.WriteLine("Guess a number between 1 and 10");

        while(guess != correctNumber)
        {
            string input = Console.ReadLine();

                if(!int.TryParse(input, out guess)) { 
                    Console.ForegroundColor = ConsoleColor.Red;
        
                    Console.WriteLine("Please enter an actual number");

                    Console.ResetColor();

                    continue;
                }

            guess = Int32.Parse(input);

            if(guess != correctNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
        
                Console.WriteLine("Wrong number plaese try again");

                Console.ResetColor();
            }
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        
        Console.WriteLine("You are CORRECT");

        Console.ResetColor();

        // ask user to play again
        Console.WriteLine("Play Again ? [Y or N]");

        //Get answer
        String answer = Console.ReadLine().ToUpper();

        if(answer == "Y"){
            continue;
        }

        else if(answer == "N"){
            return;
        }

        else{
            return;
        }


            }
        }
        
    }
}