using System;

// Namespace
// Not DRY code - expanded to fully understand all components
namespace CSharpTutorial
{
// Main Class
    class Program
    // inside class we can have variables and methods
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            string name = "Ryan Patrick Pitts";
            int age = 35;


            //Code starts here
            Console.WriteLine("Hello " + name + " Its The World!");
            Console.WriteLine(name + " is " + age);
            Console.WriteLine("{0} is {1}", name, age);
            Console.Beep();

            GetAppInfo(); // Run GetAppInfo function

            GreetUser(); // Ask for users name and greet

            while (true) { 
            // Set correct number
            //int correctNumber = 7;

            // Create a new random object
            // Random object is available for use
            Random random = new Random();

            //Generates a random number
            // 
            int correctNumber = random.Next(1,10);

            // Init guess var
            int guess = 0;

            //Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            // if the number doesnt match we want to loop until user gets it right

            while (guess != correctNumber)
            //Get users input
            {
                string input = Console.ReadLine();

                // Make sure its a number
                if (!int.TryParse(input, out guess))
                {

                    //change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Write out app info
                    Console.WriteLine("Please enter a number");

                    //reset back to the default white color
                    Console.ResetColor();

                    // Keep going
                    continue;

                }

                // Cast to int and put in guess

                guess = Int32.Parse(input);

                // Match guess to correct number

                if (guess != correctNumber)
                {
                    //change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Write out app info
                    Console.WriteLine("Wrong Number Please Try Again");

                    //reset back to the default white color
                    Console.ResetColor();

                }

            }

            // Output sucess message - correct guess

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("You are correct");

            //reset back to the default white color
            Console.ResetColor();



            // Ask to play again
            Console.WriteLine("Play Again? [Y or N]");

            // Get answer
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                continue;
            }
            else if (answer == "N")
            {
                return;
            }
            else
            {
                return;
            }
         }
       }

        static void GetAppInfo()
        {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Ryan Pitts";

            //change text color
            Console.ForegroundColor = ConsoleColor.DarkGray;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset back to the default white color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask the users name
            Console.WriteLine("What is your name");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game", inputName);
        }
    }
}