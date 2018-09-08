using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

//Namespace packages classes to avoid the repetiiton of class
//names in the same package
namespace GuessNumber
{
    //Main Class deafault name is Program
    class Program
    {
        //Code is executed from here
        static void Main(string[] args)
        {
            //START CODE HERE
            /*string name = "Maanasa Magatala";
            string name2 = "Welcome to C#";
            int age = 22;

            Console.WriteLine("Hello " + name + name2);
            Console.WriteLine("{0} is {1}", name, age);*/

            //Application information stored in funtion
            getAppInfo();

            //Ask for user name
            userName();

            while (true)
            {
                //Initialize correct number
                //int correctnumber = 7;

                //Create a new random number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Initialize guess variable
                int guess = 0;

                //Ask user for an input
                Console.WriteLine("Guess a number from 1 to 10");

                //Ask user for the number until its guessed
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        printColourMessage(ConsoleColor.Blue, "Please enter an actual number");
                        
                        //This allows the application to keep running in the while loop
                        //If not here than the application shuts down as it breaks the while loop
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        //Inform user its the wrong number
                        printColourMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //Output success message
                printColourMessage(ConsoleColor.Yellow, "You got the Correct Answer!!!!");


                //Ask the user again
                Console.WriteLine("Want to play again? [Y or N]");

                //Get the answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        //Display application information
        static void getAppInfo()
        {
            //Set application variables
            string appName = "Guess Number";
            string appVersion = "1.0.0";
            string appAuthor = "Maanasa";

            
            //Change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            //Display application variables
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text colour
            Console.ResetColor();
        }

        //Get user name
        static void userName()
        {
            //Ask user name
            Console.WriteLine("Enter user name: ");

            //Get user name
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);

        }

        //Print coloured messages on comcole with this funtion
        static void printColourMessage(ConsoleColor color, string message)
        {
            //Change text colour
            Console.ForegroundColor = color;

            //Inform user its not a number
            Console.WriteLine(message);

            //Reset text colour
            Console.ResetColor();

        }
    }
}
