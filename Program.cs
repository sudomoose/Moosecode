//THIS APPLICATION WAS CODED BY MOOSECOOP(COOPER MAKHIJANI), BUT INSPRIED AND BASED OFF OF BARNACULES NERGASM'S MAGIC 8 BALL CODEGASM
using System;
using System.Threading;

namespace TheMagic8Ball
{
    //class Cooper
    //{
    //    private static string name = "Cooper";
    //    public static string alias = "Moosecoop";
    //    private static int age = 11;
    //}

    /// <summary>
    /// Entry point for magic 8 ball program by moosecoop
    /// </summary>
    class Program
    {
      
        static void Main(string[] args)
        {
            //perserve current console text color
            ConsoleColor oldColor = Console.ForegroundColor;

            TellPeopleWhatProgramThisIs();
            //create a randomizer object
            Random randomObject0 = new Random();
            
            //loop forever
            while (true)
            {
                string questionString = GetQuestionFromUser();

                //pause for rand num of secs to give illusion of comp thinking
                int numberOfSecondsToSleep = randomObject0.Next(5) + 1;
                Console.WriteLine("Consulting Prophets About Your Answer.");
                Thread.Sleep(numberOfSecondsToSleep * 1000);
                if(questionString.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Must Type A Question Fool!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                //check if user typed 'quit'
                if( questionString.ToLower() == "quit")
                {
                    break;
                }

                if (questionString.ToLower() == "you suck")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("( °_° ): ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" You Suck Too!");
                    Console.ForegroundColor = ConsoleColor.White;
                    //leaves blank line
                    Console.WriteLine();
                    break;
                }

                //get rand num
                int randomNumber = randomObject0.Next(4);

                Console.ForegroundColor = (ConsoleColor)randomObject0.Next(15);

                //use rand num to determine response
                switch(randomNumber)
                {
                    case 0: 
                        {
                        Console.WriteLine("yes");
                            break; 
                        }
                    case 1:
                        {
                        Console.WriteLine("no");
                            break;
                        }
                    case 2:
                        {
                        Console.WriteLine("maybe");
                            break;
                        }
                    case 3:
                        {
                        Console.WriteLine("ask again");
                            break;
                        }
                }
            } //end of while loop


            //Cleeaning Up
            Console.ForegroundColor = oldColor;
        }
        /// <summary>
        /// print name of program + maker of it to console
        /// </summary>
        static void TellPeopleWhatProgramThisIs()
        {
            //change console text color
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Magic 8 Ball");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" (by: Moosecoop)");
        }

        /// <summary>
        /// gets question from user
        /// </summary>
        static string GetQuestionFromUser()
        {
            //this block of code will ask the user for a question
            //and store the text in a questionString variable
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask A Question: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string questionString = Console.ReadLine();

            return questionString;
        }

    }
}