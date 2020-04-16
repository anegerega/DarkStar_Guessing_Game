using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Show_Main_Menu();
        }
        public static void Show_Main_Menu()
        {
            Console.WriteLine("===========WELCOME TO DarkStar GUESSING GAME============");
            Console.WriteLine("===========SELECT A LEVEL(1, 2 or 3)============");
            Console.WriteLine("        1. EASY");
            Console.WriteLine("        2.MEDIUM");
            Console.WriteLine("        3 HARD");

            string userselection = Console.ReadLine();
            switch (userselection)
            {
                case "1":
                    Easy_Level();
                    break;
                case "2":
                    Medium_Level();
                    break;
                case "3":
                    Hard_Level();
                    break;
                default:
                    Console.Write("You have entered an invalid input, Please enter 1 , 2 or 3 : ");
                    string userinput = Console.ReadLine();
                    if (userinput == "1")
                        Show_Main_Menu();
                    else
                        Console.WriteLine("Goodbye!");
                    break;
            }
        }
        public static void Easy_Level() //Easy level where user has up to 6 guesses
        {
            // Generating a random number between 1 and 10
            Random Rand = new Random();
            int RandNum = Rand.Next(1, 10);

            Console.WriteLine("EASY LEVEL!!");
            Console.Write("Guess any number from 1 to 10: ");
            int userguess = Convert.ToInt32(Console.ReadLine());
            int guessLimit = 5;
            int guessCount = 0;
            bool outofguesses = false;
            int i = -1;

            while (userguess != RandNum && !outofguesses)
            {
                if (guessCount < guessLimit)
                {
                    i++;
                    Console.WriteLine("That was wrong, try again " + "(you have " + (guessLimit - i) + " more trial(s))");
                    userguess = Convert.ToInt32(Console.ReadLine());
                    guessCount++;
                }
                else
                {
                    outofguesses = true;
                }
                if (outofguesses) //Game over but does the user want to play again? they can select a difficulty level again.
                {
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("Do You want to play again? ");
                    string userdecision = Console.ReadLine();
                    string userdecides = userdecision.ToUpper();
                    if(userdecides == "YES")
                    {
                        Show_Main_Menu();
                    }else if(userdecides == "NO")
                    {
                        Console.WriteLine("Thank you for playing DarkStar, Goodbye!");
                    }

                }
                else if(userguess == RandNum)
                {
                    Console.WriteLine("You got it right!");
                }
            } 
        }

        public static void Medium_Level() //Difficulty level here is medium (guesses allowed is 4)
        {
            // Generating a random number between 1 and 20
            Random Rand = new Random();
            int RandNum = Rand.Next(1, 20);

            Console.WriteLine(" OK, LETS PLAY MEDIUM!!");
            Console.Write("Guess any number from 1 to 20: ");
            int userguess = Convert.ToInt32(Console.ReadLine());
            int guessLimit = 3;
            int guessCount = 0;
            bool outofguesses = false;
            int i = -1;

            while (userguess != RandNum && !outofguesses)
            {
                if (guessCount < guessLimit)
                {
                    i++;
                    Console.WriteLine("That was wrong, try again " + "(you have " + (guessLimit - i) + " more trial(s))");
                    userguess = Convert.ToInt32(Console.ReadLine());
                    guessCount++;
                }
                else
                {
                    outofguesses = true;
                }
                if (outofguesses)
                {
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("Do You want to play again? ");
                    string userdecision = Console.ReadLine();
                    string userdecides = userdecision.ToUpper();
                    if (userdecides == "YES")
                    {
                        Show_Main_Menu();
                    }
                    else if (userdecides == "NO")
                    {
                        Console.WriteLine("Thank you for playing DarkStar, Goodbye!");
                    }

                }
                else if (userguess == RandNum)
                {
                    Console.WriteLine("You got it right!");
                }
            }
        }

        public static void Hard_Level() //Difficulty level here is Hard, user can only guess 3 times
        {
            // Generating a random number between 1 and 50
            Random Rand = new Random();
            int RandNum = Rand.Next(1, 50);

            Console.WriteLine("LETS PLAY HARD!!");
            Console.Write("Guess a number from 1 to 50: ");
            int userguess = Convert.ToInt32(Console.ReadLine());
            int guessLimit = 2;
            int guessCount = 0;
            bool outofguesses = false;
            int i = -1;

            while (userguess != RandNum && !outofguesses)
            {
                if (guessCount < guessLimit)
                {
                    i++;
                    Console.WriteLine("That was wrong, try again " + "(you have " + (guessLimit - i) + " more trial(s))");
                    userguess = Convert.ToInt32(Console.ReadLine());
                    guessCount++;
                }
                else
                {
                    outofguesses = true;
                }
                if (outofguesses)
                {
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("Do You want to play again? ");
                    string userdecision = Console.ReadLine();
                    string userdecides = userdecision.ToUpper();
                    if (userdecides == "YES")
                    {
                        Show_Main_Menu();
                    }
                    else if (userdecides == "NO")
                    {
                        Console.WriteLine("Thank you for playing DarkStar, Goodbye!");
                    }

                }
                else if (userguess == RandNum)
                {
                    Console.WriteLine("You got it right!");
                }
            }
        }
    }
}
