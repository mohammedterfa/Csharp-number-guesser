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

        int correctNumber = 7;

        int guess = 0;

        Console.WriteLine("Guess a number between 1 and 10");

        while(guess != correctNumber)
        {
            string input = Console.ReadLine();

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


        }
        
    }
}