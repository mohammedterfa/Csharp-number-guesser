using System;

namespace myproject
{
    class prgram
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function

            GreetUser(); // Ask for user name and greet

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

                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        
                        continue;
                    }

                guess = Int32.Parse(input);

                if(guess != correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Wrong number plaese try again");
                }
            }

            PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT");

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

        static void GetAppInfo(){
           string appName = "number guesser";
           string appVersion = "1.0.0";
           string appAuthor = "Mohammed Terfa";

           Console.ForegroundColor = ConsoleColor.Green;
        
           Console.WriteLine("{0} : version {1} by {2}", appName, appVersion, appAuthor);

           Console.ResetColor();
        }


        static void GreetUser(){

            Console.WriteLine("What is your name ? ");

            string inputName = Console.ReadLine();

            Console.WriteLine("hello {0}, let`s play a game ...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message){

            Console.ForegroundColor = color;
            
            Console.WriteLine(message);

            Console.ResetColor();

        }


        
    }
}